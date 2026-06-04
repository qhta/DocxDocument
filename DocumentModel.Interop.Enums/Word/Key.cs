namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
/// values in a character encoding map, they share a single constant in this enumeration.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdkey?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdKey")]
public enum Key
{
  /// <summary>
  /// The BACKSPACE key.
  /// </summary>
  [WordInteropEnumValue("wdKeyBackspace")]
  KeyBackspace = 8,
  /// <summary>
  /// The TAB key.
  /// </summary>
  [WordInteropEnumValue("wdKeyTab")]
  KeyTab = 9,
  /// <summary>
  /// The numeric 5 special key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric5Special")]
  KeyNumeric5Special = 12,
  /// <summary>
  /// The ENTER or RETURN key.
  /// </summary>
  [WordInteropEnumValue("wdKeyReturn")]
  KeyReturn = 13,
  /// <summary>
  /// The PAUSE key.
  /// </summary>
  [WordInteropEnumValue("wdKeyPause")]
  KeyPause = 19,
  /// <summary>
  /// The ESC key.
  /// </summary>
  [WordInteropEnumValue("wdKeyEsc")]
  KeyEsc = 27,
  /// <summary>
  /// The SPACEBAR key.
  /// </summary>
  [WordInteropEnumValue("wdKeySpacebar")]
  KeySpacebar = 32,
  /// <summary>
  /// The PAGE UP key.
  /// </summary>
  [WordInteropEnumValue("wdKeyPageUp")]
  KeyPageUp = 33,
  /// <summary>
  /// The PAGE DOWN key.
  /// </summary>
  [WordInteropEnumValue("wdKeyPageDown")]
  KeyPageDown = 34,
  /// <summary>
  /// The END key.
  /// </summary>
  [WordInteropEnumValue("wdKeyEnd")]
  KeyEnd = 35,
  /// <summary>
  /// The HOME key.
  /// </summary>
  [WordInteropEnumValue("wdKeyHome")]
  KeyHome = 36,
  /// <summary>
  /// The INSERT key.
  /// </summary>
  [WordInteropEnumValue("wdKeyInsert")]
  KeyInsert = 45,
  /// <summary>
  /// The DELETE key.
  /// </summary>
  [WordInteropEnumValue("wdKeyDelete")]
  KeyDelete = 46,
  /// <summary>
  /// The 0 key.
  /// </summary>
  [WordInteropEnumValue("wdKey0")]
  Key0 = 48,
  /// <summary>
  /// The 1 key.
  /// </summary>
  [WordInteropEnumValue("wdKey1")]
  Key1 = 49,
  /// <summary>
  /// The 2 key.
  /// </summary>
  [WordInteropEnumValue("wdKey2")]
  Key2 = 50,
  /// <summary>
  /// The 3 key.
  /// </summary>
  [WordInteropEnumValue("wdKey3")]
  Key3 = 51,
  /// <summary>
  /// The 4 key.
  /// </summary>
  [WordInteropEnumValue("wdKey4")]
  Key4 = 52,
  /// <summary>
  /// The 5 key.
  /// </summary>
  [WordInteropEnumValue("wdKey5")]
  Key5 = 53,
  /// <summary>
  /// The 6 key.
  /// </summary>
  [WordInteropEnumValue("wdKey6")]
  Key6 = 54,
  /// <summary>
  /// The 7 key.
  /// </summary>
  [WordInteropEnumValue("wdKey7")]
  Key7 = 55,
  /// <summary>
  /// The 8 key.
  /// </summary>
  [WordInteropEnumValue("wdKey8")]
  Key8 = 56,
  /// <summary>
  /// The 9 key.
  /// </summary>
  [WordInteropEnumValue("wdKey9")]
  Key9 = 57,
  /// <summary>
  /// The A key.
  /// </summary>
  [WordInteropEnumValue("wdKeyA")]
  KeyA = 65,
  /// <summary>
  /// The B key.
  /// </summary>
  [WordInteropEnumValue("wdKeyB")]
  KeyB = 66,
  /// <summary>
  /// The C key.
  /// </summary>
  [WordInteropEnumValue("wdKeyC")]
  KeyC = 67,
  /// <summary>
  /// The D key.
  /// </summary>
  [WordInteropEnumValue("wdKeyD")]
  KeyD = 68,
  /// <summary>
  /// The E key.
  /// </summary>
  [WordInteropEnumValue("wdKeyE")]
  KeyE = 69,
  /// <summary>
  /// The F key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF")]
  KeyF = 70,
  /// <summary>
  /// The G key.
  /// </summary>
  [WordInteropEnumValue("wdKeyG")]
  KeyG = 71,
  /// <summary>
  /// The H key.
  /// </summary>
  [WordInteropEnumValue("wdKeyH")]
  KeyH = 72,
  /// <summary>
  /// The I key.
  /// </summary>
  [WordInteropEnumValue("wdKeyI")]
  KeyI = 73,
  /// <summary>
  /// The J key.
  /// </summary>
  [WordInteropEnumValue("wdKeyJ")]
  KeyJ = 74,
  /// <summary>
  /// The K key.
  /// </summary>
  [WordInteropEnumValue("wdKeyK")]
  KeyK = 75,
  /// <summary>
  /// The L key.
  /// </summary>
  [WordInteropEnumValue("wdKeyL")]
  KeyL = 76,
  /// <summary>
  /// The M key.
  /// </summary>
  [WordInteropEnumValue("wdKeyM")]
  KeyM = 77,
  /// <summary>
  /// The N key.
  /// </summary>
  [WordInteropEnumValue("wdKeyN")]
  KeyN = 78,
  /// <summary>
  /// The O key.
  /// </summary>
  [WordInteropEnumValue("wdKeyO")]
  KeyO = 79,
  /// <summary>
  /// The P key.
  /// </summary>
  [WordInteropEnumValue("wdKeyP")]
  KeyP = 80,
  /// <summary>
  /// The Q key.
  /// </summary>
  [WordInteropEnumValue("wdKeyQ")]
  KeyQ = 81,
  /// <summary>
  /// The R key.
  /// </summary>
  [WordInteropEnumValue("wdKeyR")]
  KeyR = 82,
  /// <summary>
  /// The S key.
  /// </summary>
  [WordInteropEnumValue("wdKeyS")]
  KeyS = 83,
  /// <summary>
  /// The T key.
  /// </summary>
  [WordInteropEnumValue("wdKeyT")]
  KeyT = 84,
  /// <summary>
  /// The U key.
  /// </summary>
  [WordInteropEnumValue("wdKeyU")]
  KeyU = 85,
  /// <summary>
  /// The V key.
  /// </summary>
  [WordInteropEnumValue("wdKeyV")]
  KeyV = 86,
  /// <summary>
  /// The W key.
  /// </summary>
  [WordInteropEnumValue("wdKeyW")]
  KeyW = 87,
  /// <summary>
  /// The X key.
  /// </summary>
  [WordInteropEnumValue("wdKeyX")]
  KeyX = 88,
  /// <summary>
  /// The Y key.
  /// </summary>
  [WordInteropEnumValue("wdKeyY")]
  KeyY = 89,
  /// <summary>
  /// The Z key.
  /// </summary>
  [WordInteropEnumValue("wdKeyZ")]
  KeyZ = 90,
  /// <summary>
  /// The 0 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric0")]
  KeyNumeric0 = 96,
  /// <summary>
  /// The 1 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric1")]
  KeyNumeric1 = 97,
  /// <summary>
  /// The 2 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric2")]
  KeyNumeric2 = 98,
  /// <summary>
  /// The 3 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric3")]
  KeyNumeric3 = 99,
  /// <summary>
  /// The 4 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric4")]
  KeyNumeric4 = 100,
  /// <summary>
  /// The 5 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric5")]
  KeyNumeric5 = 101,
  /// <summary>
  /// The 6 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric6")]
  KeyNumeric6 = 102,
  /// <summary>
  /// The 7 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric7")]
  KeyNumeric7 = 103,
  /// <summary>
  /// The 8 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric8")]
  KeyNumeric8 = 104,
  /// <summary>
  /// The 9 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumeric9")]
  KeyNumeric9 = 105,
  /// <summary>
  /// The * key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumericMultiply")]
  KeyNumericMultiply = 106,
  /// <summary>
  /// The + key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumericAdd")]
  KeyNumericAdd = 107,
  /// <summary>
  /// The - key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumericSubtract")]
  KeyNumericSubtract = 109,
  /// <summary>
  /// The . key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumericDecimal")]
  KeyNumericDecimal = 110,
  /// <summary>
  /// The / key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue("wdKeyNumericDivide")]
  KeyNumericDivide = 111,
  /// <summary>
  /// The F1 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF1")]
  KeyF1 = 112,
  /// <summary>
  /// The F2 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF2")]
  KeyF2 = 113,
  /// <summary>
  /// The F3 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF3")]
  KeyF3 = 114,
  /// <summary>
  /// The F4 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF4")]
  KeyF4 = 115,
  /// <summary>
  /// The F5 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF5")]
  KeyF5 = 116,
  /// <summary>
  /// The F6 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF6")]
  KeyF6 = 117,
  /// <summary>
  /// The F7 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF7")]
  KeyF7 = 118,
  /// <summary>
  /// The F8 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF8")]
  KeyF8 = 119,
  /// <summary>
  /// The F9 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF9")]
  KeyF9 = 120,
  /// <summary>
  /// The F10 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF10")]
  KeyF10 = 121,
  /// <summary>
  /// The F11 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF11")]
  KeyF11 = 122,
  /// <summary>
  /// The F12 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF12")]
  KeyF12 = 123,
  /// <summary>
  /// The F13 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF13")]
  KeyF13 = 124,
  /// <summary>
  /// The F14 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF14")]
  KeyF14 = 125,
  /// <summary>
  /// The F15 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF15")]
  KeyF15 = 126,
  /// <summary>
  /// The F16 key.
  /// </summary>
  [WordInteropEnumValue("wdKeyF16")]
  KeyF16 = 127,
  /// <summary>
  /// The SCROLL LOCK key.
  /// </summary>
  [WordInteropEnumValue("wdKeyScrollLock")]
  KeyScrollLock = 145,
  /// <summary>
  /// The ; key.
  /// </summary>
  [WordInteropEnumValue("wdKeySemiColon")]
  KeySemiColon = 186,
  /// <summary>
  /// The = key.
  /// </summary>
  [WordInteropEnumValue("wdKeyEquals")]
  KeyEquals = 187,
  /// <summary>
  /// The , key.
  /// </summary>
  [WordInteropEnumValue("wdKeyComma")]
  KeyComma = 188,
  /// <summary>
  /// The - key.
  /// </summary>
  [WordInteropEnumValue("wdKeyHyphen")]
  KeyHyphen = 189,
  /// <summary>
  /// The . key.
  /// </summary>
  [WordInteropEnumValue("wdKeyPeriod")]
  KeyPeriod = 190,
  /// <summary>
  /// The / key.
  /// </summary>
  [WordInteropEnumValue("wdKeySlash")]
  KeySlash = 191,
  /// <summary>
  /// The ` key.
  /// </summary>
  [WordInteropEnumValue("wdKeyBackSingleQuote")]
  KeyBackSingleQuote = 192,
  /// <summary>
  /// The [ key.
  /// </summary>
  [WordInteropEnumValue("wdKeyOpenSquareBrace")]
  KeyOpenSquareBrace = 219,
  /// <summary>
  /// The \ key.
  /// </summary>
  [WordInteropEnumValue("wdKeyBackSlash")]
  KeyBackSlash = 220,
  /// <summary>
  /// The ] key.
  /// </summary>
  [WordInteropEnumValue("wdKeyCloseSquareBrace")]
  KeyCloseSquareBrace = 221,
  /// <summary>
  /// The ' key.
  /// </summary>
  [WordInteropEnumValue("wdKeySingleQuote")]
  KeySingleQuote = 222,
  /// <summary>
  /// No key.
  /// </summary>
  [WordInteropEnumValue("wdNoKey")]
  NoKey = 255,
  /// <summary>
  /// The SHIFT key.
  /// </summary>
  [WordInteropEnumValue("wdKeyShift")]
  KeyShift = 256,
  /// <summary>
  /// The CTRL key.
  /// </summary>
  [WordInteropEnumValue("wdKeyControl")]
  KeyControl = 512,
  /// <summary>
  /// The Windows command key or Macintosh COMMAND key.
  /// </summary>
  [WordInteropEnumValue("wdKeyCommand")]
  KeyCommand = 512,
  /// <summary>
  /// The mouse option key or Macintosh OPTION key.
  /// </summary>
  [WordInteropEnumValue("wdKeyOption")]
  KeyOption = 1024,
  /// <summary>
  /// The ALT key.
  /// </summary>
  [WordInteropEnumValue("wdKeyAlt")]
  KeyAlt = 1024
}
