//---------------------------------------------------------------------------------
// Copyright (c) April/May 2020, devMobile Software
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//---------------------------------------------------------------------------------
namespace devMobile.IoT.Rfm9x.LoRaDeviceClient
{
	using System;
	using System.Diagnostics;
	using System.Text;
	using System.Threading;
	using nanoFramework.Hardware.Esp32;
	using devMobile.IoT.Rfm9x;

	class Program
	{
		private const double Frequency = 915000000.0;
		private const string DeviceName = "ESP32";
		private const string SpiBusId = "SPI1";
		
	static void Main()
		{
			 byte MessageCount = System.Byte.MaxValue;
	         int chipSelectPinNumber = Gpio.IO16;
		     int interruptPinNumber = Gpio.IO26;

			Configuration.SetPinFunction(Gpio.IO12, DeviceFunction.SPI1_MISO);
			Configuration.SetPinFunction(Gpio.IO13, DeviceFunction.SPI1_MOSI);
			Configuration.SetPinFunction(Gpio.IO14, DeviceFunction.SPI1_CLOCK);

			Rfm9XDevice rfm9XDevice = new Rfm9XDevice(SpiBusId, chipSelectPinNumber, interruptPinNumber);
			Debug.WriteLine("devMobile.IoT.Rfm9x.LoRaDeviceClient starting");

			rfm9XDevice.Initialise(Frequency, paBoost: true);

			rfm9XDevice.OnReceive += Rfm9XDevice_OnReceive;
			rfm9XDevice.Receive();
			rfm9XDevice.OnTransmit += Rfm9XDevice_OnTransmit;

			Thread.Sleep(10000);

			while (true)
			{
				string messageText = $"Hello from {DeviceName} ! {MessageCount}";
				MessageCount -= 1;

				byte[] messageBytes = UTF8Encoding.UTF8.GetBytes(messageText);
				Debug.WriteLine($"{DateTime.UtcNow:hh:mm:ss}-TX {messageBytes.Length} byte message {messageText}");
				rfm9XDevice.Send(messageBytes);
				Thread.Sleep(10000);
			}
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

