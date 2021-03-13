﻿using Lora.GXM.OledDisplay1306;
using System;

namespace Lora.GXM.OledFonts
{
    public class FontArialMTPlain16
    {
        static private Font arialMTPlain16 = null;

        public static Font GetFont()
        {
            if (arialMTPlain16 != null)
                return arialMTPlain16;

            arialMTPlain16 = new Font(new byte[] {
                    0x10, // Width: 16
                    0x13, // Height: 19
                    0x20, // First Char: 32
                    0xE0, // Numbers of Chars: 224

                    // Jump Table:
                    0xFF, 0xFF, 0x00, 0x04,  // 32:65535
                    0x00, 0x00, 0x08, 0x04,  // 33:0
                    0x00, 0x08, 0x0D, 0x06,  // 34:8
                    0x00, 0x15, 0x1A, 0x09,  // 35:21
                    0x00, 0x2F, 0x17, 0x09,  // 36:47
                    0x00, 0x46, 0x26, 0x0E,  // 37:70
                    0x00, 0x6C, 0x1D, 0x0B,  // 38:108
                    0x00, 0x89, 0x04, 0x03,  // 39:137
                    0x00, 0x8D, 0x0C, 0x05,  // 40:141
                    0x00, 0x99, 0x0B, 0x05,  // 41:153
                    0x00, 0xA4, 0x0D, 0x06,  // 42:164
                    0x00, 0xB1, 0x17, 0x09,  // 43:177
                    0x00, 0xC8, 0x09, 0x04,  // 44:200
                    0x00, 0xD1, 0x0B, 0x05,  // 45:209
                    0x00, 0xDC, 0x08, 0x04,  // 46:220
                    0x00, 0xE4, 0x0A, 0x04,  // 47:228
                    0x00, 0xEE, 0x17, 0x09,  // 48:238
                    0x01, 0x05, 0x11, 0x09,  // 49:261
                    0x01, 0x16, 0x17, 0x09,  // 50:278
                    0x01, 0x2D, 0x17, 0x09,  // 51:301
                    0x01, 0x44, 0x17, 0x09,  // 52:324
                    0x01, 0x5B, 0x17, 0x09,  // 53:347
                    0x01, 0x72, 0x17, 0x09,  // 54:370
                    0x01, 0x89, 0x16, 0x09,  // 55:393
                    0x01, 0x9F, 0x17, 0x09,  // 56:415
                    0x01, 0xB6, 0x17, 0x09,  // 57:438
                    0x01, 0xCD, 0x05, 0x04,  // 58:461
                    0x01, 0xD2, 0x06, 0x04,  // 59:466
                    0x01, 0xD8, 0x17, 0x09,  // 60:472
                    0x01, 0xEF, 0x17, 0x09,  // 61:495
                    0x02, 0x06, 0x17, 0x09,  // 62:518
                    0x02, 0x1D, 0x16, 0x09,  // 63:541
                    0x02, 0x33, 0x2F, 0x10,  // 64:563
                    0x02, 0x62, 0x1D, 0x0B,  // 65:610
                    0x02, 0x7F, 0x1D, 0x0B,  // 66:639
                    0x02, 0x9C, 0x20, 0x0C,  // 67:668
                    0x02, 0xBC, 0x20, 0x0C,  // 68:700
                    0x02, 0xDC, 0x1D, 0x0B,  // 69:732
                    0x02, 0xF9, 0x19, 0x0A,  // 70:761
                    0x03, 0x12, 0x20, 0x0C,  // 71:786
                    0x03, 0x32, 0x1D, 0x0C,  // 72:818
                    0x03, 0x4F, 0x05, 0x04,  // 73:847
                    0x03, 0x54, 0x14, 0x08,  // 74:852
                    0x03, 0x68, 0x1D, 0x0B,  // 75:872
                    0x03, 0x85, 0x17, 0x09,  // 76:901
                    0x03, 0x9C, 0x23, 0x0D,  // 77:924
                    0x03, 0xBF, 0x1D, 0x0C,  // 78:959
                    0x03, 0xDC, 0x20, 0x0C,  // 79:988
                    0x03, 0xFC, 0x1C, 0x0B,  // 80:1020
                    0x04, 0x18, 0x20, 0x0C,  // 81:1048
                    0x04, 0x38, 0x1D, 0x0C,  // 82:1080
                    0x04, 0x55, 0x1D, 0x0B,  // 83:1109
                    0x04, 0x72, 0x19, 0x0A,  // 84:1138
                    0x04, 0x8B, 0x1D, 0x0C,  // 85:1163
                    0x04, 0xA8, 0x1C, 0x0B,  // 86:1192
                    0x04, 0xC4, 0x2B, 0x0F,  // 87:1220
                    0x04, 0xEF, 0x20, 0x0B,  // 88:1263
                    0x05, 0x0F, 0x19, 0x0B,  // 89:1295
                    0x05, 0x28, 0x1A, 0x0A,  // 90:1320
                    0x05, 0x42, 0x0C, 0x04,  // 91:1346
                    0x05, 0x4E, 0x0B, 0x04,  // 92:1358
                    0x05, 0x59, 0x09, 0x04,  // 93:1369
                    0x05, 0x62, 0x14, 0x08,  // 94:1378
                    0x05, 0x76, 0x1B, 0x09,  // 95:1398
                    0x05, 0x91, 0x07, 0x05,  // 96:1425
                    0x05, 0x98, 0x17, 0x09,  // 97:1432
                    0x05, 0xAF, 0x17, 0x09,  // 98:1455
                    0x05, 0xC6, 0x14, 0x08,  // 99:1478
                    0x05, 0xDA, 0x17, 0x09,  // 100:1498
                    0x05, 0xF1, 0x17, 0x09,  // 101:1521
                    0x06, 0x08, 0x0A, 0x04,  // 102:1544
                    0x06, 0x12, 0x17, 0x09,  // 103:1554
                    0x06, 0x29, 0x14, 0x09,  // 104:1577
                    0x06, 0x3D, 0x05, 0x04,  // 105:1597
                    0x06, 0x42, 0x06, 0x04,  // 106:1602
                    0x06, 0x48, 0x17, 0x08,  // 107:1608
                    0x06, 0x5F, 0x05, 0x04,  // 108:1631
                    0x06, 0x64, 0x23, 0x0D,  // 109:1636
                    0x06, 0x87, 0x14, 0x09,  // 110:1671
                    0x06, 0x9B, 0x17, 0x09,  // 111:1691
                    0x06, 0xB2, 0x17, 0x09,  // 112:1714
                    0x06, 0xC9, 0x18, 0x09,  // 113:1737
                    0x06, 0xE1, 0x0D, 0x05,  // 114:1761
                    0x06, 0xEE, 0x14, 0x08,  // 115:1774
                    0x07, 0x02, 0x0B, 0x04,  // 116:1794
                    0x07, 0x0D, 0x14, 0x09,  // 117:1805
                    0x07, 0x21, 0x13, 0x08,  // 118:1825
                    0x07, 0x34, 0x1F, 0x0C,  // 119:1844
                    0x07, 0x53, 0x14, 0x08,  // 120:1875
                    0x07, 0x67, 0x13, 0x08,  // 121:1895
                    0x07, 0x7A, 0x14, 0x08,  // 122:1914
                    0x07, 0x8E, 0x0F, 0x05,  // 123:1934
                    0x07, 0x9D, 0x06, 0x04,  // 124:1949
                    0x07, 0xA3, 0x0E, 0x05,  // 125:1955
                    0x07, 0xB1, 0x17, 0x09,  // 126:1969
                    0xFF, 0xFF, 0x00, 0x00,  // 127:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 128:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 129:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 130:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 131:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 132:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 133:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 134:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 135:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 136:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 137:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 138:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 139:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 140:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 141:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 142:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 143:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 144:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 145:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 146:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 147:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 148:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 149:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 150:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 151:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 152:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 153:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 154:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 155:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 156:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 157:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 158:65535
                    0xFF, 0xFF, 0x00, 0x10,  // 159:65535
                    0xFF, 0xFF, 0x00, 0x04,  // 160:65535
                    0x07, 0xC8, 0x09, 0x05,  // 161:1992
                    0x07, 0xD1, 0x17, 0x09,  // 162:2001
                    0x07, 0xE8, 0x17, 0x09,  // 163:2024
                    0x07, 0xFF, 0x14, 0x09,  // 164:2047
                    0x08, 0x13, 0x1A, 0x09,  // 165:2067
                    0x08, 0x2D, 0x06, 0x04,  // 166:2093
                    0x08, 0x33, 0x17, 0x09,  // 167:2099
                    0x08, 0x4A, 0x07, 0x05,  // 168:2122
                    0x08, 0x51, 0x23, 0x0C,  // 169:2129
                    0x08, 0x74, 0x0E, 0x06,  // 170:2164
                    0x08, 0x82, 0x14, 0x09,  // 171:2178
                    0x08, 0x96, 0x17, 0x09,  // 172:2198
                    0x08, 0xAD, 0x0B, 0x05,  // 173:2221
                    0x08, 0xB8, 0x23, 0x0C,  // 174:2232
                    0x08, 0xDB, 0x19, 0x09,  // 175:2267
                    0x08, 0xF4, 0x0D, 0x06,  // 176:2292
                    0x09, 0x01, 0x17, 0x09,  // 177:2305
                    0x09, 0x18, 0x0E, 0x05,  // 178:2328
                    0x09, 0x26, 0x0D, 0x05,  // 179:2342
                    0x09, 0x33, 0x0A, 0x05,  // 180:2355
                    0x09, 0x3D, 0x17, 0x09,  // 181:2365
                    0x09, 0x54, 0x19, 0x09,  // 182:2388
                    0x09, 0x6D, 0x08, 0x05,  // 183:2413
                    0x09, 0x75, 0x0C, 0x05,  // 184:2421
                    0x09, 0x81, 0x0B, 0x05,  // 185:2433
                    0x09, 0x8C, 0x0D, 0x06,  // 186:2444
                    0x09, 0x99, 0x17, 0x09,  // 187:2457
                    0x09, 0xB0, 0x26, 0x0D,  // 188:2480
                    0x09, 0xD6, 0x26, 0x0D,  // 189:2518
                    0x09, 0xFC, 0x26, 0x0D,  // 190:2556
                    0x0A, 0x22, 0x1A, 0x0A,  // 191:2594
                    0x0A, 0x3C, 0x1D, 0x0B,  // 192:2620
                    0x0A, 0x59, 0x1D, 0x0B,  // 193:2649
                    0x0A, 0x76, 0x1D, 0x0B,  // 194:2678
                    0x0A, 0x93, 0x1D, 0x0B,  // 195:2707
                    0x0A, 0xB0, 0x1D, 0x0B,  // 196:2736
                    0x0A, 0xCD, 0x1D, 0x0B,  // 197:2765
                    0x0A, 0xEA, 0x2C, 0x10,  // 198:2794
                    0x0B, 0x16, 0x20, 0x0C,  // 199:2838
                    0x0B, 0x36, 0x1D, 0x0B,  // 200:2870
                    0x0B, 0x53, 0x1D, 0x0B,  // 201:2899
                    0x0B, 0x70, 0x1D, 0x0B,  // 202:2928
                    0x0B, 0x8D, 0x1D, 0x0B,  // 203:2957
                    0x0B, 0xAA, 0x05, 0x04,  // 204:2986
                    0x0B, 0xAF, 0x07, 0x04,  // 205:2991
                    0x0B, 0xB6, 0x0A, 0x04,  // 206:2998
                    0x0B, 0xC0, 0x07, 0x04,  // 207:3008
                    0x0B, 0xC7, 0x20, 0x0C,  // 208:3015
                    0x0B, 0xE7, 0x1D, 0x0C,  // 209:3047
                    0x0C, 0x04, 0x20, 0x0C,  // 210:3076
                    0x0C, 0x24, 0x20, 0x0C,  // 211:3108
                    0x0C, 0x44, 0x20, 0x0C,  // 212:3140
                    0x0C, 0x64, 0x20, 0x0C,  // 213:3172
                    0x0C, 0x84, 0x20, 0x0C,  // 214:3204
                    0x0C, 0xA4, 0x17, 0x09,  // 215:3236
                    0x0C, 0xBB, 0x20, 0x0C,  // 216:3259
                    0x0C, 0xDB, 0x1D, 0x0C,  // 217:3291
                    0x0C, 0xF8, 0x1D, 0x0C,  // 218:3320
                    0x0D, 0x15, 0x1D, 0x0C,  // 219:3349
                    0x0D, 0x32, 0x1D, 0x0C,  // 220:3378
                    0x0D, 0x4F, 0x19, 0x0B,  // 221:3407
                    0x0D, 0x68, 0x1D, 0x0B,  // 222:3432
                    0x0D, 0x85, 0x17, 0x0A,  // 223:3461
                    0x0D, 0x9C, 0x17, 0x09,  // 224:3484
                    0x0D, 0xB3, 0x17, 0x09,  // 225:3507
                    0x0D, 0xCA, 0x17, 0x09,  // 226:3530
                    0x0D, 0xE1, 0x17, 0x09,  // 227:3553
                    0x0D, 0xF8, 0x17, 0x09,  // 228:3576
                    0x0E, 0x0F, 0x17, 0x09,  // 229:3599
                    0x0E, 0x26, 0x29, 0x0E,  // 230:3622
                    0x0E, 0x4F, 0x14, 0x08,  // 231:3663
                    0x0E, 0x63, 0x17, 0x09,  // 232:3683
                    0x0E, 0x7A, 0x17, 0x09,  // 233:3706
                    0x0E, 0x91, 0x17, 0x09,  // 234:3729
                    0x0E, 0xA8, 0x17, 0x09,  // 235:3752
                    0x0E, 0xBF, 0x05, 0x04,  // 236:3775
                    0x0E, 0xC4, 0x07, 0x04,  // 237:3780
                    0x0E, 0xCB, 0x0A, 0x04,  // 238:3787
                    0x0E, 0xD5, 0x07, 0x04,  // 239:3797
                    0x0E, 0xDC, 0x17, 0x09,  // 240:3804
                    0x0E, 0xF3, 0x14, 0x09,  // 241:3827
                    0x0F, 0x07, 0x17, 0x09,  // 242:3847
                    0x0F, 0x1E, 0x17, 0x09,  // 243:3870
                    0x0F, 0x35, 0x17, 0x09,  // 244:3893
                    0x0F, 0x4C, 0x17, 0x09,  // 245:3916
                    0x0F, 0x63, 0x17, 0x09,  // 246:3939
                    0x0F, 0x7A, 0x17, 0x09,  // 247:3962
                    0x0F, 0x91, 0x17, 0x0A,  // 248:3985
                    0x0F, 0xA8, 0x14, 0x09,  // 249:4008
                    0x0F, 0xBC, 0x14, 0x09,  // 250:4028
                    0x0F, 0xD0, 0x14, 0x09,  // 251:4048
                    0x0F, 0xE4, 0x14, 0x09,  // 252:4068
                    0x0F, 0xF8, 0x13, 0x08,  // 253:4088
                    0x10, 0x0B, 0x17, 0x09,  // 254:4107
                    0x10, 0x22, 0x13, 0x08,  // 255:4130

                    // Font Data:
                    0x00,0x00,0x00,0x00,0x00,0x00,0xF8,0x5F,  // 33
                    0x00,0x00,0x00,0x78,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x78, // 34
                    0x80,0x08,0x00,0x80,0x78,0x00,0xC0,0x0F,0x00,0xB8,0x08,0x00,0x80,0x08,0x00,0x80,0x78,0x00,0xC0,0x0F,0x00,0xB8,0x08,0x00,0x80,0x08,  // 35
                    0x00,0x00,0x00,0xE0,0x10,0x00,0x10,0x21,0x00,0x08,0x41,0x00,0xFC,0xFF,0x00,0x08,0x42,0x00,0x10,0x22,0x00,0x20,0x1C, // 36
                    0x00,0x00,0x00,0xF0,0x00,0x00,0x08,0x01,0x00,0x08,0x01,0x00,0x08,0x61,0x00,0xF0,0x18,0x00,0x00,0x06,0x00,0xC0,0x01,0x00,0x30,0x3C,0x00,0x08,0x42,0x00,0x00,0x42,0x00,0x00,0x42,0x00,0x00,0x3C,  // 37
                    0x00,0x00,0x00,0x00,0x1C,0x00,0x70,0x22,0x00,0x88,0x41,0x00,0x08,0x43,0x00,0x88,0x44,0x00,0x70,0x28,0x00,0x00,0x10,0x00,0x00,0x28,0x00,0x00,0x44, // 38
                    0x00,0x00,0x00,0x78,  // 39
                    0x00,0x00,0x00,0x80,0x3F,0x00,0x70,0xC0,0x01,0x08,0x00,0x02,  // 40
                    0x00,0x00,0x00,0x08,0x00,0x02,0x70,0xC0,0x01,0x80,0x3F, // 41
                    0x10,0x00,0x00,0xD0,0x00,0x00,0x38,0x00,0x00,0xD0,0x00,0x00,0x10, // 42
                    0x00,0x00,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0xC0,0x1F,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02, // 43
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xC0,0x01, // 44
                    0x00,0x08,0x00,0x00,0x08,0x00,0x00,0x08,0x00,0x00,0x08, // 45
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x40,  // 46
                    0x00,0x60,0x00,0x00,0x1E,0x00,0xE0,0x01,0x00,0x18,  // 47
                    0x00,0x00,0x00,0xE0,0x1F,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x10,0x20,0x00,0xE0,0x1F, // 48
                    0x00,0x00,0x00,0x00,0x00,0x00,0x40,0x00,0x00,0x20,0x00,0x00,0x10,0x00,0x00,0xF8,0x7F, // 49
                    0x00,0x00,0x00,0x20,0x40,0x00,0x10,0x60,0x00,0x08,0x50,0x00,0x08,0x48,0x00,0x08,0x44,0x00,0x10,0x43,0x00,0xE0,0x40, // 50
                    0x00,0x00,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x88,0x41,0x00,0xF0,0x22,0x00,0x00,0x1C, // 51
                    0x00,0x0C,0x00,0x00,0x0A,0x00,0x00,0x09,0x00,0xC0,0x08,0x00,0x20,0x08,0x00,0x10,0x08,0x00,0xF8,0x7F,0x00,0x00,0x08, // 52
                    0x00,0x00,0x00,0xC0,0x11,0x00,0xB8,0x20,0x00,0x88,0x40,0x00,0x88,0x40,0x00,0x88,0x40,0x00,0x08,0x21,0x00,0x08,0x1E, // 53
                    0x00,0x00,0x00,0xE0,0x1F,0x00,0x10,0x21,0x00,0x88,0x40,0x00,0x88,0x40,0x00,0x88,0x40,0x00,0x10,0x21,0x00,0x20,0x1E, // 54
                    0x00,0x00,0x00,0x08,0x00,0x00,0x08,0x00,0x00,0x08,0x78,0x00,0x08,0x07,0x00,0xC8,0x00,0x00,0x28,0x00,0x00,0x18,  // 55
                    0x00,0x00,0x00,0x60,0x1C,0x00,0x90,0x22,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x90,0x22,0x00,0x60,0x1C, // 56
                    0x00,0x00,0x00,0xE0,0x11,0x00,0x10,0x22,0x00,0x08,0x44,0x00,0x08,0x44,0x00,0x08,0x44,0x00,0x10,0x22,0x00,0xE0,0x1F, // 57
                    0x00,0x00,0x00,0x40,0x40, // 58
                    0x00,0x00,0x00,0x40,0xC0,0x01,  // 59
                    0x00,0x00,0x00,0x00,0x02,0x00,0x00,0x05,0x00,0x00,0x05,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x40,0x10, // 60
                    0x00,0x00,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x80,0x08, // 61
                    0x00,0x00,0x00,0x40,0x10,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x80,0x08,0x00,0x00,0x05,0x00,0x00,0x05,0x00,0x00,0x02, // 62
                    0x00,0x00,0x00,0x60,0x00,0x00,0x10,0x00,0x00,0x08,0x00,0x00,0x08,0x5C,0x00,0x08,0x02,0x00,0x10,0x01,0x00,0xE0,  // 63
                    0x00,0x00,0x00,0x00,0x3F,0x00,0xC0,0x40,0x00,0x20,0x80,0x00,0x10,0x1E,0x01,0x10,0x21,0x01,0x88,0x40,0x02,0x48,0x40,0x02,0x48,0x40,0x02,0x48,0x20,0x02,0x88,0x7C,0x02,0xC8,0x43,0x02,0x10,0x40,0x02,0x10,0x20,0x01,0x60,0x10,0x01,0x80,0x8F, // 64
                    0x00,0x00,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x80,0x07,0x00,0x70,0x04,0x00,0x08,0x04,0x00,0x70,0x04,0x00,0x80,0x07,0x00,0x00,0x1C,0x00,0x00,0x60, // 65
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x90,0x22,0x00,0x60,0x1C, // 66
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x10,0x20,0x00,0x20,0x10,  // 67
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F,  // 68
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x40, // 69
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08, // 70
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x42,0x00,0x08,0x42,0x00,0x10,0x22,0x00,0x20,0x12,0x00,0x00,0x0E,  // 71
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x00,0x01,0x00,0x00,0x01,0x00,0x00,0x01,0x00,0x00,0x01,0x00,0x00,0x01,0x00,0x00,0x01,0x00,0x00,0x01,0x00,0xF8,0x7F, // 72
                    0x00,0x00,0x00,0xF8,0x7F, // 73
                    0x00,0x00,0x00,0x00,0x38,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0xF8,0x3F,  // 74
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x00,0x04,0x00,0x00,0x02,0x00,0x00,0x01,0x00,0x80,0x03,0x00,0x40,0x04,0x00,0x20,0x18,0x00,0x10,0x20,0x00,0x08,0x40, // 75
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40, // 76
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x30,0x00,0x00,0xC0,0x00,0x00,0x00,0x03,0x00,0x00,0x1C,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x00,0x03,0x00,0xC0,0x00,0x00,0x30,0x00,0x00,0xF8,0x7F, // 77
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x10,0x00,0x00,0x60,0x00,0x00,0x80,0x00,0x00,0x00,0x03,0x00,0x00,0x04,0x00,0x00,0x18,0x00,0x00,0x20,0x00,0xF8,0x7F, // 78
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F,  // 79
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x10,0x01,0x00,0xE0,  // 80
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x08,0x50,0x00,0x08,0x50,0x00,0x10,0x20,0x00,0x20,0x70,0x00,0xC0,0x4F,  // 81
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x02,0x00,0x08,0x06,0x00,0x08,0x1A,0x00,0x10,0x21,0x00,0xE0,0x40, // 82
                    0x00,0x00,0x00,0x60,0x10,0x00,0x90,0x20,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x42,0x00,0x08,0x42,0x00,0x10,0x22,0x00,0x20,0x1C, // 83
                    0x08,0x00,0x00,0x08,0x00,0x00,0x08,0x00,0x00,0x08,0x00,0x00,0xF8,0x7F,0x00,0x08,0x00,0x00,0x08,0x00,0x00,0x08,0x00,0x00,0x08, // 84
                    0x00,0x00,0x00,0xF8,0x1F,0x00,0x00,0x20,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x20,0x00,0xF8,0x1F, // 85
                    0x00,0x00,0x00,0x18,0x00,0x00,0xE0,0x00,0x00,0x00,0x07,0x00,0x00,0x18,0x00,0x00,0x60,0x00,0x00,0x18,0x00,0x00,0x07,0x00,0xE0,0x00,0x00,0x18,  // 86
                    0x18,0x00,0x00,0xE0,0x01,0x00,0x00,0x1E,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x80,0x03,0x00,0x70,0x00,0x00,0x08,0x00,0x00,0x70,0x00,0x00,0x80,0x03,0x00,0x00,0x1C,0x00,0x00,0x60,0x00,0x00,0x1E,0x00,0xE0,0x01,0x00,0x18, // 87
                    0x00,0x40,0x00,0x08,0x20,0x00,0x10,0x10,0x00,0x60,0x0C,0x00,0x80,0x02,0x00,0x00,0x01,0x00,0x80,0x02,0x00,0x60,0x0C,0x00,0x10,0x10,0x00,0x08,0x20,0x00,0x00,0x40,  // 88
                    0x08,0x00,0x00,0x30,0x00,0x00,0x40,0x00,0x00,0x80,0x01,0x00,0x00,0x7E,0x00,0x80,0x01,0x00,0x40,0x00,0x00,0x30,0x00,0x00,0x08, // 89
                    0x00,0x40,0x00,0x08,0x60,0x00,0x08,0x58,0x00,0x08,0x44,0x00,0x08,0x43,0x00,0x88,0x40,0x00,0x68,0x40,0x00,0x18,0x40,0x00,0x08,0x40,  // 90
                    0x00,0x00,0x00,0xF8,0xFF,0x03,0x08,0x00,0x02,0x08,0x00,0x02,  // 91
                    0x18,0x00,0x00,0xE0,0x01,0x00,0x00,0x1E,0x00,0x00,0x60, // 92
                    0x08,0x00,0x02,0x08,0x00,0x02,0xF8,0xFF,0x03, // 93
                    0x00,0x01,0x00,0xC0,0x00,0x00,0x30,0x00,0x00,0x08,0x00,0x00,0x30,0x00,0x00,0xC0,0x00,0x00,0x00,0x01,  // 94
                    0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02, // 95
                    0x00,0x00,0x00,0x08,0x00,0x00,0x10, // 96
                    0x00,0x00,0x00,0x00,0x39,0x00,0x80,0x44,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x40,0x42,0x00,0x40,0x22,0x00,0x80,0x7F, // 97
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x80,0x20,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x80,0x20,0x00,0x00,0x1F, // 98
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x80,0x20,  // 99
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x80,0x20,0x00,0xF8,0x7F, // 100
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x24,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x80,0x24,0x00,0x00,0x17, // 101
                    0x40,0x00,0x00,0xF0,0x7F,0x00,0x48,0x00,0x00,0x48,  // 102
                    0x00,0x00,0x00,0x00,0x1F,0x01,0x80,0x20,0x02,0x40,0x40,0x02,0x40,0x40,0x02,0x40,0x40,0x02,0x80,0x20,0x01,0xC0,0xFF, // 103
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x80,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x80,0x7F,  // 104
                    0x00,0x00,0x00,0xC8,0x7F, // 105
                    0x00,0x00,0x02,0xC8,0xFF,0x01,  // 106
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x00,0x08,0x00,0x00,0x04,0x00,0x00,0x06,0x00,0x00,0x19,0x00,0x80,0x20,0x00,0x40,0x40, // 107
                    0x00,0x00,0x00,0xF8,0x7F, // 108
                    0x00,0x00,0x00,0xC0,0x7F,0x00,0x80,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x80,0x7F,0x00,0x80,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x80,0x7F, // 109
                    0x00,0x00,0x00,0xC0,0x7F,0x00,0x80,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x80,0x7F,  // 110
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x80,0x20,0x00,0x00,0x1F, // 111
                    0x00,0x00,0x00,0xC0,0xFF,0x03,0x80,0x20,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x80,0x20,0x00,0x00,0x1F, // 112
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x80,0x20,0x00,0xC0,0xFF,0x03,  // 113
                    0x00,0x00,0x00,0xC0,0x7F,0x00,0x80,0x00,0x00,0x40,0x00,0x00,0x40, // 114
                    0x00,0x00,0x00,0x80,0x23,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x80,0x38,  // 115
                    0x40,0x00,0x00,0xF0,0x7F,0x00,0x40,0x40,0x00,0x40,0x40, // 116
                    0x00,0x00,0x00,0xC0,0x3F,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x20,0x00,0xC0,0x7F,  // 117
                    0xC0,0x00,0x00,0x00,0x03,0x00,0x00,0x1C,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x00,0x03,0x00,0xC0, // 118
                    0xC0,0x00,0x00,0x00,0x1F,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x00,0x03,0x00,0xC0,0x00,0x00,0x00,0x03,0x00,0x00,0x1C,0x00,0x00,0x60,0x00,0x00,0x1F,0x00,0xC0, // 119
                    0x40,0x40,0x00,0x80,0x20,0x00,0x00,0x1B,0x00,0x00,0x04,0x00,0x00,0x1B,0x00,0x80,0x20,0x00,0x40,0x40,  // 120
                    0xC0,0x01,0x00,0x00,0x06,0x02,0x00,0x38,0x02,0x00,0xE0,0x01,0x00,0x38,0x00,0x00,0x07,0x00,0xC0, // 121
                    0x40,0x40,0x00,0x40,0x60,0x00,0x40,0x58,0x00,0x40,0x44,0x00,0x40,0x43,0x00,0xC0,0x40,0x00,0x40,0x40,  // 122
                    0x00,0x04,0x00,0x00,0x04,0x00,0xF0,0xFB,0x01,0x08,0x00,0x02,0x08,0x00,0x02, // 123
                    0x00,0x00,0x00,0xF8,0xFF,0x03,  // 124
                    0x08,0x00,0x02,0x08,0x00,0x02,0xF0,0xFB,0x01,0x00,0x04,0x00,0x00,0x04,  // 125
                    0x00,0x02,0x00,0x00,0x01,0x00,0x00,0x01,0x00,0x00,0x01,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x01, // 126
                    0x00,0x00,0x00,0x00,0x00,0x00,0x40,0xFF,0x03, // 161
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x03,0x40,0xF0,0x00,0x40,0x4E,0x00,0xC0,0x41,0x00,0xB8,0x20,0x00,0x00,0x11, // 162
                    0x00,0x41,0x00,0xE0,0x31,0x00,0x10,0x2F,0x00,0x08,0x21,0x00,0x08,0x21,0x00,0x08,0x40,0x00,0x10,0x40,0x00,0x20,0x20, // 163
                    0x00,0x00,0x00,0x40,0x0B,0x00,0x80,0x04,0x00,0x40,0x08,0x00,0x40,0x08,0x00,0x80,0x04,0x00,0x40,0x0B,  // 164
                    0x08,0x0A,0x00,0x10,0x0A,0x00,0x60,0x0A,0x00,0x80,0x0B,0x00,0x00,0x7E,0x00,0x80,0x0B,0x00,0x60,0x0A,0x00,0x10,0x0A,0x00,0x08,0x0A,  // 165
                    0x00,0x00,0x00,0xF8,0xF1,0x03,  // 166
                    0x00,0x86,0x00,0x70,0x09,0x01,0xC8,0x10,0x02,0x88,0x10,0x02,0x08,0x21,0x02,0x08,0x61,0x02,0x30,0xD2,0x01,0x00,0x0C, // 167
                    0x08,0x00,0x00,0x00,0x00,0x00,0x08, // 168
                    0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0xC8,0x47,0x00,0x28,0x48,0x00,0x28,0x48,0x00,0x28,0x48,0x00,0x28,0x48,0x00,0x48,0x44,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F, // 169
                    0xD0,0x00,0x00,0x48,0x01,0x00,0x28,0x01,0x00,0x28,0x01,0x00,0xF0,0x01,  // 170
                    0x00,0x00,0x00,0x00,0x04,0x00,0x00,0x1B,0x00,0x80,0x20,0x00,0x00,0x04,0x00,0x00,0x1B,0x00,0x80,0x20,  // 171
                    0x00,0x00,0x00,0x80,0x00,0x00,0x80,0x00,0x00,0x80,0x00,0x00,0x80,0x00,0x00,0x80,0x00,0x00,0x80,0x00,0x00,0x80,0x0F, // 172
                    0x00,0x08,0x00,0x00,0x08,0x00,0x00,0x08,0x00,0x00,0x08, // 173
                    0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0xE8,0x4F,0x00,0x28,0x41,0x00,0x28,0x41,0x00,0x28,0x43,0x00,0x28,0x45,0x00,0xC8,0x48,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F, // 174
                    0x04,0x00,0x00,0x04,0x00,0x00,0x04,0x00,0x00,0x04,0x00,0x00,0x04,0x00,0x00,0x04,0x00,0x00,0x04,0x00,0x00,0x04,0x00,0x00,0x04, // 175
                    0x00,0x00,0x00,0x30,0x00,0x00,0x48,0x00,0x00,0x48,0x00,0x00,0x30, // 176
                    0x00,0x00,0x00,0x00,0x41,0x00,0x00,0x41,0x00,0x00,0x41,0x00,0xE0,0x4F,0x00,0x00,0x41,0x00,0x00,0x41,0x00,0x00,0x41, // 177
                    0x10,0x01,0x00,0x88,0x01,0x00,0x48,0x01,0x00,0x48,0x01,0x00,0x30,0x01,  // 178
                    0x90,0x00,0x00,0x08,0x01,0x00,0x08,0x01,0x00,0x28,0x01,0x00,0xD8, // 179
                    0x00,0x00,0x00,0x00,0x00,0x00,0x10,0x00,0x00,0x08,  // 180
                    0x00,0x00,0x00,0xC0,0xFF,0x03,0x00,0x20,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x20,0x00,0xC0,0x7F, // 181
                    0xF0,0x00,0x00,0xF8,0x00,0x00,0xF8,0x01,0x00,0xF8,0x01,0x00,0xF8,0xFF,0x03,0x08,0x00,0x00,0x08,0x00,0x00,0xF8,0xFF,0x03,0x08, // 182
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x02,  // 183
                    0x00,0x00,0x00,0x00,0x00,0x02,0x00,0x80,0x02,0x00,0x00,0x03,  // 184
                    0x00,0x00,0x00,0x10,0x00,0x00,0x08,0x00,0x00,0xF8,0x01, // 185
                    0xF0,0x00,0x00,0x08,0x01,0x00,0x08,0x01,0x00,0x08,0x01,0x00,0xF0, // 186
                    0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x20,0x00,0x00,0x1B,0x00,0x00,0x04,0x00,0x80,0x20,0x00,0x00,0x1B,0x00,0x00,0x04, // 187
                    0x00,0x00,0x00,0x10,0x00,0x00,0x08,0x40,0x00,0xF8,0x21,0x00,0x00,0x10,0x00,0x00,0x0C,0x00,0x00,0x02,0x00,0x80,0x01,0x00,0x40,0x30,0x00,0x30,0x28,0x00,0x08,0x24,0x00,0x00,0x7E,0x00,0x00,0x20,  // 188
                    0x00,0x00,0x00,0x10,0x00,0x00,0x08,0x40,0x00,0xF8,0x31,0x00,0x00,0x08,0x00,0x00,0x04,0x00,0x00,0x03,0x00,0x80,0x00,0x00,0x60,0x44,0x00,0x10,0x62,0x00,0x08,0x52,0x00,0x00,0x52,0x00,0x00,0x4C,  // 189
                    0x90,0x00,0x00,0x08,0x01,0x00,0x08,0x41,0x00,0x28,0x21,0x00,0xD8,0x18,0x00,0x00,0x04,0x00,0x00,0x03,0x00,0x80,0x00,0x00,0x40,0x30,0x00,0x30,0x28,0x00,0x08,0x24,0x00,0x00,0x7E,0x00,0x00,0x20,  // 190
                    0x00,0x00,0x00,0x00,0xE0,0x00,0x00,0x10,0x01,0x00,0x08,0x02,0x40,0x07,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x01,0x00,0xC0,  // 191
                    0x00,0x00,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x80,0x07,0x00,0x71,0x04,0x00,0x0A,0x04,0x00,0x70,0x04,0x00,0x80,0x07,0x00,0x00,0x1C,0x00,0x00,0x60, // 192
                    0x00,0x00,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x80,0x07,0x00,0x70,0x04,0x00,0x0A,0x04,0x00,0x71,0x04,0x00,0x80,0x07,0x00,0x00,0x1C,0x00,0x00,0x60, // 193
                    0x00,0x00,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x80,0x07,0x00,0x72,0x04,0x00,0x09,0x04,0x00,0x71,0x04,0x00,0x82,0x07,0x00,0x00,0x1C,0x00,0x00,0x60, // 194
                    0x00,0x00,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x80,0x07,0x00,0x72,0x04,0x00,0x09,0x04,0x00,0x72,0x04,0x00,0x81,0x07,0x00,0x00,0x1C,0x00,0x00,0x60, // 195
                    0x00,0x00,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x80,0x07,0x00,0x72,0x04,0x00,0x08,0x04,0x00,0x72,0x04,0x00,0x80,0x07,0x00,0x00,0x1C,0x00,0x00,0x60, // 196
                    0x00,0x00,0x00,0x00,0x60,0x00,0x00,0x1C,0x00,0x80,0x07,0x00,0x7E,0x04,0x00,0x0A,0x04,0x00,0x7E,0x04,0x00,0x80,0x07,0x00,0x00,0x1C,0x00,0x00,0x60, // 197
                    0x00,0x60,0x00,0x00,0x18,0x00,0x00,0x06,0x00,0x80,0x05,0x00,0x60,0x04,0x00,0x18,0x04,0x00,0x08,0x04,0x00,0x08,0x04,0x00,0xF8,0x7F,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,  // 198
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x08,0x40,0x02,0x08,0xC0,0x02,0x08,0x40,0x03,0x08,0x40,0x00,0x10,0x20,0x00,0x20,0x10,  // 199
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x09,0x41,0x00,0x0A,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x40, // 200
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x0A,0x41,0x00,0x09,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x40, // 201
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x0A,0x41,0x00,0x09,0x41,0x00,0x09,0x41,0x00,0x0A,0x41,0x00,0x08,0x41,0x00,0x08,0x40, // 202
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x0A,0x41,0x00,0x08,0x41,0x00,0x0A,0x41,0x00,0x08,0x41,0x00,0x08,0x41,0x00,0x08,0x40, // 203
                    0x01,0x00,0x00,0xFA,0x7F, // 204
                    0x00,0x00,0x00,0xFA,0x7F,0x00,0x01, // 205
                    0x02,0x00,0x00,0xF9,0x7F,0x00,0x01,0x00,0x00,0x02,  // 206
                    0x02,0x00,0x00,0xF8,0x7F,0x00,0x02, // 207
                    0x00,0x02,0x00,0xF8,0x7F,0x00,0x08,0x42,0x00,0x08,0x42,0x00,0x08,0x42,0x00,0x08,0x42,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F,  // 208
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x10,0x00,0x00,0x60,0x00,0x00,0x82,0x00,0x00,0x01,0x03,0x00,0x02,0x04,0x00,0x01,0x18,0x00,0x00,0x20,0x00,0xF8,0x7F, // 209
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x09,0x40,0x00,0x0A,0x40,0x00,0x08,0x40,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F,  // 210
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x0A,0x40,0x00,0x09,0x40,0x00,0x08,0x40,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F,  // 211
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x0A,0x40,0x00,0x09,0x40,0x00,0x09,0x40,0x00,0x0A,0x40,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F,  // 212
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x0A,0x40,0x00,0x09,0x40,0x00,0x0A,0x40,0x00,0x09,0x40,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F,  // 213
                    0x00,0x00,0x00,0xC0,0x0F,0x00,0x20,0x10,0x00,0x10,0x20,0x00,0x08,0x40,0x00,0x0A,0x40,0x00,0x08,0x40,0x00,0x0A,0x40,0x00,0x10,0x20,0x00,0x20,0x10,0x00,0xC0,0x0F,  // 214
                    0x00,0x00,0x00,0x40,0x10,0x00,0x80,0x08,0x00,0x00,0x05,0x00,0x00,0x07,0x00,0x00,0x05,0x00,0x80,0x08,0x00,0x40,0x10, // 215
                    0x00,0x00,0x00,0xC0,0x4F,0x00,0x20,0x30,0x00,0x10,0x30,0x00,0x08,0x4C,0x00,0x08,0x42,0x00,0x08,0x41,0x00,0xC8,0x40,0x00,0x30,0x20,0x00,0x30,0x10,0x00,0xC8,0x0F,  // 216
                    0x00,0x00,0x00,0xF8,0x1F,0x00,0x00,0x20,0x00,0x00,0x40,0x00,0x01,0x40,0x00,0x02,0x40,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x00,0x20,0x00,0xF8,0x1F, // 217
                    0x00,0x00,0x00,0xF8,0x1F,0x00,0x00,0x20,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x02,0x40,0x00,0x01,0x40,0x00,0x00,0x40,0x00,0x00,0x20,0x00,0xF8,0x1F, // 218
                    0x00,0x00,0x00,0xF8,0x1F,0x00,0x00,0x20,0x00,0x00,0x40,0x00,0x02,0x40,0x00,0x01,0x40,0x00,0x01,0x40,0x00,0x02,0x40,0x00,0x00,0x20,0x00,0xF8,0x1F, // 219
                    0x00,0x00,0x00,0xF8,0x1F,0x00,0x00,0x20,0x00,0x00,0x40,0x00,0x02,0x40,0x00,0x00,0x40,0x00,0x02,0x40,0x00,0x00,0x40,0x00,0x00,0x20,0x00,0xF8,0x1F, // 220
                    0x08,0x00,0x00,0x30,0x00,0x00,0x40,0x00,0x00,0x80,0x01,0x00,0x02,0x7E,0x00,0x81,0x01,0x00,0x40,0x00,0x00,0x30,0x00,0x00,0x08, // 221
                    0x00,0x00,0x00,0xF8,0x7F,0x00,0x20,0x10,0x00,0x20,0x10,0x00,0x20,0x10,0x00,0x20,0x10,0x00,0x20,0x10,0x00,0x20,0x10,0x00,0x40,0x08,0x00,0x80,0x07, // 222
                    0x00,0x00,0x00,0xE0,0x7F,0x00,0x10,0x00,0x00,0x08,0x20,0x00,0x88,0x43,0x00,0x70,0x42,0x00,0x00,0x44,0x00,0x00,0x38, // 223
                    0x00,0x00,0x00,0x00,0x39,0x00,0x80,0x44,0x00,0x40,0x44,0x00,0x48,0x44,0x00,0x50,0x42,0x00,0x40,0x22,0x00,0x80,0x7F, // 224
                    0x00,0x00,0x00,0x00,0x39,0x00,0x80,0x44,0x00,0x40,0x44,0x00,0x50,0x44,0x00,0x48,0x42,0x00,0x40,0x22,0x00,0x80,0x7F, // 225
                    0x00,0x00,0x00,0x00,0x39,0x00,0x80,0x44,0x00,0x50,0x44,0x00,0x48,0x44,0x00,0x48,0x42,0x00,0x50,0x22,0x00,0x80,0x7F, // 226
                    0x00,0x00,0x00,0x00,0x39,0x00,0x80,0x44,0x00,0x50,0x44,0x00,0x48,0x44,0x00,0x50,0x42,0x00,0x48,0x22,0x00,0x80,0x7F, // 227
                    0x00,0x00,0x00,0x00,0x39,0x00,0x80,0x44,0x00,0x50,0x44,0x00,0x40,0x44,0x00,0x50,0x42,0x00,0x40,0x22,0x00,0x80,0x7F, // 228
                    0x00,0x00,0x00,0x00,0x39,0x00,0x80,0x44,0x00,0x5C,0x44,0x00,0x54,0x44,0x00,0x5C,0x42,0x00,0x40,0x22,0x00,0x80,0x7F, // 229
                    0x00,0x00,0x00,0x00,0x39,0x00,0x80,0x44,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x40,0x42,0x00,0x40,0x22,0x00,0x80,0x3F,0x00,0x80,0x24,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x40,0x44,0x00,0x80,0x24,0x00,0x00,0x17, // 230
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x40,0x40,0x02,0x40,0xC0,0x02,0x40,0x40,0x03,0x80,0x20,  // 231
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x24,0x00,0x48,0x44,0x00,0x50,0x44,0x00,0x40,0x44,0x00,0x80,0x24,0x00,0x00,0x17, // 232
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x24,0x00,0x40,0x44,0x00,0x50,0x44,0x00,0x48,0x44,0x00,0x80,0x24,0x00,0x00,0x17, // 233
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x24,0x00,0x50,0x44,0x00,0x48,0x44,0x00,0x48,0x44,0x00,0x90,0x24,0x00,0x00,0x17, // 234
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x24,0x00,0x50,0x44,0x00,0x40,0x44,0x00,0x50,0x44,0x00,0x80,0x24,0x00,0x00,0x17, // 235
                    0x08,0x00,0x00,0xD0,0x7F, // 236
                    0x00,0x00,0x00,0xD0,0x7F,0x00,0x08, // 237
                    0x10,0x00,0x00,0xC8,0x7F,0x00,0x08,0x00,0x00,0x10,  // 238
                    0x10,0x00,0x00,0xC0,0x7F,0x00,0x10, // 239
                    0x00,0x00,0x00,0x00,0x1F,0x00,0xA0,0x20,0x00,0x68,0x40,0x00,0x58,0x40,0x00,0x70,0x40,0x00,0xE8,0x20,0x00,0x00,0x1F, // 240
                    0x00,0x00,0x00,0xC0,0x7F,0x00,0x90,0x00,0x00,0x48,0x00,0x00,0x50,0x00,0x00,0x48,0x00,0x00,0x80,0x7F,  // 241
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x48,0x40,0x00,0x50,0x40,0x00,0x40,0x40,0x00,0x80,0x20,0x00,0x00,0x1F, // 242
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x40,0x40,0x00,0x50,0x40,0x00,0x48,0x40,0x00,0x80,0x20,0x00,0x00,0x1F, // 243
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x50,0x40,0x00,0x48,0x40,0x00,0x48,0x40,0x00,0x90,0x20,0x00,0x00,0x1F, // 244
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x50,0x40,0x00,0x48,0x40,0x00,0x50,0x40,0x00,0x88,0x20,0x00,0x00,0x1F, // 245
                    0x00,0x00,0x00,0x00,0x1F,0x00,0x80,0x20,0x00,0x50,0x40,0x00,0x40,0x40,0x00,0x50,0x40,0x00,0x80,0x20,0x00,0x00,0x1F, // 246
                    0x00,0x00,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x80,0x0A,0x00,0x00,0x02,0x00,0x00,0x02,0x00,0x00,0x02, // 247
                    0x00,0x00,0x00,0x00,0x5F,0x00,0x80,0x30,0x00,0x40,0x48,0x00,0x40,0x44,0x00,0x40,0x42,0x00,0x80,0x21,0x00,0x40,0x1F, // 248
                    0x00,0x00,0x00,0xC0,0x3F,0x00,0x00,0x40,0x00,0x08,0x40,0x00,0x10,0x40,0x00,0x00,0x20,0x00,0xC0,0x7F,  // 249
                    0x00,0x00,0x00,0xC0,0x3F,0x00,0x00,0x40,0x00,0x00,0x40,0x00,0x10,0x40,0x00,0x08,0x20,0x00,0xC0,0x7F,  // 250
                    0x00,0x00,0x00,0xC0,0x3F,0x00,0x10,0x40,0x00,0x08,0x40,0x00,0x08,0x40,0x00,0x10,0x20,0x00,0xC0,0x7F,  // 251
                    0x00,0x00,0x00,0xD0,0x3F,0x00,0x00,0x40,0x00,0x10,0x40,0x00,0x00,0x40,0x00,0x00,0x20,0x00,0xC0,0x7F,  // 252
                    0xC0,0x01,0x00,0x00,0x06,0x02,0x00,0x38,0x02,0x10,0xE0,0x01,0x08,0x38,0x00,0x00,0x07,0x00,0xC0, // 253
                    0x00,0x00,0x00,0xF8,0xFF,0x03,0x80,0x20,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x40,0x40,0x00,0x80,0x20,0x00,0x00,0x1F, // 254
                    0xC0,0x01,0x00,0x00,0x06,0x02,0x10,0x38,0x02,0x00,0xE0,0x01,0x10,0x38,0x00,0x00,0x07,0x00,0xC0  // 255            
                }
            );

            return arialMTPlain16;
        }

    }
}
