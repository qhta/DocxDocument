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
  KeyBackspace = 8,
  /// <summary>
  /// The TAB key.
  /// </summary>
  KeyTab = 9,
  /// <summary>
  /// .
  /// </summary>
  KeyNumeric5Special = 12,
  /// <summary>
  /// The ENTER or RETURN key.
  /// </summary>
  KeyReturn = 13,
  /// <summary>
  /// The PAUSE key.
  /// </summary>
  KeyPause = 19,
  /// <summary>
  /// The ESC key.
  /// </summary>
  KeyEsc = 27,
  /// <summary>
  /// The SPACEBAR key.
  /// </summary>
  KeySpacebar = 32,
  /// <summary>
  /// The PAGE UP key.
  /// </summary>
  KeyPageUp = 33,
  /// <summary>
  /// The PAGE DOWN key.
  /// </summary>
  KeyPageDown = 34,
  /// <summary>
  /// The END key. [System.Runtime.InteropServices.Guid("0641128D-0872-3E67-9991-E962AB36BAF2")] public enum WdKey ﾉ
  /// Expand table
  /// </summary>
  KeyEnd = 35,
  /// <summary>
  /// The HOME key.
  /// </summary>
  KeyHome = 36,
  /// <summary>
  /// The INSERT key.
  /// </summary>
  KeyInsert = 45,
  /// <summary>
  /// The DELETE key.
  /// </summary>
  KeyDelete = 46,
  /// <summary>
  /// The 0 key.
  /// </summary>
  Key0 = 48,
  /// <summary>
  /// The 1 key.
  /// </summary>
  Key1 = 49,
  /// <summary>
  /// The 2 key.
  /// </summary>
  Key2 = 50,
  /// <summary>
  /// The 3 key.
  /// </summary>
  Key3 = 51,
  /// <summary>
  /// The 4 key.
  /// </summary>
  Key4 = 52,
  /// <summary>
  /// The 5 key.
  /// </summary>
  Key5 = 53,
  /// <summary>
  /// The 6 key.
  /// </summary>
  Key6 = 54,
  /// <summary>
  /// The 7 key.
  /// </summary>
  Key7 = 55,
  /// <summary>
  /// The 8 key.
  /// </summary>
  Key8 = 56,
  /// <summary>
  /// The 9 key.
  /// </summary>
  Key9 = 57,
  /// <summary>
  /// The A key.
  /// </summary>
  KeyA = 65,
  /// <summary>
  /// The B key.
  /// </summary>
  KeyB = 66,
  /// <summary>
  /// The C key.
  /// </summary>
  KeyC = 67,
  /// <summary>
  /// The D key.
  /// </summary>
  KeyD = 68,
  /// <summary>
  /// The E key.
  /// </summary>
  KeyE = 69,
  /// <summary>
  /// The F key.
  /// </summary>
  KeyF = 70,
  /// <summary>
  /// The G key.
  /// </summary>
  KeyG = 71,
  /// <summary>
  /// The H key.
  /// </summary>
  KeyH = 72,
  /// <summary>
  /// The I key.
  /// </summary>
  KeyI = 73,
  /// <summary>
  /// The J key.
  /// </summary>
  KeyJ = 74,
  /// <summary>
  /// The K key.
  /// </summary>
  KeyK = 75,
  /// <summary>
  /// The L key.
  /// </summary>
  KeyL = 76,
  /// <summary>
  /// The M key.
  /// </summary>
  KeyM = 77,
  /// <summary>
  /// The N key.
  /// </summary>
  KeyN = 78,
  /// <summary>
  /// The O key.
  /// </summary>
  KeyO = 79,
  /// <summary>
  /// The P key.
  /// </summary>
  KeyP = 80,
  /// <summary>
  /// The Q key.
  /// </summary>
  KeyQ = 81,
  /// <summary>
  /// The R key.
  /// </summary>
  KeyR = 82,
  /// <summary>
  /// The S key.
  /// </summary>
  KeyS = 83,
  /// <summary>
  /// The T key.
  /// </summary>
  KeyT = 84,
  /// <summary>
  /// The U key.
  /// </summary>
  KeyU = 85,
  /// <summary>
  /// The V key.
  /// </summary>
  KeyV = 86,
  /// <summary>
  /// The W key.
  /// </summary>
  KeyW = 87,
  /// <summary>
  /// The X key.
  /// </summary>
  KeyX = 88,
  /// <summary>
  /// The Y key.
  /// </summary>
  KeyY = 89,
  /// <summary>
  /// The Z key.
  /// </summary>
  KeyZ = 90,
  /// <summary>
  /// The 0 key.
  /// </summary>
  KeyNumeric0 = 96,
  /// <summary>
  /// The 1 key.
  /// </summary>
  KeyNumeric1 = 97,
  /// <summary>
  /// The 2 key.
  /// </summary>
  KeyNumeric2 = 98,
  /// <summary>
  /// The 3 key.
  /// </summary>
  KeyNumeric3 = 99,
  /// <summary>
  /// The 4 key.
  /// </summary>
  KeyNumeric4 = 100,
  /// <summary>
  /// The 5 key.
  /// </summary>
  KeyNumeric5 = 101,
  /// <summary>
  /// The 6 key.
  /// </summary>
  KeyNumeric6 = 102,
  /// <summary>
  /// The 7 key.
  /// </summary>
  KeyNumeric7 = 103,
  /// <summary>
  /// The 8 key.
  /// </summary>
  KeyNumeric8 = 104,
  /// <summary>
  /// The 9 key.
  /// </summary>
  KeyNumeric9 = 105,
  /// <summary>
  /// The * key on the numeric keypad.
  /// </summary>
  KeyNumericMultiply = 106,
  /// <summary>
  /// The + key on the numeric keypad.
  /// </summary>
  KeyNumericAdd = 107,
  /// <summary>
  /// The - key on the numeric keypad.
  /// </summary>
  KeyNumericSubtract = 109,
  /// <summary>
  /// The . key on the numeric keypad.
  /// </summary>
  KeyNumericDecimal = 110,
  /// <summary>
  /// The / key on the numeric keypad.
  /// </summary>
  KeyNumericDivide = 111,
  /// <summary>
  /// The F1 key.
  /// </summary>
  KeyF1 = 112,
  /// <summary>
  /// The F2 key.
  /// </summary>
  KeyF2 = 113,
  /// <summary>
  /// The F3 key.
  /// </summary>
  KeyF3 = 114,
  /// <summary>
  /// The F4 key.
  /// </summary>
  KeyF4 = 115,
  /// <summary>
  /// The F5 key.
  /// </summary>
  KeyF5 = 116,
  /// <summary>
  /// The F6 key.
  /// </summary>
  KeyF6 = 117,
  /// <summary>
  /// The F7 key.
  /// </summary>
  KeyF7 = 118,
  /// <summary>
  /// The F8 key.
  /// </summary>
  KeyF8 = 119,
  /// <summary>
  /// The F9 key.
  /// </summary>
  KeyF9 = 120,
  /// <summary>
  /// The F10 key.
  /// </summary>
  KeyF10 = 121,
  /// <summary>
  /// The F11 key.
  /// </summary>
  KeyF11 = 122,
  /// <summary>
  /// The F12 key.
  /// </summary>
  KeyF12 = 123,
  /// <summary>
  /// The F13 key.
  /// </summary>
  KeyF13 = 124,
  /// <summary>
  /// The F14 key.
  /// </summary>
  KeyF14 = 125,
  /// <summary>
  /// The F15 key.
  /// </summary>
  KeyF15 = 126,
  /// <summary>
  /// The F16 key.
  /// </summary>
  KeyF16 = 127,
  /// <summary>
  /// The SCROLL LOCK key.
  /// </summary>
  KeyScrollLock = 145,
  /// <summary>
  /// The ; key.
  /// </summary>
  KeySemiColon = 186,
  /// <summary>
  /// The = key.
  /// </summary>
  KeyEquals = 187,
  /// <summary>
  /// The , key.
  /// </summary>
  KeyComma = 188,
  /// <summary>
  /// The - key.
  /// </summary>
  KeyHyphen = 189,
  /// <summary>
  /// The . key.
  /// </summary>
  KeyPeriod = 190,
  /// <summary>
  /// The / key. wdKeyBackSingleQuote192 The ` key. wdKeyOpenSquareBrace219 The [ key.
  /// </summary>
  KeySlash = 191,
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  KeyBackSingleQuote = 192,
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  KeyOpenSquareBrace = 219,
  /// <summary>
  /// The \ key. wdKeyCloseSquareBrace221 The ] key.
  /// </summary>
  KeyBackSlash = 220,
  /// <summary>
  /// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
  /// values in a character encoding map, they share a single constant in this enumeration.
  /// </summary>
  KeyCloseSquareBrace = 221,
  /// <summary>
  /// The ' key.
  /// </summary>
  KeySingleQuote = 222,
  /// <summary>
  /// No key.
  /// </summary>
  NoKey = 255,
  /// <summary>
  /// The SHIFT key.
  /// </summary>
  KeyShift = 256,
  /// <summary>
  /// The CTRL key.
  /// </summary>
  KeyControl = 512,
  /// <summary>
  /// The Windows command key or Macintosh COMMAND key.
  /// </summary>
  KeyCommand = 512,
  /// <summary>
  /// The mouse option key or Macintosh OPTION key.
  /// </summary>
  KeyOption = 1024,
  /// <summary>
  /// The ALT key.
  /// </summary>
  KeyAlt = 1024
}
