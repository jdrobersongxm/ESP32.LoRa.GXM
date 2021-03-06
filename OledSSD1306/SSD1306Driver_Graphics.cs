using System;

namespace Lora.GXM.OledDisplay1306
{
    public partial class SSD1306Driver
    {
        /// <summary>
        /// Set a pixel to the CurrentColor.
        /// </summary>
        /// <param name="x">X position</param>
        /// <param name="y">Y position</param>
        public void SetPixel(int x, int y)
        {
            if (x>=0 && x<_displayWidth && y>=0 && y< _displayHeight)
            {
                switch (_currentColor)
                {
                    case OledColor.White:
                         displayBuffer[x + (y / 8) * _displayWidth] |= (byte)(1 << (y & 7));
                        break;
                    case OledColor.Black:
                        displayBuffer[x + (y / 8) * _displayWidth] &= (byte)~(1 << (y & 7));
                        break;
                    case OledColor.Inverse:
                        displayBuffer[x + (y / 8) * _displayWidth] ^= (byte)(1 << (y & 7));
                        break;
                }
            }
        }


        /// <summary>
        /// Local implementation of abs()
        /// (avoinding embedding heavy lib just for this function).
        /// </summary>
        /// <param name="v">int number to abs()</param>
        /// <returns></returns>
        private int abs(int v)
        {
            // localimplementation of Abs() to avoid including a full Math package
            return (v < 0) ? -v : v;
        }

        /// <summary>
        /// Swap value of 2 variables
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a">first variable</param>
        /// <param name="b">second variable</param>
        private void swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }


        /// <summary>
        /// Draw a line from (x0,y0) to (x1,y1) using the current color 
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        public void DrawLine(int x0, int y0, int x1, int y1)
        {
            var steep = abs(y1 - y0) > abs(x1 - x0);
            if (steep)
            {
                swap(ref x0, ref y0);
                swap(ref x1, ref y1);
            }

            if (x0 > x1)
            {
                swap(ref x0, ref x1);
                swap(ref y0, ref y1);
            }

            var dx = (x1 - x0);
            var dy = abs(y1 - y0);

            var err = (dx / 2);
            int ystep;

            if (y0 < y1)
            {
                ystep = 1;
            }
            else
            {
                ystep = -1;
            }

            for (; x0 <= x1; x0++)
            {
                if (steep)
                {
                    SetPixel(y0,x0);
                }
                else
                {
                    SetPixel(x0, y0);
                }
                err -= dy;
                if (err < 0)
                {
                    y0 +=  ystep;
                    err += dx;
                }
            }
        }


        /// <summary>
        /// Draw a transparent rectangle box, using currentcolor for border.
        /// </summary>
        /// <param name="x">Top Left X coordinate</param>
        /// <param name="y">Top Left Y coordinate</param>
        /// <param name="width">Width of rectangle (including bounding box)</param>
        /// <param name="height">Height of rectangle (including bounding box)</param>
        public void DrawRect(int x, int y, int width, int height)
        {
            DrawHorizontalLine(x, y, width);
            DrawVerticalLine(x, y, height);
            DrawVerticalLine(x + width - 1, y, height);
            DrawHorizontalLine(x, y + height - 1, width);
        }

        /// <summary>
        /// Draw a filled rectangle box using the currentcolor for border and filler.
        /// </summary>
        /// <param name="x">Top Left X coordinate</param>
        /// <param name="y">Top Left Y coordinate</param>
        /// <param name="width">Width of rectangle </param>
        /// <param name="height">Height of rectangle</param>
        public void FillRect(int x, int y, int width, int height)
        {
            for (int xm = x; xm < x + width; xm++)
            {
                DrawVerticalLine(xm, y, height);
            }
        }

        /// <summary>
        /// Draw an empty circle 
        /// </summary>
        /// <param name="x0">X center</param>
        /// <param name="y0">Y center</param>
        /// <param name="radius">radius un pixel</param>
        public void DrawCircle(int x0, int y0, int radius)
        {
            int x = 0, y = radius;
            int dp = 1 - radius;
            do
            {
                if (dp < 0)
                    dp = dp + 2 * (++x) + 3;
                else
                    dp = dp + 2 * (++x) - 2 * (--y) + 5;

                SetPixel(x0 + x, y0 + y);
                SetPixel(x0 - x, y0 + y);
                SetPixel(x0 + x, y0 - y);
                SetPixel(x0 - x, y0 - y);
                SetPixel(x0 + y, y0 + x);
                SetPixel(x0 - y, y0 + x);
                SetPixel(x0 + y, y0 - x);
                SetPixel(x0 - y, y0 - x);
            } while (x < y);
            SetPixel(x0 + radius, y0);
            SetPixel(x0, y0 + radius);
            SetPixel(x0 - radius, y0);
            SetPixel(x0, y0 - radius);
        }

