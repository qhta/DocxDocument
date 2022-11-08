namespace DocxDocument.Reader;

public static class StringExtensions
{
  private static Dictionary<string, Dictionary<char, int>> Charsets = new Dictionary<string, Dictionary<char, int>>();

  private const string PolishDiacriticChars = "ąćęłńóśźż";

  public static bool ContainsPolishDiacritics(this string str)
  {
    for (int idx = 0; idx < str.Length; ++idx)
    {
      if (PolishDiacriticChars.Contains(str[idx]))
      {
        return true;
      }
    }

    return false;
  }

  public static bool InPolishDiacritics(this char ch)
  {
    return PolishDiacriticChars.Contains(ch);
  }

  #region Decoding charsets

  public static bool EnsureLoadCharset(string charsetName, string filename)
  {
    if (Charsets.TryGetValue(charsetName, out var charset))
      return charset!=null;
    if (File.Exists(filename))
    {
      charset = LoadCharset(filename);
      if (charset.Count > 0)
      {
        Charsets.Add(charsetName, charset);
        return true;
      }
      else
      {
        Charsets.Add(charsetName, null);
      }
    }
    return false;
  }

  public static Dictionary<char, int> LoadCharset(string filename)
  {
    Dictionary<char, int> charset = new Dictionary<char, int>();
    using (var textReader = File.OpenText(filename))
    {
      string line;
      while ((line = textReader.ReadLine())!=null)
      {
        var strs = line.Split(new char[] { ',', ';' });
        if (strs.Length >= 2)
        {
          if (UInt16.TryParse(strs[0], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var charCode)
              && Int32.TryParse(strs[1], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var unicode))
            charset.Add((char)charCode, unicode);
        }
      }
    }
    return charset;
  }
  public static string DecodeCharset(this string str, string charsetName)
  {
    return DecodeCharset(str, Charsets[charsetName]);
  }

