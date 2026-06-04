namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
/// values in a character encoding map, they share a single constant in this enumeration.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdkey?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdKey")]
public enum Key
{
  /// <summary>
  /// The BACKSPACE key.
  /// </summary>
  [InteropEnumValue("wdKeyBackspace")]
  KeyBackspace = 8,
  /// <summary>
  /// The TAB key.
  /// </summary>
  [InteropEnumValue("wdKeyTab")]
  KeyTab = 9,
  /// <summary>
  /// The numeric 5 special key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric5Special")]
  KeyNumeric5Special = 12,
  /// <summary>
  /// The ENTER or RETURN key.
  /// </summary>
  [InteropEnumValue("wdKeyReturn")]
  KeyReturn = 13,
  /// <summary>
  /// The PAUSE key.
  /// </summary>
  [InteropEnumValue("wdKeyPause")]
  KeyPause = 19,
  /// <summary>
  /// The ESC key.
  /// </summary>
  [InteropEnumValue("wdKeyEsc")]
  KeyEsc = 27,
  /// <summary>
  /// The SPACEBAR key.
  /// </summary>
  [InteropEnumValue("wdKeySpacebar")]
  KeySpacebar = 32,
  /// <summary>
  /// The PAGE UP key.
  /// </summary>
  [InteropEnumValue("wdKeyPageUp")]
  KeyPageUp = 33,
  /// <summary>
  /// The PAGE DOWN key.
  /// </summary>
  [InteropEnumValue("wdKeyPageDown")]
  KeyPageDown = 34,
  /// <summary>
  /// The END key.
  /// </summary>
  [InteropEnumValue("wdKeyEnd")]
  KeyEnd = 35,
  /// <summary>
  /// The HOME key.
  /// </summary>
  [InteropEnumValue("wdKeyHome")]
  KeyHome = 36,
  /// <summary>
  /// The INSERT key.
  /// </summary>
  [InteropEnumValue("wdKeyInsert")]
  KeyInsert = 45,
  /// <summary>
  /// The DELETE key.
  /// </summary>
  [InteropEnumValue("wdKeyDelete")]
  KeyDelete = 46,
  /// <summary>
  /// The 0 key.
  /// </summary>
  [InteropEnumValue("wdKey0")]
  Key0 = 48,
  /// <summary>
  /// The 1 key.
  /// </summary>
  [InteropEnumValue("wdKey1")]
  Key1 = 49,
  /// <summary>
  /// The 2 key.
  /// </summary>
  [InteropEnumValue("wdKey2")]
  Key2 = 50,
  /// <summary>
  /// The 3 key.
  /// </summary>
  [InteropEnumValue("wdKey3")]
  Key3 = 51,
  /// <summary>
  /// The 4 key.
  /// </summary>
  [InteropEnumValue("wdKey4")]
  Key4 = 52,
  /// <summary>
  /// The 5 key.
  /// </summary>
  [InteropEnumValue("wdKey5")]
  Key5 = 53,
  /// <summary>
  /// The 6 key.
  /// </summary>
  [InteropEnumValue("wdKey6")]
  Key6 = 54,
  /// <summary>
  /// The 7 key.
  /// </summary>
  [InteropEnumValue("wdKey7")]
  Key7 = 55,
  /// <summary>
  /// The 8 key.
  /// </summary>
  [InteropEnumValue("wdKey8")]
  Key8 = 56,
  /// <summary>
  /// The 9 key.
  /// </summary>
  [InteropEnumValue("wdKey9")]
  Key9 = 57,
  /// <summary>
  /// The A key.
  /// </summary>
  [InteropEnumValue("wdKeyA")]
  KeyA = 65,
  /// <summary>
  /// The B key.
  /// </summary>
  [InteropEnumValue("wdKeyB")]
  KeyB = 66,
  /// <summary>
  /// The C key.
  /// </summary>
  [InteropEnumValue("wdKeyC")]
  KeyC = 67,
  /// <summary>
  /// The D key.
  /// </summary>
  [InteropEnumValue("wdKeyD")]
  KeyD = 68,
  /// <summary>
  /// The E key.
  /// </summary>
  [InteropEnumValue("wdKeyE")]
  KeyE = 69,
  /// <summary>
  /// The F key.
  /// </summary>
  [InteropEnumValue("wdKeyF")]
  KeyF = 70,
  /// <summary>
  /// The G key.
  /// </summary>
  [InteropEnumValue("wdKeyG")]
  KeyG = 71,
  /// <summary>
  /// The H key.
  /// </summary>
  [InteropEnumValue("wdKeyH")]
  KeyH = 72,
  /// <summary>
  /// The I key.
  /// </summary>
  [InteropEnumValue("wdKeyI")]
  KeyI = 73,
  /// <summary>
  /// The J key.
  /// </summary>
  [InteropEnumValue("wdKeyJ")]
  KeyJ = 74,
  /// <summary>
  /// The K key.
  /// </summary>
  [InteropEnumValue("wdKeyK")]
  KeyK = 75,
  /// <summary>
  /// The L key.
  /// </summary>
  [InteropEnumValue("wdKeyL")]
  KeyL = 76,
  /// <summary>
  /// The M key.
  /// </summary>
  [InteropEnumValue("wdKeyM")]
  KeyM = 77,
  /// <summary>
  /// The N key.
  /// </summary>
  [InteropEnumValue("wdKeyN")]
  KeyN = 78,
  /// <summary>
  /// The O key.
  /// </summary>
  [InteropEnumValue("wdKeyO")]
  KeyO = 79,
  /// <summary>
  /// The P key.
  /// </summary>
  [InteropEnumValue("wdKeyP")]
  KeyP = 80,
  /// <summary>
  /// The Q key.
  /// </summary>
  [InteropEnumValue("wdKeyQ")]
  KeyQ = 81,
  /// <summary>
  /// The R key.
  /// </summary>
  [InteropEnumValue("wdKeyR")]
  KeyR = 82,
  /// <summary>
  /// The S key.
  /// </summary>
  [InteropEnumValue("wdKeyS")]
  KeyS = 83,
  /// <summary>
  /// The T key.
  /// </summary>
  [InteropEnumValue("wdKeyT")]
  KeyT = 84,
  /// <summary>
  /// The U key.
  /// </summary>
  [InteropEnumValue("wdKeyU")]
  KeyU = 85,
  /// <summary>
  /// The V key.
  /// </summary>
  [InteropEnumValue("wdKeyV")]
  KeyV = 86,
  /// <summary>
  /// The W key.
  /// </summary>
  [InteropEnumValue("wdKeyW")]
  KeyW = 87,
  /// <summary>
  /// The X key.
  /// </summary>
  [InteropEnumValue("wdKeyX")]
  KeyX = 88,
  /// <summary>
  /// The Y key.
  /// </summary>
  [InteropEnumValue("wdKeyY")]
  KeyY = 89,
  /// <summary>
  /// The Z key.
  /// </summary>
  [InteropEnumValue("wdKeyZ")]
  KeyZ = 90,
  /// <summary>
  /// The 0 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric0")]
  KeyNumeric0 = 96,
  /// <summary>
  /// The 1 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric1")]
  KeyNumeric1 = 97,
  /// <summary>
  /// The 2 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric2")]
  KeyNumeric2 = 98,
  /// <summary>
  /// The 3 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric3")]
  KeyNumeric3 = 99,
  /// <summary>
  /// The 4 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric4")]
  KeyNumeric4 = 100,
  /// <summary>
  /// The 5 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric5")]
  KeyNumeric5 = 101,
  /// <summary>
  /// The 6 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric6")]
  KeyNumeric6 = 102,
  /// <summary>
  /// The 7 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric7")]
  KeyNumeric7 = 103,
  /// <summary>
  /// The 8 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric8")]
  KeyNumeric8 = 104,
  /// <summary>
  /// The 9 key.
  /// </summary>
  [InteropEnumValue("wdKeyNumeric9")]
  KeyNumeric9 = 105,
  /// <summary>
  /// The * key on the numeric keypad.
  /// </summary>
  [InteropEnumValue("wdKeyNumericMultiply")]
  KeyNumericMultiply = 106,
  /// <summary>
  /// The + key on the numeric keypad.
  /// </summary>
  [InteropEnumValue("wdKeyNumericAdd")]
  KeyNumericAdd = 107,
  /// <summary>
  /// The - key on the numeric keypad.
  /// </summary>
  [InteropEnumValue("wdKeyNumericSubtract")]
  KeyNumericSubtract = 109,
  /// <summary>
  /// The . key on the numeric keypad.
  /// </summary>
  [InteropEnumValue("wdKeyNumericDecimal")]
  KeyNumericDecimal = 110,
  /// <summary>
  /// The / key on the numeric keypad.
  /// </summary>
  [InteropEnumValue("wdKeyNumericDivide")]
  KeyNumericDivide = 111,
  /// <summary>
  /// The F1 key.
  /// </summary>
  [InteropEnumValue("wdKeyF1")]
  KeyF1 = 112,
  /// <summary>
  /// The F2 key.
  /// </summary>
  [InteropEnumValue("wdKeyF2")]
  KeyF2 = 113,
  /// <summary>
  /// The F3 key.
  /// </summary>
  [InteropEnumValue("wdKeyF3")]
  KeyF3 = 114,
  /// <summary>
  /// The F4 key.
  /// </summary>
  [InteropEnumValue("wdKeyF4")]
  KeyF4 = 115,
  /// <summary>
  /// The F5 key.
  /// </summary>
  [InteropEnumValue("wdKeyF5")]
  KeyF5 = 116,
  /// <summary>
  /// The F6 key.
  /// </summary>
  [InteropEnumValue("wdKeyF6")]
  KeyF6 = 117,
  /// <summary>
  /// The F7 key.
  /// </summary>
  [InteropEnumValue("wdKeyF7")]
  KeyF7 = 118,
  /// <summary>
  /// The F8 key.
  /// </summary>
  [InteropEnumValue("wdKeyF8")]
  KeyF8 = 119,
  /// <summary>
  /// The F9 key.
  /// </summary>
  [InteropEnumValue("wdKeyF9")]
  KeyF9 = 120,
  /// <summary>
  /// The F10 key.
  /// </summary>
  [InteropEnumValue("wdKeyF10")]
  KeyF10 = 121,
  /// <summary>
  /// The F11 key.
  /// </summary>
  [InteropEnumValue("wdKeyF11")]
  KeyF11 = 122,
  /// <summary>
  /// The F12 key.
  /// </summary>
  [InteropEnumValue("wdKeyF12")]
  KeyF12 = 123,
  /// <summary>
  /// The F13 key.
  /// </summary>
  [InteropEnumValue("wdKeyF13")]
  KeyF13 = 124,
  /// <summary>
  /// The F14 key.
  /// </summary>
  [InteropEnumValue("wdKeyF14")]
  KeyF14 = 125,
  /// <summary>
  /// The F15 key.
  /// </summary>
  [InteropEnumValue("wdKeyF15")]
  KeyF15 = 126,
  /// <summary>
  /// The F16 key.
  /// </summary>
  [InteropEnumValue("wdKeyF16")]
  KeyF16 = 127,
  /// <summary>
  /// The SCROLL LOCK key.
  /// </summary>
  [InteropEnumValue("wdKeyScrollLock")]
  KeyScrollLock = 145,
  /// <summary>
  /// The ; key.
  /// </summary>
  [InteropEnumValue("wdKeySemiColon")]
  KeySemiColon = 186,
  /// <summary>
  /// The = key.
  /// </summary>
  [InteropEnumValue("wdKeyEquals")]
  KeyEquals = 187,
  /// <summary>
  /// The , key.
  /// </summary>
  [InteropEnumValue("wdKeyComma")]
  KeyComma = 188,
  /// <summary>
  /// The - key.
  /// </summary>
  [InteropEnumValue("wdKeyHyphen")]
  KeyHyphen = 189,
  /// <summary>
  /// The . key.
  /// </summary>
  [InteropEnumValue("wdKeyPeriod")]
  KeyPeriod = 190,
  /// <summary>
  /// The / key.
  /// </summary>
  [InteropEnumValue("wdKeySlash")]
  KeySlash = 191,
  /// <summary>
  /// The ` key.
  /// </summary>
  [InteropEnumValue("wdKeyBackSingleQuote")]
  KeyBackSingleQuote = 192,
  /// <summary>
  /// The [ key.
  /// </summary>
  [InteropEnumValue("wdKeyOpenSquareBrace")]
  KeyOpenSquareBrace = 219,
  /// <summary>
  /// The \ key.
  /// </summary>
  [InteropEnumValue("wdKeyBackSlash")]
  KeyBackSlash = 220,
  /// <summary>
  /// The ] key.
  /// </summary>
  [InteropEnumValue("wdKeyCloseSquareBrace")]
  KeyCloseSquareBrace = 221,
  /// <summary>
  /// The ' key.
  /// </summary>
  [InteropEnumValue("wdKeySingleQuote")]
  KeySingleQuote = 222,
  /// <summary>
  /// No key.
  /// </summary>
  [InteropEnumValue("wdNoKey")]
  NoKey = 255,
  /// <summary>
  /// The SHIFT key.
  /// </summary>
  [InteropEnumValue("wdKeyShift")]
  KeyShift = 256,
  /// <summary>
  /// The CTRL key.
  /// </summary>
  [InteropEnumValue("wdKeyControl")]
  KeyControl = 512,
  /// <summary>
  /// The Windows command key or Macintosh COMMAND key.
  /// </summary>
  [InteropEnumValue("wdKeyCommand")]
  KeyCommand = 512,
  /// <summary>
  /// The mouse option key or Macintosh OPTION key.
  /// </summary>
  [InteropEnumValue("wdKeyOption")]
  KeyOption = 1024,
  /// <summary>
  /// The ALT key.
  /// </summary>
  [InteropEnumValue("wdKeyAlt")]
  KeyAlt = 1024
}
