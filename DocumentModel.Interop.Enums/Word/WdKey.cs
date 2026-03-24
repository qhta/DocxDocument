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
  KeyBackspace = unchecked((int)8),
  /// <summary>
  /// The TAB key.
  /// </summary>
  KeyTab = unchecked((int)9),
  /// <summary>
  /// .
  /// </summary>
  KeyNumeric5Special = unchecked((int)12),
  /// <summary>
  /// The ENTER or RETURN key.
  /// </summary>
  KeyReturn = unchecked((int)13),
  /// <summary>
  /// The PAUSE key.
  /// </summary>
  KeyPause = unchecked((int)19),
  /// <summary>
  /// The ESC key.
  /// </summary>
  KeyEsc = unchecked((int)27),
  /// <summary>
  /// The SPACEBAR key.
  /// </summary>
  KeySpacebar = unchecked((int)32),
  /// <summary>
  /// The PAGE UP key.
  /// </summary>
  KeyPageUp = unchecked((int)33),
  /// <summary>
  /// The PAGE DOWN key.
  /// </summary>
  KeyPageDown = unchecked((int)34),
  /// <summary>
  /// The END key. [System.Runtime.InteropServices.Guid("0641128D-0872-3E67-9991-E962AB36BAF2")] public enum WdKey ﾉ
  /// Expand table
  /// </summary>
  KeyEnd = unchecked((int)35),
  /// <summary>
  /// The HOME key.
  /// </summary>
  KeyHome = unchecked((int)36),
  /// <summary>
  /// The INSERT key.
  /// </summary>
  KeyInsert = unchecked((int)45),
  /// <summary>
  /// The DELETE key.
  /// </summary>
  KeyDelete = unchecked((int)46),
  /// <summary>
  /// The 0 key.
  /// </summary>
  Key0 = unchecked((int)48),
  /// <summary>
  /// The 1 key.
  /// </summary>
  Key1 = unchecked((int)49),
  /// <summary>
  /// The 2 key.
  /// </summary>
  Key2 = unchecked((int)50),
  /// <summary>
  /// The 3 key.
  /// </summary>
  Key3 = unchecked((int)51),
  /// <summary>
  /// The 4 key.
  /// </summary>
  Key4 = unchecked((int)52),
  /// <summary>
  /// The 5 key.
  /// </summary>
  Key5 = unchecked((int)53),
  /// <summary>
  /// The 6 key.
  /// </summary>
  Key6 = unchecked((int)54),
  /// <summary>
  /// The 7 key.
  /// </summary>
  Key7 = unchecked((int)55),
  /// <summary>
  /// The 8 key.
  /// </summary>
  Key8 = unchecked((int)56),
  /// <summary>
  /// The 9 key.
  /// </summary>
  Key9 = unchecked((int)57),
  /// <summary>
  /// The A key.
  /// </summary>
  KeyA = unchecked((int)65),
  /// <summary>
  /// The B key.
  /// </summary>
  KeyB = unchecked((int)66),
  /// <summary>
  /// The C key.
  /// </summary>
  KeyC = unchecked((int)67),
  /// <summary>
  /// The D key.
  /// </summary>
  KeyD = unchecked((int)68),
  /// <summary>
  /// The E key.
  /// </summary>
  KeyE = unchecked((int)69),
  /// <summary>
  /// The F key.
  /// </summary>
  KeyF = unchecked((int)70),
  /// <summary>
  /// The G key.
  /// </summary>
  KeyG = unchecked((int)71),
  /// <summary>
  /// The H key.
  /// </summary>
  KeyH = unchecked((int)72),
  /// <summary>
  /// The I key.
  /// </summary>
  KeyI = unchecked((int)73),
  /// <summary>
  /// The J key.
  /// </summary>
  KeyJ = unchecked((int)74),
  /// <summary>
  /// The K key.
  /// </summary>
  KeyK = unchecked((int)75),
  /// <summary>
  /// The L key.
  /// </summary>
  KeyL = unchecked((int)76),
  /// <summary>
  /// The M key.
  /// </summary>
  KeyM = unchecked((int)77),
  /// <summary>
  /// The N key.
  /// </summary>
  KeyN = unchecked((int)78),
  /// <summary>
  /// The O key.
  /// </summary>
  KeyO = unchecked((int)79),
  /// <summary>
  /// The P key.
  /// </summary>
  KeyP = unchecked((int)80),
  /// <summary>
  /// The Q key.
  /// </summary>
  KeyQ = unchecked((int)81),
  /// <summary>
  /// The R key.
  /// </summary>
  KeyR = unchecked((int)82),
  /// <summary>
  /// The S key.
  /// </summary>
  KeyS = unchecked((int)83),
  /// <summary>
  /// The T key.
  /// </summary>
  KeyT = unchecked((int)84),
  /// <summary>
  /// The U key.
  /// </summary>
  KeyU = unchecked((int)85),
  /// <summary>
  /// The V key.
  /// </summary>
  KeyV = unchecked((int)86),
  /// <summary>
  /// The W key.
  /// </summary>
  KeyW = unchecked((int)87),
  /// <summary>
  /// The X key.
  /// </summary>
  KeyX = unchecked((int)88),
  /// <summary>
  /// The Y key.
  /// </summary>
  KeyY = unchecked((int)89),
  /// <summary>
  /// The Z key.
  /// </summary>
  KeyZ = unchecked((int)90),
  /// <summary>
  /// The 0 key.
  /// </summary>
  KeyNumeric0 = unchecked((int)96),
  /// <summary>
  /// The 1 key.
  /// </summary>
  KeyNumeric1 = unchecked((int)97),
  /// <summary>
  /// The 2 key.
  /// </summary>
  KeyNumeric2 = unchecked((int)98),
  /// <summary>
  /// The 3 key.
  /// </summary>
  KeyNumeric3 = unchecked((int)99),
  /// <summary>
  /// The 4 key.
  /// </summary>
  KeyNumeric4 = unchecked((int)100),
  /// <summary>
  /// The 5 key.
  /// </summary>
  KeyNumeric5 = unchecked((int)101),
  /// <summary>
  /// The 6 key.
  /// </summary>
  KeyNumeric6 = unchecked((int)102),
  /// <summary>
  /// The 7 key.
  /// </summary>
  KeyNumeric7 = unchecked((int)103),
  /// <summary>
  /// The 8 key.
  /// </summary>
  KeyNumeric8 = unchecked((int)104),
  /// <summary>
  /// The 9 key.
  /// </summary>
  KeyNumeric9 = unchecked((int)105),
  /// <summary>
  /// The * key on the numeric keypad.
  /// </summary>
  KeyNumericMultiply = unchecked((int)106),
  /// <summary>
  /// The + key on the numeric keypad.
  /// </summary>
  KeyNumericAdd = unchecked((int)107),
  /// <summary>
  /// The - key on the numeric keypad.
  /// </summary>
  KeyNumericSubtract = unchecked((int)109),
  /// <summary>
  /// The . key on the numeric keypad.
  /// </summary>
  KeyNumericDecimal = unchecked((int)110),
  /// <summary>
  /// The / key on the numeric keypad.
  /// </summary>
  KeyNumericDivide = unchecked((int)111),
  /// <summary>
  /// The F1 key.
  /// </summary>
  KeyF1 = unchecked((int)112),
  /// <summary>
  /// The F2 key.
  /// </summary>
  KeyF2 = unchecked((int)113),
  /// <summary>
  /// The F3 key.
  /// </summary>
  KeyF3 = unchecked((int)114),
  /// <summary>
  /// The F4 key.
  /// </summary>
  KeyF4 = unchecked((int)115),
  /// <summary>
  /// The F5 key.
  /// </summary>
  KeyF5 = unchecked((int)116),
  /// <summary>
  /// The F6 key.
  /// </summary>
  KeyF6 = unchecked((int)117),
  /// <summary>
  /// The F7 key.
  /// </summary>
  KeyF7 = unchecked((int)118),
  /// <summary>
  /// The F8 key.
  /// </summary>
  KeyF8 = unchecked((int)119),
  /// <summary>
  /// The F9 key.
  /// </summary>
  KeyF9 = unchecked((int)120),
  /// <summary>
  /// The F10 key.
  /// </summary>
  KeyF10 = unchecked((int)121),
  /// <summary>
  /// The F11 key.
  /// </summary>
  KeyF11 = unchecked((int)122),
  /// <summary>
  /// The F12 key.
  /// </summary>
  KeyF12 = unchecked((int)123),
  /// <summary>
  /// The F13 key.
  /// </summary>
  KeyF13 = unchecked((int)124),
  /// <summary>
  /// The F14 key.
  /// </summary>
  KeyF14 = unchecked((int)125),
  /// <summary>
  /// The F15 key.
  /// </summary>
  KeyF15 = unchecked((int)126),
  /// <summary>
  /// The F16 key.
  /// </summary>
  KeyF16 = unchecked((int)127),
  /// <summary>
  /// The SCROLL LOCK key.
  /// </summary>
  KeyScrollLock = unchecked((int)145),
  /// <summary>
  /// The ; key.
  /// </summary>
  KeySemiColon = unchecked((int)186),
  /// <summary>
  /// The = key.
  /// </summary>
  KeyEquals = unchecked((int)187),
  /// <summary>
  /// The , key.
  /// </summary>
  KeyComma = unchecked((int)188),
  /// <summary>
  /// The - key.
  /// </summary>
  KeyHyphen = unchecked((int)189),
  /// <summary>
  /// The . key.
  /// </summary>
  KeyPeriod = unchecked((int)190),
  /// <summary>
  /// The / key. wdKeyBackSingleQuote192 The ` key. wdKeyOpenSquareBrace219 The [ key.
  /// </summary>
  KeySlash = unchecked((int)191),
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  KeyBackSingleQuote = unchecked((int)192),
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  KeyOpenSquareBrace = unchecked((int)219),
  /// <summary>
  /// The \ key. wdKeyCloseSquareBrace221 The ] key.
  /// </summary>
  KeyBackSlash = unchecked((int)220),
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  KeyCloseSquareBrace = unchecked((int)221),
  /// <summary>
  /// The ' key.
  /// </summary>
  KeySingleQuote = unchecked((int)222),
  /// <summary>
  /// No key.
  /// </summary>
  NoKey = unchecked((int)255),
  /// <summary>
  /// The SHIFT key.
  /// </summary>
  KeyShift = unchecked((int)256),
  /// <summary>
  /// The CTRL key.
  /// </summary>
  KeyControl = unchecked((int)512),
  /// <summary>
  /// The Windows command key or Macintosh COMMAND key.
  /// </summary>
  KeyCommand = unchecked((int)512),
  /// <summary>
  /// The mouse option key or Macintosh OPTION key.
  /// </summary>
  KeyOption = unchecked((int)1024),
  /// <summary>
  /// The ALT key.
  /// </summary>
  KeyAlt = unchecked((int)1024)
}