  public static string DecodeCharset(this string str, Dictionary<char, int> charset)
  {
    char[] chars = str.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
      chars[i] = DecodeCharset(chars[i], charset);
    }
    str = new string(chars);
    return str;
  }

  public static char DecodeCharset(this char ch, Dictionary<char, int> charset)
  {
    if (ch >= '\uF000' && ch <= '\uF0FF')
      ch = (char)(ch - '\uF000');
    if (charset.TryGetValue(ch, out var code))
      if (code <= 0xFFFFFF)
        return (char)code;
    return ch;
  }
  #endregion

  //#region SymbolCharset
  //public static string DecodeSymbolCharset(this string str)
  //{
  //  char[] chars = str.ToCharArray();
  //  for (int i = 0; i < chars.Length; i++)
  //  {
  //    chars[i] = DecodeSymbolCharset(chars[i]);
  //  }
  //  str = new string(chars);
  //  return str;
  //}

  //private static Dictionary<char, int> SymbolCharset = new Dictionary<char, int>
  //{
  //  { ' ', 0x0020 },
  //  { '!', 0x0021 },
  //  { '"', 0x2200 },
  //  { '#', 0x0023 },
  //  { '$', 0x2203 },
  //  { '%', 0x0025 },
  //  { '&', 0x0026 },
  //  { '\'', 0x220D },
  //  { '(', 0x0028 },
  //  { ')', 0x0029 },
  //  { '*', 0x002A },
  //  { '+', 0x002B },
  //  { ',', 0x002C },
  //  { '-', 0x2212 },
  //  { '.', 0x002E },
  //  { '/', 0x002F },
  //  { '0', 0x0030 },
  //  { '1', 0x0031 },
  //  { '2', 0x0032 },
  //  { '3', 0x0033 },
  //  { '4', 0x0034 },
  //  { '5', 0x0035 },
  //  { '6', 0x0036 },
  //  { '7', 0x0037 },
  //  { '8', 0x0038 },
  //  { '9', 0x0039 },
  //  { ':', 0x003A },
  //  { ';', 0x003B },
  //  { '<', 0x003C },
  //  { '=', 0x003D },
  //  { '>', 0x003E },
  //  { '?', 0x003F },
  //  { '@', 0x2245 },
  //  { 'A', 0x0391 },
  //  { 'B', 0x0392 },
  //  { 'C', 0x03A7 },
  //  { 'D', 0x0394 },
  //  { 'E', 0x0395 },
  //  { 'F', 0x03A6 },
  //  { 'G', 0x0393 },
  //  { 'H', 0x0397 },
  //  { 'I', 0x0399 },
  //  { 'J', 0x03D1 },
  //  { 'K', 0x039A },
  //  { 'L', 0x039B },
  //  { 'M', 0x039C },
  //  { 'N', 0x039D },
  //  { 'O', 0x039F },
  //  { 'P', 0x03A0 },
  //  { 'Q', 0x0398 },
  //  { 'R', 0x03A1 },
  //  { 'S', 0x03A3 },
  //  { 'T', 0x03A4 },
  //  { 'U', 0x03A5 },
  //  { 'V', 0x03C2 },
  //  { 'W', 0x03A9 },
  //  { 'X', 0x039E },
  //  { 'Y', 0x03A8 },
  //  { 'Z', 0x0396 },
  //  { '[', 0x005B },
  //  { '\\', 0x2234 },
  //  { ']', 0x005D },
  //  { '^', 0x22A5 },
  //  { '_', 0x005F },
  //  { '`', 0x203E }, 
  //  { 'a', 0x03B1 },
  //  { 'b', 0x03B2 },
  //  { 'c', 0x03C7 },
  //  { 'd', 0x03B4 },
  //  { 'e', 0x03B5 },
  //  { 'f', 0x03C6 },
  //  { 'g', 0x03B3 },
  //  { 'h', 0x03B7 },
  //  { 'i', 0x03B9 },
  //  { 'j', 0x03D5 },
  //  { 'k', 0x03BA },
  //  { 'l', 0x03BB },
  //  { 'm', 0x03BC },
  //  { 'n', 0x03BD },
  //  { 'o', 0x03BF },
  //  { 'p', 0x03C0 },
  //  { 'q', 0x03B8 },
  //  { 'r', 0x03C1 },
  //  { 's', 0x03C3 },
  //  { 't', 0x03C4 },
  //  { 'u', 0x03C5 },
  //  { 'v', 0x03D6 },
  //  { 'w', 0x03C9 },
  //  { 'x', 0x03BE },
  //  { 'y', 0x03C8 },
  //  { 'z', 0x03B6 },
  //  { '{', 0x007B },
  //  { '|', 0x007C },
  //  { '}', 0x007D },
  //  { '~', 0x007E },
  //  { '\u00A0', 0x21AC },
  //  { '\u00A1', 0x03D2 },
  //  { '\u00A2', 0x2032 },
  //  { '\u00A3', 0x2264 },
  //  { '\u00A4', 0x2044 },
  //  { '\u00A5', 0x221E },
  //  { '\u00A6', 0x0192 },
  //  { '\u00A7', 0x2663 },
  //  { '\u00A8', 0x2666 },
  //  { '\u00A9', 0x2665 },
  //  { '\u00AA', 0x2660 },
  //  { '\u00AB', 0x2194 },
  //  { '\u00AC', 0x2190 },
  //  { '\u00AD', 0x2191 },
  //  { '\u00AE', 0x2192 },
  //  { '\u00AF', 0x2193 },
  //  { '\u00B0', 0x00B0 },
  //  { '\u00B1', 0x00B1 },
  //  { '\u00B2', 0x2033 },
  //  { '\u00B3', 0x2265 },
  //  { '\u00B4', 0x00D7 },
  //  { '\u00B5', 0x221D },
  //  { '\u00B6', 0x2202 },
  //  { '\u00B7', 0x2022 },
  //  { '\u00B8', 0x00F7 },
  //  { '\u00B9', 0x2260 },
  //  { '\u00BA', 0x2261 },
  //  { '\u00BB', 0x2248 },
  //  { '\u00BC', 0x2026 },
  //  { '\u00BD', 0x23D0 },
  //  { '\u00BE', 0x23AF },
  //  { '\u00BF', 0x22B5 },
  //  { '\u00C0', 0x2135 },
  //  { '\u00C1', 0x2111 },
  //  { '\u00C2', 0x211C },
  //  { '\u00C3', 0x2118 },
  //  { '\u00C4', 0x2297 },
  //  { '\u00C5', 0x2295 },
  //  { '\u00C6', 0x2205 },
  //  { '\u00C7', 0x2229 },
  //  { '\u00C8', 0x222A },
  //  { '\u00C9', 0x2283 },
  //  { '\u00CA', 0x2287 },
  //  { '\u00CB', 0x2284 },
  //  { '\u00CC', 0x2282 },
  //  { '\u00CD', 0x2286 },
  //  { '\u00CE', 0x2208 },
  //  { '\u00CF', 0x2209 },
  //  { '\u00D0', 0x2220 },
  //  { '\u00D1', 0x2207 },
  //  { '\u00D2', 0x00AE },
  //  { '\u00D3', 0x00A9 },
  //  { '\u00D4', 0x2122 },
  //  { '\u00D5', 0x220F },
  //  { '\u00D6', 0x221A },
  //  { '\u00D7', 0x22C4 },
  //  { '\u00D8', 0x00AC },
  //  { '\u00D9', 0x2227 },
  //  { '\u00DA', 0x2228 },
  //  { '\u00DB', 0x21D4 },
  //  { '\u00DC', 0x21D0 },
  //  { '\u00DD', 0x21D1 },
  //  { '\u00DE', 0x21D2 },
  //  { '\u00DF', 0x21D3 },
  //  { '\u00E0', 0x25CA },
  //  { '\u00E1', 0x300B },
  //  { '\u00E2', 0x00AE },
  //  { '\u00E3', 0x00A9 },
  //  { '\u00E4', 0x2122 },
  //  { '\u00E5', 0x2211 },
  //  { '\u00E6', 0x2211 },
  //  { '\u00E7', 0x239B },
  //  { '\u00E8', 0x239C },
  //  { '\u00E9', 0x239D },
  //  { '\u00EA', 0x23A1 },
  //  { '\u00EB', 0x23A3 },
  //  { '\u00EC', 0x23A7 },
  //  { '\u00ED', 0x23A8 },
  //  { '\u00EE', 0x23A9 },
  //  { '\u00EF', 0x23AA },
  //  { '\u00F0', 0xFBFF },
  //  { '\u00F1', 0x3009 },
  //  { '\u00F2', 0x222B },
  //  { '\u00F3', 0x2320 },
  //  { '\u00F4', 0x23AE },
  //  { '\u00F5', 0x2321 },
  //  { '\u00F6', 0x239E },
  //  { '\u00F7', 0x239F },
  //  { '\u00F8', 0x23A0 },
  //  { '\u00F9', 0x23A4 },
  //  { '\u00FA', 0x23A5 },
  //  { '\u00FB', 0x23A6 },
  //  { '\u00FC', 0x23AB },
  //  { '\u00FD', 0x23AC },
  //  { '\u00FE', 0x23AD },
  //};

  //public static char DecodeSymbolCharset(this char ch)
  //{
  //  if (ch>='\uF000' && ch<='\uF0FF')
  //    ch = (char)(ch - '\uF000');
  //  if (SymbolCharset.TryGetValue(ch, out var code))
  //    if (code <= 0xFFFFFF)
  //      return (char)code;
  //  return ch;
  //}
  //#endregion Symbol charset

  #region Wingdings charset
  public static string DecodeWingdingsCharset(this string str)
  {
    char[] chars = str.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
      chars[i] = DecodeWingdingsCharset(chars[i]);
    }
    str = new string(chars);
    return str;
  }

  private static Dictionary<char, int> WingdingsCharset = new Dictionary<char, int>
  {
    { '\x20', 0x0020 }, //Space
    { '\x21', 0x1F589 }, //Lower left pencil
    { '\x22', 0x2702 }, //Black scissors
    { '\x23', 0x2701 }, //Upper blade scissors
    { '\x24', 0x1F453 }, //Eyeglasses
    { '\x25', 0x1F56D }, //Ringing bell
    { '\x26', 0x1F56E }, //Book
    { '\x27', 0x1F56F }, //Candle
    { '\x28', 0x1F57F }, //Black touchtone telephone
    { '\x29', 0x2706 }, //Telephone location sign
    { '\x2A', 0x1F582 }, //Back of envelope
    { '\x2B', 0x1F583 }, //Stamped envelope
    { '\x2C', 0x1F4EA }, //Closed mailbox with lowered flag
    { '\x2D', 0x1F4EB }, //Closed mailbox with raised flag
    { '\x2E', 0x1F4EC }, //Open mailbox with raised flag
    { '\x2F', 0x1F4ED }, //Open mailbox with lowered flag
    { '\x30', 0x1F4C1 }, //File folder
    { '\x31', 0x1F4C2 }, //Open file folder
    { '\x32', 0x1F4C4 }, //Page facing up
    { '\x33', 0x1F5CF }, //Page
    { '\x34', 0x1F5D0 }, //Pages
    { '\x35', 0x1F5C4 }, //File cabinet
    { '\x36', 0x231B }, //Hourglass
    { '\x37', 0x1F5AE }, //Wired keyboard
    { '\x38', 0x1F5B0 }, //Two button mouse
    { '\x39', 0x1F5B2 }, //Trackball
    { '\x3A', 0x1F5B3 }, //Old personal computer
    { '\x3B', 0x1F5B4 }, //Hard disk
    { '\x3C', 0x1F5AB }, //White hard shell floppy disk
    { '\x3D', 0x1F5AC }, //Soft shell floppy disk
    { '\x3E', 0x2707 }, //Tape drive
    { '\x3F', 0x270D }, //Writing hand
    { '\x40', 0x1F58E }, //Left writing hand
    { '\x41', 0x270C }, //Victory hand
    { '\x42', 0x1F44C }, //OK hand sign
    { '\x43', 0x1F44D }, //Thumbs up sign
    { '\x44', 0x1F44E }, //Thumbs down sign
    { '\x45', 0x261C }, //White left pointing index
    { '\x46', 0x261E }, //White right pointing index
    { '\x47', 0x261D }, //White up pointing index
    { '\x48', 0x261F }, //White down pointing index
    { '\x49', 0x1F590 }, //Raised hand with fingers splayed
    { '\x4A', 0x263A }, //White smiling face
    { '\x4B', 0x1F610 }, //Neutral face
    { '\x4C', 0x2639 }, //White frowning face
    { '\x4D', 0x1F4A3 }, //Bomb
    { '\x4E', 0x2620 }, //Skull and crossbones
    { '\x4F', 0x1F3F3 }, //Waving white flag
    { '\x50', 0x1F3F1 }, //White pennant
    { '\x51', 0x2708 }, //Airplane
    { '\x52', 0x263C }, //White sun with rays
    { '\x53', 0x1F4A7 }, //Droplet
    { '\x54', 0x2744 }, //Snowflake
    { '\x55', 0x1F546 }, //White Latin cross
    { '\x56', 0x271E }, //Shadowed white Latin cross
    { '\x57', 0x1F548 }, //Celtic cross
    { '\x58', 0x2720 }, //Maltese cross
    { '\x59', 0x2721 }, //Star of David
    { '\x5A', 0x262A }, //Star and crescent
    { '\x5B', 0x262F }, //Yin Yang
    { '\x5C', 0x0950 }, //Devanagari Om
    { '\x5D', 0x2638 }, //Wheel of Dharma
    { '\x5E', 0x2648 }, //Aries
    { '\x5F', 0x2649 }, //Taurus
    { '\x60', 0x264A }, //Gemini
    { '\x61', 0x264B }, //Cancer
    { '\x62', 0x264C }, //Leo
    { '\x63', 0x264D }, //Virgo
    { '\x64', 0x264E }, //Libra
    { '\x65', 0x264F }, //Scorpio
    { '\x66', 0x2650 }, //Sagittarius
    { '\x67', 0x2651 }, //Capricorn
    { '\x68', 0x2652 }, //Aquarius
    { '\x69', 0x2653 }, //Pisces
    { '\x6A', 0x1F670 }, //Script ligature et ornament
    { '\x6B', 0x1F675 }, //Swash ampersand ornament
    { '\x6C', 0x25CF }, //Black circle
    { '\x6D', 0x1F53E }, //Lower right shadowed white circle
    { '\x6E', 0x25A0 }, //Black square
    { '\x6F', 0x25A1 }, //White square
    { '\x70', 0x1F790 }, //Bold white square
    { '\x71', 0x2751 }, //Lower right shadowed white square
    { '\x72', 0x2752 }, //Upper right shadowed white square
    { '\x73', 0x2B27 }, //Black medium lozenge
    { '\x74', 0x29EB }, //Black lozenge
    { '\x75', 0x25C6 }, //Black diamond
    { '\x76', 0x2756 }, //Black diamond minus white X
    { '\x77', 0x2B25 }, //Black medium diamond
    { '\x78', 0x2327 }, //X in a rectangle box
    { '\x79', 0x2BB9 }, //Up arrowhead in a rectangle box
    { '\x7A', 0x2318 }, //Place of interest sign
    { '\x7B', 0x1F3F5 }, //Rosette
    { '\x7C', 0x1F3F6 }, //Black rosette
    { '\x7D', 0x1F676 }, //Sans-serif heavy double turned comma quotation mark ornament
    { '\x7E', 0x1F677 }, //Sans-serif heavy double comma quotation mark ornament
    { '\x80', 0x24EA }, //Circled digit zero
    { '\x81', 0x2460 }, //Circled digit one
    { '\x82', 0x2461 }, //Circled digit two
    { '\x83', 0x2462 }, //Circled digit three
    { '\x84', 0x2463 }, //Circled digit four
    { '\x85', 0x2464 }, //Circled digit five
    { '\x86', 0x2465 }, //Circled digit six
    { '\x87', 0x2466 }, //Circled digit seven
    { '\x88', 0x2467 }, //Circled digit eight
    { '\x89', 0x2468 }, //Circled digit nine
    { '\x8A', 0x2469 }, //Circled number ten
    { '\x8B', 0x24FF }, //Negative circled digit zero
    { '\x8C', 0x2776 }, //Dingbat negative circled digit one
    { '\x8D', 0x2777 }, //Dingbat negative circled digit two
    { '\x8E', 0x2778 }, //Dingbat negative circled digit three
    { '\x8F', 0x2779 }, //Dingbat negative circled digit four
    { '\x90', 0x277A }, //Dingbat negative circled digit five
    { '\x91', 0x277B }, //Dingbat negative circled digit six
    { '\x92', 0x277C }, //Dingbat negative circled digit seven
    { '\x93', 0x277D }, //Dingbat negative circled digit eight
    { '\x94', 0x277E }, //Dingbat negative circled digit nine
    { '\x95', 0x277F }, //Dingbat negative circled number ten
    { '\x96', 0x1F662 }, //North east pointing bud
    { '\x97', 0x1F660 }, //North west pointing bud
    { '\x98', 0x1F661 }, //South west pointing bud
    { '\x99', 0x1F663 }, //South east pointing bud
    { '\x9A', 0x1F65E }, //Heavy north east pointing vine leaf
    { '\x9B', 0x1F65C }, //Heavy north west pointing vine leaf
    { '\x9C', 0x1F65D }, //Heavy south west pointing vine leaf
    { '\x9D', 0x1F65F }, //Heavy south east pointing vine leaf
    { '\x9E', 0x00B7 }, //Middle dot
    { '\x9F', 0x2022 }, //Bullet
    { '\xA0', 0x25AA }, //Black small square
    { '\xA1', 0x26AA }, //Medium white circle
    { '\xA2', 0x1F786 }, //Heavy large circle
    { '\xA3', 0x1F788 }, //Very heavy white circle
    { '\xA4', 0x25C9 }, //Fisheye
    { '\xA5', 0x25CE }, //Bullseye
    { '\xA6', 0x1F53F }, //Upper right shadowed white circle
    { '\xA7', 0x25AA }, //Black small square
    { '\xA8', 0x25FB }, //White medium square
    { '\xA9', 0x1F7C2 }, //Three pointed black star
    { '\xAA', 0x2726 }, //Black four pointed star
    { '\xAB', 0x2605 }, //Black star
    { '\xAC', 0x2736 }, //Six pointed black star
    { '\xAD', 0x2734 }, //Eight pointed black star
    { '\xAE', 0x2739 }, //Twelve pointed black star
    { '\xAF', 0x2735 }, //Eight pointed pinwheel star
    { '\xB0', 0x2BD0 }, //Square position indicator
    { '\xB1', 0x2316 }, //Position indicator
    { '\xB2', 0x27E1 }, //White concave-sided diamond
    { '\xB3', 0x2311 }, //Square lozenge
    { '\xB4', 0x2BD1 }, //Uncertainty sign
    { '\xB5', 0x272A }, //Circled white star
    { '\xB6', 0x2730 }, //Shadowed white star
    { '\xB7', 0x1F550 }, //Clock face one oclock
    { '\xB8', 0x1F551 }, //Clock face two oclock
    { '\xB9', 0x1F552 }, //Clock face three oclock
    { '\xBA', 0x1F553 }, //Clock face four oclock
    { '\xBB', 0x1F554 }, //Clock face five oclock
    { '\xBC', 0x1F555 }, //Clock face six oclock
    { '\xBD', 0x1F556 }, //Clock face seven oclock
    { '\xBE', 0x1F557 }, //Clock face eight oclock
    { '\xBF', 0x1F558 }, //Clock face nine oclock
    { '\xC0', 0x1F559 }, //Clock face ten oclock
    { '\xC1', 0x1F55A }, //Clock face eleven oclock
    { '\xC2', 0x1F55B }, //Clock face twelve oclock
    { '\xC3', 0x2BB0 }, //Ribbon arrow down left
    { '\xC4', 0x2BB1 }, //Ribbon arrow down right
    { '\xC5', 0x2BB2 }, //Ribbon arrow up left
    { '\xC6', 0x2BB3 }, //Ribbon arrow up right
    { '\xC7', 0x2BB4 }, //Ribbon arrow left up
    { '\xC8', 0x2BB5 }, //Ribbon arrow right up
    { '\xC9', 0x2BB6 }, //Ribbon arrow left down
    { '\xCA', 0x2BB7 }, //Ribbon arrow right down
    { '\xCB', 0x1F66A }, //Solid quilt square ornament
    { '\xCC', 0x1F66B }, //Solid quilt square ornament in black square
    { '\xCD', 0x1F655 }, //Turned south west pointing leaf
    { '\xCE', 0x1F654 }, //Turned north west pointing leaf
    { '\xCF', 0x1F657 }, //Turned south east pointing leaf
    { '\xD0', 0x1F656 }, //Turned north east pointing leaf
    { '\xD1', 0x1F650 }, //North west pointing leaf
    { '\xD2', 0x1F651 }, //South west pointing leaf
    { '\xD3', 0x1F652 }, //North east pointing leaf
    { '\xD4', 0x1F653 }, //South east pointing leaf
    { '\xD5', 0x232B }, //Erase to the left
    { '\xD6', 0x2326 }, //Erase to the right
    { '\xD7', 0x2B98 }, //Three-D top-lighted leftwards equilateral arrowhead
    { '\xD8', 0x2B9A }, //Three-D top-lighted rightwards equilateral arrowhead
    { '\xD9', 0x2B99 }, //Three-D right-lighted upwards equilateral arrowhead
    { '\xDA', 0x2B9B }, //Three-D left-lighted downwards equilateral arrowhead
    { '\xDB', 0x2B88 }, //Leftwards black circled white arrow
    { '\xDC', 0x2B8A }, //Rightwards black circled white arrow
    { '\xDD', 0x2B89 }, //Upwards black circled white arrow
    { '\xDE', 0x2B8B }, //Downwards black circled white arrow
    { '\xDF', 0x1F868 }, //Wide-headed leftwards barb arrow
    { '\xE0', 0x1F86A }, //Wide-headed rightwards barb arrow
    { '\xE1', 0x1F869 }, //Wide-headed upwards barb arrow
    { '\xE2', 0x1F86B }, //Wide-headed downwards barb arrow
    { '\xE3', 0x1F86C }, //Wide-headed north west barb arrow
    { '\xE4', 0x1F86D }, //Wide-headed north east barb arrow
    { '\xE5', 0x1F86F }, //Wide-headed south west barb arrow
    { '\xE6', 0x1F86E }, //Wide-headed south east barb arrow
    { '\xE7', 0x1F878 }, //Wide-headed leftwards heavy barb arrow
    { '\xE8', 0x1F87A }, //Wide-headed rightwards heavy barb arrow
    { '\xE9', 0x1F879 }, //Wide-headed upwards heavy barb arrow
    { '\xEA', 0x1F87B }, //Wide-headed downwards heavy barb arrow
    { '\xEB', 0x1F87C }, //Wide-headed north west heavy barb arrow
    { '\xEC', 0x1F87D }, //Wide-headed north east heavy barb arrow
    { '\xED', 0x1F87F }, //Wide-headed south west heavy barb arrow
    { '\xEE', 0x1F87E }, //Wide-headed south east heavy barb arrow
    { '\xEF', 0x21E6 }, //Leftwards white arrow
    { '\xF0', 0x21E8 }, //Rightwards white arrow
    { '\xF1', 0x21E7 }, //Upwards white arrow
    { '\xF2', 0x21E9 }, //Downwards white arrow
    { '\xF3', 0x2B04 }, //Left right white arrow
    { '\xF4', 0x21F3 }, //Up down white arrow
    { '\xF5', 0x2B00 }, //North east white arrow
    { '\xF6', 0x2B01 }, //North west white arrow
    { '\xF7', 0x2B03 }, //South west white arrow
    { '\xF8', 0x2B02 }, //South east white arrow
    { '\xF9', 0x1F8AC }, //White arrow shaft width one
    { '\xFA', 0x1F8AD }, //White arrow shaft width two thirds
    { '\xFB', 0x1F5F6 }, //Ballot bold script X
    { '\xFC', 0x2714 }, //Heavy check mark
    { '\xFD', 0x1F5F7 }, //Ballot box with bold script X
    { '\xFE', 0x1F5F9 }, //Ballot box with bold check
  };

  public static char DecodeWingdingsCharset(this char ch)
  {
    if (ch >= '\uF000' && ch <= '\uF0FF')
      ch = (char)(ch - '\uF000');
    if (WingdingsCharset.TryGetValue(ch, out var code))
      if (code<=0xFFFFFF)
        return (char)code;
    return ch;
  }
  #endregion

  #region Webdings charset
  public static string DecodeWebdingsCharset(this string str)
  {
    char[] chars = str.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
      chars[i] = DecodeWebdingsCharset(chars[i]);
    }
    str = new string(chars);
    return str;
  }

  private static Dictionary<char, int> WebdingsCharset = new Dictionary<char, int>
  {
    { '\x20', 0x20 }, //SP
    { '\x21', 0x1F577  }, //🕷
    { '\x22', 0x1F578  }, //🕸
    { '\x23', 0x1F572  }, //🕲
    { '\x24', 0x1F576  }, //🕶
    { '\x25', 0x1F3C6  }, //🏆︎
    { '\x26', 0x1F396  }, //🎖
    { '\x27', 0x1F587  }, //🖇
    { '\x28', 0x1F5E8 }, //🗨
    { '\x29', 0x1F5E9  }, //🗩
    { '\x2A', 0x1F5F0  }, //🗰
    { '\x2B', 0x1F5F1  }, //🗱
    { '\x2C', 0x1F336  }, //🌶
    { '\x2D', 0x1F397  }, //🎗
    { '\x2E', 0x1F67E  }, //🙾
    { '\x2F', 0x1F67C  }, //🙼
    { '\x30', 0x1F5D5  }, //🗕
    { '\x31', 0x1F5D6  }, //🗖
    { '\x32', 0x1F5D7  }, //🗗
    { '\x33', 0x23F4  }, //⏴
    { '\x34', 0x23F5  }, //⏵
    { '\x35', 0x23F6  }, //⏶
    { '\x36', 0x23F7  }, //⏷
    { '\x37', 0x23EA  }, //⏪︎
    { '\x38', 0x23E9 }, //⏩︎
    { '\x39', 0x23EE  }, //⏮
    { '\x3A', 0x23ED  }, //⏭
    { '\x3B', 0x23F8  }, //⏸
    { '\x3C', 0x23F9  }, //⏹
    { '\x3D', 0x23FA  }, //⏺
    { '\x3E', 0x1F5DA  }, //🗚
    { '\x3F', 0x1F5F3  }, //🗳
    { '\x40', 0x1F6E0  }, //🛠
    { '\x41', 0x1F3D7  }, //🏗
    { '\x42', 0x1F3D8  }, //🏘
    { '\x43', 0x1F3D9  }, //🏙
    { '\x44', 0x1F3DA  }, //🏚
    { '\x45', 0x1F3DC  }, //🏜
    { '\x46', 0x1F3ED  }, //🏭︎
    { '\x47', 0x1F3DB  }, //🏛
    { '\x48', 0x1F3E0  }, //🏠︎
    { '\x49', 0x1F3D6  }, //🏖
    { '\x4A', 0x1F3DD  }, //🏝
    { '\x4B', 0x1F6E3  }, //🛣
    { '\x4C', 0x1F50D  }, //🔍︎
    { '\x4D', 0x1F3D4  }, //🏔
    { '\x4E', 0x1F441  }, //👁
    { '\x4F', 0x1F442  }, //👂︎
    { '\x50', 0x1F3DE  }, //🏞
    { '\x51', 0x1F3D5  }, //🏕
    { '\x52', 0x1F6E4  }, //🛤
    { '\x53', 0x1F3DF  }, //🏟
    { '\x54', 0x1F6F3  }, //🛳
    { '\x55', 0x1F56C  }, //🕬
    { '\x56', 0x1F56B  }, //🕫
    { '\x57', 0x1F568  }, //🕨
    { '\x58', 0x1F508  }, //🔈︎
    { '\x59', 0x1F394  }, //🎔
    { '\x5A', 0x1F395  }, //🎕
    { '\x5B', 0x1F5EC  }, //🗬
    { '\x5C', 0x1F67D  }, //🙽
    { '\x5D', 0x1F5ED  }, //🗭
    { '\x5E', 0x1F5EA  }, //🗪
    { '\x5F', 0x1F5EB  }, //🗫
    { '\x60', 0x2B94  }, //⮔
    { '\x61', 0x2714 }, //✔
    { '\x62', 0x1F6B2  }, //🚲︎
    { '\x63', 0x2B1C  }, //⬜︎
    { '\x64', 0x1F6E1  }, //🛡
    { '\x65', 0x1F4E6  }, //📦︎
    { '\x66', 0x1F6F1  }, //🛱
    { '\x67', 0x2B1B  }, //⬛︎
    { '\x68', 0x1F691  }, //🚑︎
    { '\x69', 0x1F6C8  }, //🛈
    { '\x6A', 0x1F6E9  }, //🛩
    { '\x6B', 0x1F6F0  }, //🛰
    { '\x6C', 0x1F7C8  }, //🟈
    { '\x6D', 0x1F574  }, //🕴
    { '\x6E', 0x2B24  }, //⬤
    { '\x6F', 0x1F6E5  }, //🛥
    { '\x70', 0x1F694  }, //🚔︎
    { '\x71', 0x1F5D8  }, //🗘
    { '\x72', 0x1F5D9  }, //🗙
    { '\x73', 0x2753 }, //❓︎
    { '\x74', 0x1F6F2  }, //🛲
    { '\x75', 0x1F687  }, //🚇︎
    { '\x76', 0x1F68D  }, //🚍︎
    { '\x77', 0x26F3  }, //⛳︎
    { '\x78', 0x29B8  }, //⦸
    { '\x79', 0x2296 }, //⊖
    { '\x7A', 0x1F6AD  }, //🚭︎
    { '\x7B', 0x1F5EE  }, //🗮
    { '\x7C', 0x23D0  }, //⏐
    { '\x7D', 0x1F5EF  }, //🗯
    { '\x7E', 0x1F5F2  }, //🗲
    { '\x80', 0x1F6B9  }, //🚹︎
    { '\x81', 0x1F6BA  }, //🚺︎
    { '\x82', 0x1F6C9  }, //🛉
    { '\x83', 0x1F6CA  }, //🛊
    { '\x84', 0x1F6BC  }, //🚼︎
    { '\x85', 0x1F47D  }, //👽︎
    { '\x86', 0x1F3CB  }, //🏋
    { '\x87', 0x26F7  }, //⛷
    { '\x88', 0x1F3C2  }, //🏂︎
    { '\x89', 0x1F3CC  }, //🏌
    { '\x8A', 0x1F3CA  }, //🏊︎
    { '\x8B', 0x1F3C4  }, //🏄︎
    { '\x8C', 0x1F3CD  }, //🏍
    { '\x8D', 0x1F3CE  }, //🏎
    { '\x8E', 0x1F698  }, //🚘︎
    { '\x8F', 0x1F5E0  }, //🗠
    { '\x90', 0x1F6E2  }, //🛢
    { '\x91', 0x1F4B0  }, //💰︎
    { '\x92', 0x1F3F7  }, //🏷
    { '\x93', 0x1F4B3  }, //💳︎
    { '\x94', 0x1F46A  }, //👪︎
    { '\x95', 0x1F5E1  }, //🗡
    { '\x96', 0x1F5E2  }, //🗢
    { '\x97', 0x1F5E3  }, //🗣
    { '\x98', 0x272F  }, //✯
    { '\x99', 0x1F584  }, //🖄
    { '\x9A', 0x1F585  }, //🖅
    { '\x9B', 0x1F583  }, //🖃
    { '\x9C', 0x1F586  }, //🖆
    { '\x9D', 0x1F5B9  }, //🖹
    { '\x9E', 0x1F5BA  }, //🖺
    { '\x9F', 0x1F5BB  }, //🖻
    { '\xA0', 0x1F575  }, //🕵
    { '\xA1', 0x1F570  }, //🕰
    { '\xA2', 0x1F5BD  }, //🖽
    { '\xA3', 0x1F5BE  }, //🖾
    { '\xA4', 0x1F4CB  }, //📋︎
    { '\xA5', 0x1F5D2  }, //🗒
    { '\xA6', 0x1F5D3  }, //🗓
    { '\xA7', 0x1F56E  }, //🕮
    { '\xA8', 0x1F4DA  }, //📚︎
    { '\xA9', 0x1F5DE  }, //🗞
    { '\xAA', 0x1F5DF  }, //🗟
    { '\xAB', 0x1F5C3  }, //🗃
    { '\xAC', 0x1F5C2  }, //🗂
    { '\xAD', 0x1F5BC  }, //🖼
    { '\xAE', 0x1F3AD  }, //🎭︎
    { '\xAF', 0x1F39C  }, //🎜
    { '\xB0', 0x1F398  }, //🎘
    { '\xB1', 0x1F399  }, //🎙
    { '\xB2', 0x1F3A7  }, //🎧︎
    { '\xB3', 0x1F4BF  }, //💿︎
    { '\xB4', 0x1F39E  }, //🎞
    { '\xB5', 0x1F4F7  }, //📷︎
    { '\xB6', 0x1F39F  }, //🎟
    { '\xB7', 0x1F3AC  }, //🎬︎
    { '\xB8', 0x1F4FD  }, //📽
    { '\xB9', 0x1F4F9  }, //📹︎
    { '\xBA', 0x1F4FE  }, //📾
    { '\xBB', 0x1F4FB  }, //📻︎
    { '\xBC', 0x1F39A  }, //🎚
    { '\xBD', 0x1F39B  }, //🎛
    { '\xBE', 0x1F4FA  }, //📺︎
    { '\xBF', 0x1F4BB  }, //💻︎
    { '\xC0', 0x1F5A5  }, //🖥
    { '\xC1', 0x1F5A6  }, //🖦
    { '\xC2', 0x1F5A7  }, //🖧
    { '\xC3', 0x1F579  }, //🕹
    { '\xC4', 0x1F3AE  }, //🎮︎
    { '\xC5', 0x1F57B  }, //🕻
    { '\xC6', 0x1F57C  }, //🕼
    { '\xC7', 0x1F4DF  }, //📟︎
    { '\xC8', 0x1F581  }, //🖁
    { '\xC9', 0x1F580  }, //🖀
    { '\xCA', 0x1F5A8  }, //🖨
    { '\xCB', 0x1F5A9  }, //🖩
    { '\xCC', 0x1F5BF  }, //🖿
    { '\xCD', 0x1F5AA  }, //🖪
    { '\xCE', 0x1F5DC  }, //🗜
    { '\xCF', 0x1F512  }, //🔒︎
    { '\xD0', 0x1F513  }, //🔓︎
    { '\xD1', 0x1F5DD  }, //🗝
    { '\xD2', 0x1F4E5  }, //📥︎
    { '\xD3', 0x1F4E4  }, //📤︎
    { '\xD4', 0x1F573  }, //🕳
    { '\xD5', 0x1F323  }, //🌣
    { '\xD6', 0x1F324  }, //🌤
    { '\xD7', 0x1F325  }, //🌥
    { '\xD8', 0x1F326  }, //🌦
    { '\xD9', 0x2601 }, //☁
    { '\xDA', 0x1F328  }, //🌨
    { '\xDB', 0x1F327  }, //🌧
    { '\xDC', 0x1F329  }, //🌩
    { '\xDD', 0x1F32A  }, //🌪
    { '\xDE', 0x1F32C  }, //🌬
    { '\xDF', 0x1F32B  }, //🌫
    { '\xE0', 0x1F31C  }, //🌜︎
    { '\xE1', 0x1F321  }, //🌡
    { '\xE2', 0x1F6CB  }, //🛋
    { '\xE3', 0x1F6CF  }, //🛏
    { '\xE4', 0x1F37D  }, //🍽
    { '\xE5', 0x1F378  }, //🍸︎
    { '\xE6', 0x1F6CE  }, //🛎
    { '\xE7', 0x1F6CD  }, //🛍
    { '\xE8', 0x24C5  }, //Ⓟ
    { '\xE9', 0x267F  }, //♿︎
    { '\xEA', 0x1F6C6  }, //🛆
    { '\xEB', 0x1F588  }, //🖈
    { '\xEC', 0x1F393  }, //🎓︎
    { '\xED', 0x1F5E4  }, //🗤
    { '\xEE', 0x1F5E5  }, //🗥
    { '\xEF', 0x1F5E6  }, //🗦
    { '\xF0', 0x1F5E7  }, //🗧
    { '\xF1', 0x1F6EA  }, //🛪
    { '\xF2', 0x1F43F  }, //🐿
    { '\xF3', 0x1F426  }, //🐦︎
    { '\xF4', 0x1F41F  }, //🐟︎
    { '\xF5', 0x1F415  }, //🐕︎
    { '\xF6', 0x1F408  }, //🐈︎
    { '\xF7', 0x1F66C  }, //🙬
    { '\xF8', 0x1F66E  }, //🙮
    { '\xF9', 0x1F66D  }, //🙭
    { '\xFA', 0x1F66F  }, //🙯
    { '\xFB', 0x1F5FA  }, //🗺
    { '\xFC', 0x1F30D  }, //🌍︎
    { '\xFD', 0x1F30F  }, //🌏︎
    { '\xFE', 0x1F30E  }, //🌎︎
    { '\xFF', 0x1F54A }, //🕊

  };

  public static char DecodeWebdingsCharset(this char ch)
  {
    if (ch >= '\uF000' && ch <= '\uF0FF')
      ch = (char)(ch - '\uF000');
    if (WebdingsCharset.TryGetValue(ch, out var code))
      if (code <= 0xFFFFFF)
        return (char)code;
    return ch;
  }
  #endregion

}