        /// <summary>
        /// Draw part of circle (1/4 of circle)
        /// quad bitmap mask
        ///    0b00000001 : 0   -> 90°  quad
        ///    0b00000010 : 270 -> 360° quad
        ///    0b00000100 : 180 -> 270° quad
        ///    0b00001000 : 90  -> 180° quad
        /// </summary>
        /// <param name="x0">X center</param>
        /// <param name="y0"></param>
        /// <param name="radius">radius in pixel</param>
        /// <param name="quads">bit mask defining part of circle to draw</param>
        public void DrawCircleQuads(int x0, int y0, int radius, byte quads)
        {
            int x = 0, y = radius;
            int dp = 1 - radius;
            while (x < y)
            {
                if (dp < 0)
                    dp = dp + 2 * (++x) + 3;
                else
                    dp = dp + 2 * (++x) - 2 * (--y) + 5;
                if ((quads & 0x1) !=0)
                {
                    SetPixel(x0 + x, y0 - y);
                    SetPixel(x0 + y, y0 - x);
                }
                if ((quads & 0x2)!=0)
                {
                    SetPixel(x0 - y, y0 - x);
                    SetPixel(x0 - x, y0 - y);
                }
                if ((quads & 0x4)!=0)
                {
                    SetPixel(x0 - y, y0 + x);
                    SetPixel(x0 - x, y0 + y);
                }
                if ((quads & 0x8) !=0)
                {
                    SetPixel(x0 + x, y0 + y);
                    SetPixel(x0 + y, y0 + x);
                }
            }
            if ((quads & 0x1)!=0 && (quads & 0x8)!=0)
                SetPixel(x0 + radius, y0);
            if ((quads & 0x4)!=0 && (quads & 0x8)!=0)
                SetPixel(x0, y0 + radius);
            if ((quads & 0x2)!=0 && (quads & 0x4)!=0)
                SetPixel(x0 - radius, y0);
            if ((quads & 0x1)!=0 && (quads & 0x2)!=0)
                SetPixel(x0, y0 - radius);
        }

        /// <summary>
        /// Draw an filled circle 
        /// </summary>
        /// <param name="x0">X center</param>
        /// <param name="y0">Y center</param>
        /// <param name="radius">radius un pixel</param>
        public void FillCircle(int x0, int y0, int radius)
        {
            int x = 0, y = radius;
            int dp = 1 - radius;
            do
            {
                if (dp < 0)
                    dp = dp + 2 * (++x) + 3;
                else
                    dp = dp + 2 * (++x) - 2 * (--y) + 5;

                DrawHorizontalLine(x0 - x, y0 - y, 2 * x);
                DrawHorizontalLine(x0 - x, y0 + y, 2 * x);
                DrawHorizontalLine(x0 - y, y0 - x, 2 * y);
                DrawHorizontalLine(x0 - y, y0 + x, 2 * y);
            } while (x < y);
            DrawHorizontalLine(x0 - radius, y0, 2 * radius);
        }

        /// <summary>
        /// Draw an hoizontal line 
        /// </summary>
        /// <param name="x">X origine</param>
        /// <param name="y">Y origine</param>
        /// <param name="length">size of line (in pixel)</param>
        public void DrawHorizontalLine(int x, int y, int length)
        {
            if (y < 0 || y >= _displayHeight) 
                return; 

            if (x < 0)
            {
                length += x;
                x = 0;
            }

            if ((x + length) > _displayWidth)
                length = (_displayWidth - x);

            if (length <= 0) { return; }

            int bufferNdx = (y >> 3) * _displayWidth;
            bufferNdx += x;

            byte drawBit = (byte)(1 << (y & 7));

            switch (CurrentColor)
            {
                case OledColor.White:
                    while (length-- != 0)
                        displayBuffer[bufferNdx++] |= drawBit;
                    break;
                case OledColor.Black:
                    drawBit = (byte)(~drawBit); 
                    while (length--!=0)
                        displayBuffer[bufferNdx++] &= drawBit;
                    break;
                case OledColor.Inverse:
                    while (length-- != 0)
                        displayBuffer[bufferNdx++] ^= drawBit;
                    break;
            }
        }

