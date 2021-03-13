using System;
using System.Diagnostics;
using System.Threading;
using Lora.GXM.WifiLora32;
using System.Device.Gpio;
using System.Text;
using Lora.GXM.OledDisplay1306;
using nanoFramework.Hardware.Esp32;
using Lora.GXM.OledFonts;
using devMobile.IoT.Rfm9x;



namespace LoRaTest
{
    public class Program
    {
        private const double Frequency = 915000000.0;
        private static GpioPin led = null;
        private const string DeviceName = "ESP32";
        private const string SpiBusId = "SPI1";
        private const byte RegVersion = 0x42;
               
        static void initRadio(SSD1306Driver oledScreen)
        {
            //Set LoRa Pins
            byte MessageCount = System.Byte.MaxValue;
            int chipSelectPinNumber = Gpio.IO18;
            int interruptPinNumber = Gpio.IO26;
            int resetPinNumber = Gpio.IO14;
            
            Configuration.SetPinFunction(Gpio.IO19, DeviceFunction.SPI1_MISO);
            Configuration.SetPinFunction(Gpio.IO27, DeviceFunction.SPI1_MOSI);
            Configuration.SetPinFunction(Gpio.IO05, DeviceFunction.SPI1_CLOCK); 
            
            //Initialize Modem - BEEEEEEEEEEEEEEEEEEEEEEP.......BUUUUUUUUUUUUUUUUUUUUUR....................WEEEEDOOOOWEEEEEDOOO.................SKRRRRRRRRRRRRRRRRRR
            Rfm9XDevice rfm9XDevice = new Rfm9XDevice(SpiBusId, chipSelectPinNumber, resetPinNumber, interruptPinNumber);
            oledScreen.DrawString(0, 20, "Success.......");
            oledScreen.RefreshDisplay();
            rfm9XDevice.Initialise(Frequency, paBoost: true);
            oledScreen.DrawString(0, 30, "Powering Radio On.......");
            oledScreen.RefreshDisplay();
            rfm9XDevice.OnReceive += Rfm9XDevice_OnReceive;
            rfm9XDevice.Receive();
            rfm9XDevice.OnTransmit += Rfm9XDevice_OnTransmit;
            
            //LED INIT - Not required, just gave me something to see in my peripheral so I did not have to read the OLED all the time
            GpioController gpioc = new GpioController();
            GpioPin led = gpioc.OpenPin(OnBoardDevicePortNumber.Led, PinMode.Output);
            led.Write(PinValue.High);

            Thread.Sleep(5000); //Too fast and we reset

            int count = 0;
            while (true) //Send a message and update the OLED
            {
                string messageText = $"Hello from {DeviceName} ! {MessageCount}";
                MessageCount -= 1;
                count++;
                oledScreen.Clear();
                oledScreen.DrawString(0, 0, "Transmitting....");
                oledScreen.DrawString(0,10, "Messages Sent: " + count.ToString());
                oledScreen.RefreshDisplay();
                byte[] messageBytes = UTF8Encoding.UTF8.GetBytes(messageText);
                Debug.WriteLine($"{DateTime.UtcNow:hh:mm:ss}-TX {messageBytes.Length} byte message {messageText}");
                rfm9XDevice.Send(messageBytes);
                Thread.Sleep(1000);
                led.Toggle();
            }
        }
         

        public static void Main()
        {
            Debug.WriteLine("[HellOled] : a advanced hello word with the embedded OLED screen.");
            //OLED INIT
            var heltec = new Lora.GXM.LoraTest.HeltecOled();
            heltec.Begin();
            heltec.Display.SetBrightness(180);
            heltec.Display.FlipScreenVertically();
            heltec.Display.CurrentColor = OledColor.White;
            heltec.Display.CurrentFont = FontArialMTPlain10.GetFont();
            heltec.Display.Clear();
            heltec.Display.DrawString(0, 0, "Booting........");
            heltec.Display.RefreshDisplay();
            Thread.Sleep(2000);

            //Radio INIT
            heltec.Display.DrawString(0, 10, "Radio Initializing!");
            heltec.Display.RefreshDisplay();
            initRadio(heltec.Display);
            heltec.Display.DrawString(0, 20, "Radio Initialized!");
            heltec.Display.RefreshDisplay();

            

            //led.Write(PinValue.Low);
            Thread.Sleep(5000);
            
        }

        private static void Rfm9XDevice_OnReceive(object sender, Rfm9XDevice.OnDataReceivedEventArgs e)
        {
            try
            {
                // Remove unprintable characters from messages
                for (int index = 0; index < e.Data.Length; index++)
                {
                    if ((e.Data[index] < 0x20) || (e.Data[index] > 0x7E))
                    {
                        e.Data[index] = 0x20;
                    }
                }

                string messageText = UTF8Encoding.UTF8.GetString(e.Data, 0, e.Data.Length);

                Debug.WriteLine($"{DateTime.UtcNow:hh:mm:ss}-RX PacketSnr {e.PacketSnr:F2} Packet RSSI {e.PacketRssi} dBm RSSI {e.Rssi} dBm = {e.Data.Length} byte message {messageText}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private static void Rfm9XDevice_OnTransmit(object sender, Rfm9XDevice.OnDataTransmitedEventArgs e)
        {
            Debug.WriteLine($"{DateTime.UtcNow:hh:mm:ss}-TX Done");
        }

    }
}