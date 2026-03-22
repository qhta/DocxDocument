namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
/// values in a character encoding map, they share a single constant in this enumeration.
/// </summary>
public enum WdKey
{
  /// <summary>
  /// The BACKSPACE key.
  /// </summary>
  wdKeyBackspace = unchecked((int)8),
  /// <summary>
  /// The TAB key.
  /// </summary>
  wdKeyTab = unchecked((int)9),
  /// <summary>
  /// .
  /// </summary>
  wdKeyNumeric5Special = unchecked((int)12),
  /// <summary>
  /// The ENTER or RETURN key.
  /// </summary>
  wdKeyReturn = unchecked((int)13),
  /// <summary>
  /// The PAUSE key.
  /// </summary>
  wdKeyPause = unchecked((int)19),
  /// <summary>
  /// The ESC key.
  /// </summary>
  wdKeyEsc = unchecked((int)27),
  /// <summary>
  /// The SPACEBAR key.
  /// </summary>
  wdKeySpacebar = unchecked((int)32),
  /// <summary>
  /// The PAGE UP key.
  /// </summary>
  wdKeyPageUp = unchecked((int)33),
  /// <summary>
  /// The PAGE DOWN key.
  /// </summary>
  wdKeyPageDown = unchecked((int)34),
  /// <summary>
  /// The END key. [System.Runtime.InteropServices.Guid("0641128D-0872-3E67-9991-E962AB36BAF2")] public enum WdKey ﾉ
  /// Expand table
  /// </summary>
  wdKeyEnd = unchecked((int)35),
  /// <summary>
  /// The HOME key.
  /// </summary>
  wdKeyHome = unchecked((int)36),
  /// <summary>
  /// The INSERT key.
  /// </summary>
  wdKeyInsert = unchecked((int)45),
  /// <summary>
  /// The DELETE key.
  /// </summary>
  wdKeyDelete = unchecked((int)46),
  /// <summary>
  /// The 0 key.
  /// </summary>
  wdKey0 = unchecked((int)48),
  /// <summary>
  /// The 1 key.
  /// </summary>
  wdKey1 = unchecked((int)49),
  /// <summary>
  /// The 2 key.
  /// </summary>
  wdKey2 = unchecked((int)50),
  /// <summary>
  /// The 3 key.
  /// </summary>
  wdKey3 = unchecked((int)51),
  /// <summary>
  /// The 4 key.
  /// </summary>
  wdKey4 = unchecked((int)52),
  /// <summary>
  /// The 5 key.
  /// </summary>
  wdKey5 = unchecked((int)53),
  /// <summary>
  /// The 6 key.
  /// </summary>
  wdKey6 = unchecked((int)54),
  /// <summary>
  /// The 7 key.
  /// </summary>
  wdKey7 = unchecked((int)55),
  /// <summary>
  /// The 8 key.
  /// </summary>
  wdKey8 = unchecked((int)56),
  /// <summary>
  /// The 9 key.
  /// </summary>
  wdKey9 = unchecked((int)57),
  /// <summary>
  /// The A key.
  /// </summary>
  wdKeyA = unchecked((int)65),
  /// <summary>
  /// The B key.
  /// </summary>
  wdKeyB = unchecked((int)66),
  /// <summary>
  /// The C key.
  /// </summary>
  wdKeyC = unchecked((int)67),
  /// <summary>
  /// The D key.
  /// </summary>
  wdKeyD = unchecked((int)68),
  /// <summary>
  /// The E key.
  /// </summary>
  wdKeyE = unchecked((int)69),
  /// <summary>
  /// The F key.
  /// </summary>
  wdKeyF = unchecked((int)70),
  /// <summary>
  /// The G key.
  /// </summary>
  wdKeyG = unchecked((int)71),
  /// <summary>
  /// The H key.
  /// </summary>
  wdKeyH = unchecked((int)72),
  /// <summary>
  /// The I key.
  /// </summary>
  wdKeyI = unchecked((int)73),
  /// <summary>
  /// The J key.
  /// </summary>
  wdKeyJ = unchecked((int)74),
  /// <summary>
  /// The K key.
  /// </summary>
  wdKeyK = unchecked((int)75),
  /// <summary>
  /// The L key.
  /// </summary>
  wdKeyL = unchecked((int)76),
  /// <summary>
  /// The M key.
  /// </summary>
  wdKeyM = unchecked((int)77),
  /// <summary>
  /// The N key.
  /// </summary>
  wdKeyN = unchecked((int)78),
  /// <summary>
  /// The O key.
  /// </summary>
  wdKeyO = unchecked((int)79),
  /// <summary>
  /// The P key.
  /// </summary>
  wdKeyP = unchecked((int)80),
  /// <summary>
  /// The Q key.
  /// </summary>
  wdKeyQ = unchecked((int)81),
  /// <summary>
  /// The R key.
  /// </summary>
  wdKeyR = unchecked((int)82),
  /// <summary>
  /// The S key.
  /// </summary>
  wdKeyS = unchecked((int)83),
  /// <summary>
  /// The T key.
  /// </summary>
  wdKeyT = unchecked((int)84),
  /// <summary>
  /// The U key.
  /// </summary>
  wdKeyU = unchecked((int)85),
  /// <summary>
  /// The V key.
  /// </summary>
  wdKeyV = unchecked((int)86),
  /// <summary>
  /// The W key.
  /// </summary>
  wdKeyW = unchecked((int)87),
  /// <summary>
  /// The X key.
  /// </summary>
  wdKeyX = unchecked((int)88),
  /// <summary>
  /// The Y key.
  /// </summary>
  wdKeyY = unchecked((int)89),
  /// <summary>
  /// The Z key.
  /// </summary>
  wdKeyZ = unchecked((int)90),
  /// <summary>
  /// The 0 key.
  /// </summary>
  wdKeyNumeric0 = unchecked((int)96),
  /// <summary>
  /// The 1 key.
  /// </summary>
  wdKeyNumeric1 = unchecked((int)97),
  /// <summary>
  /// The 2 key.
  /// </summary>
  wdKeyNumeric2 = unchecked((int)98),
  /// <summary>
  /// The 3 key.
  /// </summary>
  wdKeyNumeric3 = unchecked((int)99),
  /// <summary>
  /// The 4 key.
  /// </summary>
  wdKeyNumeric4 = unchecked((int)100),
  /// <summary>
  /// The 5 key.
  /// </summary>
  wdKeyNumeric5 = unchecked((int)101),
  /// <summary>
  /// The 6 key.
  /// </summary>
  wdKeyNumeric6 = unchecked((int)102),
  /// <summary>
  /// The 7 key.
  /// </summary>
  wdKeyNumeric7 = unchecked((int)103),
  /// <summary>
  /// The 8 key.
  /// </summary>
  wdKeyNumeric8 = unchecked((int)104),
  /// <summary>
  /// The 9 key.
  /// </summary>
  wdKeyNumeric9 = unchecked((int)105),
  /// <summary>
  /// The * key on the numeric keypad.
  /// </summary>
  wdKeyNumericMultiply = unchecked((int)106),
  /// <summary>
  /// The + key on the numeric keypad.
  /// </summary>
  wdKeyNumericAdd = unchecked((int)107),
  /// <summary>
  /// The - key on the numeric keypad.
  /// </summary>
  wdKeyNumericSubtract = unchecked((int)109),
  /// <summary>
  /// The . key on the numeric keypad.
  /// </summary>
  wdKeyNumericDecimal = unchecked((int)110),
  /// <summary>
  /// The / key on the numeric keypad.
  /// </summary>
  wdKeyNumericDivide = unchecked((int)111),
  /// <summary>
  /// The F1 key.
  /// </summary>
  wdKeyF1 = unchecked((int)112),
  /// <summary>
  /// The F2 key.
  /// </summary>
  wdKeyF2 = unchecked((int)113),
  /// <summary>
  /// The F3 key.
  /// </summary>
  wdKeyF3 = unchecked((int)114),
  /// <summary>
  /// The F4 key.
  /// </summary>
  wdKeyF4 = unchecked((int)115),
  /// <summary>
  /// The F5 key.
  /// </summary>
  wdKeyF5 = unchecked((int)116),
  /// <summary>
  /// The F6 key.
  /// </summary>
  wdKeyF6 = unchecked((int)117),
  /// <summary>
  /// The F7 key.
  /// </summary>
  wdKeyF7 = unchecked((int)118),
  /// <summary>
  /// The F8 key.
  /// </summary>
  wdKeyF8 = unchecked((int)119),
  /// <summary>
  /// The F9 key.
  /// </summary>
  wdKeyF9 = unchecked((int)120),
  /// <summary>
  /// The F10 key.
  /// </summary>
  wdKeyF10 = unchecked((int)121),
  /// <summary>
  /// The F11 key.
  /// </summary>
  wdKeyF11 = unchecked((int)122),
  /// <summary>
  /// The F12 key.
  /// </summary>
  wdKeyF12 = unchecked((int)123),
  /// <summary>
  /// The F13 key.
  /// </summary>
  wdKeyF13 = unchecked((int)124),
  /// <summary>
  /// The F14 key.
  /// </summary>
  wdKeyF14 = unchecked((int)125),
  /// <summary>
  /// The F15 key.
  /// </summary>
  wdKeyF15 = unchecked((int)126),
  /// <summary>
  /// The F16 key.
  /// </summary>
  wdKeyF16 = unchecked((int)127),
  /// <summary>
  /// The SCROLL LOCK key.
  /// </summary>
  wdKeyScrollLock = unchecked((int)145),
  /// <summary>
  /// The ; key.
  /// </summary>
  wdKeySemiColon = unchecked((int)186),
  /// <summary>
  /// The = key.
  /// </summary>
  wdKeyEquals = unchecked((int)187),
  /// <summary>
  /// The , key.
  /// </summary>
  wdKeyComma = unchecked((int)188),
  /// <summary>
  /// The - key.
  /// </summary>
  wdKeyHyphen = unchecked((int)189),
  /// <summary>
  /// The . key.
  /// </summary>
  wdKeyPeriod = unchecked((int)190),
  /// <summary>
  /// The / key. wdKeyBackSingleQuote192 The ` key. wdKeyOpenSquareBrace219 The [ key.
  /// </summary>
  wdKeySlash = unchecked((int)191),
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  wdKeyBackSingleQuote = unchecked((int)192),
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  wdKeyOpenSquareBrace = unchecked((int)219),
  /// <summary>
  /// The \ key. wdKeyCloseSquareBrace221 The ] key.
  /// </summary>
  wdKeyBackSlash = unchecked((int)220),
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  wdKeyCloseSquareBrace = unchecked((int)221),
  /// <summary>
  /// The ' key.
  /// </summary>
  wdKeySingleQuote = unchecked((int)222),
  /// <summary>
  /// No key.
  /// </summary>
  wdNoKey = unchecked((int)255),
  /// <summary>
  /// The SHIFT key.
  /// </summary>
  wdKeyShift = unchecked((int)256),
  /// <summary>
  /// The CTRL key.
  /// </summary>
  wdKeyControl = unchecked((int)512),
  /// <summary>
  /// The Windows command key or Macintosh COMMAND key.
  /// </summary>
  wdKeyCommand = unchecked((int)512),
  /// <summary>
  /// The mouse option key or Macintosh OPTION key.
  /// </summary>
  wdKeyOption = unchecked((int)1024),
  /// <summary>
  /// The ALT key.
  /// </summary>
  wdKeyAlt = unchecked((int)1024)
}