        /// <summary>
        /// Draw a vertical line using an optimized algorithme
        /// </summary>
        /// <param name="x">X origin</param>
        /// <param name="y">Y origin</param>
        /// <param name="length">Length in pixel</param>
        public void DrawVerticalLine(int x, int y, int length)
        {
            if (x < 0 || x >= _displayWidth || length==0) return;

            if (y < 0)
            {
                length += y;
                y = 0;
            }

            if ((y + length) > _displayHeight)
                length = (_displayHeight - y);

            if (length <= 0) 
                return;


            int yOffset = (byte)(y & 7);
            byte drawBit;
            int bufferNdx = 0;

            bufferNdx += (y >> 3) * _displayWidth;
            bufferNdx += x;

            if (yOffset!=0)
            {
                yOffset = 8 - yOffset;
                drawBit = (byte)~(0xFF >> (yOffset));

                if (length < yOffset)
                {
                    drawBit &= (byte) (0xFF >> (yOffset - length));
                }

                switch (CurrentColor)
                {
                    case OledColor.White:
                        displayBuffer[bufferNdx] |= drawBit;
                        break;
                    case OledColor.Black:
                        displayBuffer[bufferNdx] &= (byte)~drawBit;
                        break;
                    case OledColor.Inverse:
                        displayBuffer[bufferNdx] ^= drawBit;
                        break;
                }

                if (length < yOffset) 
                    return;

                length -= yOffset;
                bufferNdx += _displayWidth;
            }

            if (length >= 8)
            {
                switch (CurrentColor)
                {
                    case OledColor.White:
                    case OledColor.Black:
                        drawBit =(byte) ((CurrentColor==OledColor.White) ? 0xFF : 0x00);
                        do
                        {
                            displayBuffer[bufferNdx] = drawBit;
                            bufferNdx += _displayWidth;
                            length -= 8;
                        } while (length >= 8);
                        break;
                    case OledColor.Inverse:
                        do
                        {
                            displayBuffer[bufferNdx] = (byte)~displayBuffer[bufferNdx];
                            bufferNdx += _displayWidth;
                            length -= 8;
                        } while (length >= 8);
                        break;
                }
            }

            if (length > 0)
            {
                drawBit =(byte)( (1 << (length & 7)) - 1);
                switch (CurrentColor)
                {
                    case OledColor.White:
                        displayBuffer[bufferNdx] |= drawBit;
                        break;
                    case OledColor.Black:
                        displayBuffer[bufferNdx] &= (byte)~drawBit;
                        break;
                    case OledColor.Inverse:
                        displayBuffer[bufferNdx] ^= drawBit;
                        break;
                }
            }

        }

        /// <summary>
        /// Draw a rounded corned progress base. 
        /// </summary>
        /// <param name="x">X of top left corner</param>
        /// <param name="y">Y of top left </param>
        /// <param name="width">width in pixel</param>
        /// <param name="height">width in pixel </param>
        /// <param name="progress">progression (0->100)</param>
        public void DrawProgressBar(int x, int y, int width, int height, int progress)
        {
            int radius = height / 2;
            int xRadius = x + radius;
            int yRadius = y + radius;
            int doubleRadius = 2 * radius;
            int innerRadius = radius - 2;

            CurrentColor=OledColor.White;
            DrawCircleQuads(xRadius, yRadius, radius, 0b00000110);
            DrawHorizontalLine(xRadius, y, width - doubleRadius + 1);
            DrawHorizontalLine(xRadius, y + height, width - doubleRadius + 1);
            DrawCircleQuads(x + width - radius, yRadius, radius, 0b00001001);

            int maxProgressWidth = (width - doubleRadius + 1) * progress / 100;

            FillCircle(xRadius, yRadius, innerRadius);
            FillRect(xRadius + 1, y + 2, maxProgressWidth, height - 3);
            FillCircle(xRadius + maxProgressWidth, yRadius, innerRadius);
        }

