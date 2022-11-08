namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum NamedColors
{
  Automatic = -16777216, // 0xFF000000
  Black = 0,
  DarkRed = 128, // 0x00000080
  Red = 255, // 0x000000FF
  DarkGreen = 13056, // 0x00003300
  OliveGreen = 13107, // 0x00003333
  Brown = 13209, // 0x00003399
  Orange = 26367, // 0x000066FF
  Green = 32768, // 0x00008000
  DarkYellow = 32896, // 0x00008080
  LightOrange = 39423, // 0x000099FF
  Lime = 52377, // 0x0000CC99
  Gold = 52479, // 0x0000CCFF
  BrightGreen = 65280, // 0x0000FF00
  Yellow = 65535, // 0x0000FFFF
  Gray95 = 789516, // 0x000C0C0C
  Gray90 = 1644825, // 0x00191919
  Gray875 = 2105376, // 0x00202020
  Gray85 = 2500134, // 0x00262626
  Gray80 = 3355443, // 0x00333333
  Gray75 = 4210752, // 0x00404040
  Gray70 = 5000268, // 0x004C4C4C
  Gray65 = 5855577, // 0x00595959
  Gray625 = 6316128, // 0x00606060
  DarkTeal = 6697728, // 0x00663300
  Plum = 6697881, // 0x00663399
  Gray60 = 6710886, // 0x00666666
  SeaGreen = 6723891, // 0x00669933
  Gray55 = 7566195, // 0x00737373
  DarkBlue = 8388608, // 0x00800000
  Violet = 8388736, // 0x00800080
  Teal = 8421376, // 0x00808000
  Gray50 = 8421504, // 0x00808080
  Gray45 = 9211020, // 0x008C8C8C
  Indigo = 10040115, // 0x00993333
  BlueGray = 10053222, // 0x00996666
  Gray40 = 10066329, // 0x00999999
  Tan = 10079487, // 0x0099CCFF
  LightYellow = 10092543, // 0x0099FFFF
  Gray375 = 10526880, // 0x00A0A0A0
  Gray35 = 10921638, // 0x00A6A6A6
  Gray30 = 11776947, // 0x00B3B3B3
  Gray25 = 12632256, // 0x00C0C0C0
  Rose = 13408767, // 0x00CC99FF
  Aqua = 13421619, // 0x00CCCC33
  Gray20 = 13421772, // 0x00CCCCCC
  LightGreen = 13434828, // 0x00CCFFCC
  Gray15 = 14277081, // 0x00D9D9D9
  Gray125 = 14737632, // 0x00E0E0E0
  Gray10 = 15132390, // 0x00E6E6E6
  Gray05 = 15987699, // 0x00F3F3F3
  Blue = 16711680, // 0x00FF0000
  Pink = 16711935, // 0x00FF00FF
  LightBlue = 16737843, // 0x00FF6633
  Lavender = 16751052, // 0x00FF99CC
  SkyBlue = 16763904, // 0x00FFCC00
  PaleBlue = 16764057, // 0x00FFCC99
  Turquoise = 16776960, // 0x00FFFF00
  LightTurquoise = 16777164, // 0x00FFFFCC
  White = 16777215, // 0x00FFFFFF
}