        /// <summary>
        /// NOT TESTED
        /// </summary>
        /// <param name="xMove"></param>
        /// <param name="yMove"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        private void DrawImageInternal(int xMove, int yMove, int width, int height, byte[] data, int offset)
        {
            var bytesInData = data.Length;

            if (width < 0 || height < 0) return;
            if (yMove + height < 0 || yMove > _displayHeight) return;
            if (xMove + width < 0 || xMove > _displayWidth) return;

            int rasterHeight = 1 + ((height - 1) >> 3); // fast ceil(height / 8.0)
            int yOffset = yMove & 7;

            bytesInData = bytesInData == 0 ? width * rasterHeight : bytesInData;

            int initYMove = yMove;
            int initYOffset = yOffset;

            for (int i = 0; i < bytesInData; i++)
            {
                // Reset if next horizontal drawing phase is started.
                if (i % rasterHeight == 0)
                {
                    yMove = initYMove;
                    yOffset = initYOffset;
                }

                byte currentByte = data[offset+i] ;//pgm_read_byte(data + offset + i);

                int xPos = xMove + (i / rasterHeight);
                int yPos = ((yMove >> 3) + (i % rasterHeight)) * _displayWidth;

                //    int16_t yScreenPos = yMove + yOffset;
                int dataPos = xPos + yPos;

                if (dataPos >= 0 && dataPos < _displayBufferSize &&
                    xPos >= 0 && xPos < _displayWidth)
                {

                    if (yOffset >= 0)
                    {
                        switch (CurrentColor)
                        {
                            case OledColor.White: displayBuffer[dataPos] |= (byte)(currentByte << yOffset); break;
                            case OledColor.Black: displayBuffer[dataPos] &= (byte)(~(currentByte << yOffset)); break;
                            case OledColor.Inverse: displayBuffer[dataPos] ^= (byte)(currentByte << yOffset); break;
                        }

                        if (dataPos < (_displayBufferSize - _displayWidth))
                        {
                            switch (CurrentColor)
                            {
                                case OledColor.White: displayBuffer[dataPos + _displayWidth] |= (byte)(currentByte >> (8 - yOffset)); break;
                                case OledColor.Black: displayBuffer[dataPos + _displayWidth] &= (byte)(~(currentByte >> (8 - yOffset))); break;
                                case OledColor.Inverse: displayBuffer[dataPos + _displayWidth] ^= (byte)(currentByte >> (8 - yOffset)); break;
                            }
                        }
                    }
                    else
                    {
                        // Make new offset position
                        yOffset = -yOffset;

                        switch (CurrentColor)
                        {
                            case OledColor.White: displayBuffer[dataPos] |= (byte)(currentByte >> yOffset); break;
                            case OledColor.Black: displayBuffer[dataPos] &= (byte)(~(currentByte >> yOffset)); break;
                            case OledColor.Inverse: displayBuffer[dataPos] ^= (byte)(currentByte >> yOffset); break;
                        }

                        // Prepare for next iteration by moving one block up
                        yMove -= 8;

                        // and setting the new yOffset
                        yOffset = 8 - yOffset;
                    }

                    //yield();
                }
            }

        }

        /// <summary>
        /// NOT TESTED
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="image"></param>
        public void DrawFastImage(int x0, int y0, int width, int height, byte[] image )
        {
            // TODO : TO TEST !!!
            if (image == null)
                throw new ArgumentException("cannot be null", nameof(image));
            DrawImageInternal(x0, y0, width, height, image, 0);
        }


        /// <summary>
        /// Draw a an XBM image on a specified position on screen.
        /// (nanoframework exclusive).
        /// </summary>
        /// <param name="x">Top left X of image</param>
        /// <param name="y">Top left Y of image</param>
        /// <param name="image">instance of XbmImage</param>
        public void DrawXbm(int x, int y, XbmImage image)
        {
            DrawXbm(x, y, image.Width, image.Height, image.Datas);
        }

        /// <summary>
        /// Draw a image in XBM format on a specified position on screen.
        /// (legacy signature).
        /// </summary>
        /// <param name="xMove">Top left X of image</param>
        /// <param name="yMove">Top left Y of image</param>
        /// <param name="width">width of the the bitmap</param>
        /// <param name="height">height of the bitmaps</param>
        /// <param name="xbm">xbm image</param>
        public void DrawXbm(int xMove, int yMove, int width, int height, byte[] xbm)
        {
            int widthInXbm = (width + 7) / 8;
            int data = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if ((x & 7)!=0)
                        data >>= 1; 
                    else
                    {  
                        data = xbm[(x / 8) + y * widthInXbm];
                    }
                    
                    if ((data & 0x01)!=0)
                    {
                        SetPixel(xMove + x, yMove + y);
                    }
                }
            }
        }


    }
}
