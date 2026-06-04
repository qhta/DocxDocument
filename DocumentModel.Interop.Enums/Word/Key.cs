namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a keyboard character. Although uppercase and lowercase characters are designated by using different
/// values in a character encoding map, they share a single constant in this enumeration.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdkey?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdKey))]
public enum Key
{
  /// <summary>
  /// The BACKSPACE key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyBackspace))]
  KeyBackspace = 8,
  /// <summary>
  /// The TAB key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyTab))]
  KeyTab = 9,
  /// <summary>
  /// The numeric 5 special key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric5Special))]
  KeyNumeric5Special = 12,
  /// <summary>
  /// The ENTER or RETURN key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyReturn))]
  KeyReturn = 13,
  /// <summary>
  /// The PAUSE key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyPause))]
  KeyPause = 19,
  /// <summary>
  /// The ESC key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyEsc))]
  KeyEsc = 27,
  /// <summary>
  /// The SPACEBAR key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeySpacebar))]
  KeySpacebar = 32,
  /// <summary>
  /// The PAGE UP key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyPageUp))]
  KeyPageUp = 33,
  /// <summary>
  /// The PAGE DOWN key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyPageDown))]
  KeyPageDown = 34,
  /// <summary>
  /// The END key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyEnd))]
  KeyEnd = 35,
  /// <summary>
  /// The HOME key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyHome))]
  KeyHome = 36,
  /// <summary>
  /// The INSERT key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyInsert))]
  KeyInsert = 45,
  /// <summary>
  /// The DELETE key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyDelete))]
  KeyDelete = 46,
  /// <summary>
  /// The 0 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey0))]
  Key0 = 48,
  /// <summary>
  /// The 1 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey1))]
  Key1 = 49,
  /// <summary>
  /// The 2 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey2))]
  Key2 = 50,
  /// <summary>
  /// The 3 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey3))]
  Key3 = 51,
  /// <summary>
  /// The 4 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey4))]
  Key4 = 52,
  /// <summary>
  /// The 5 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey5))]
  Key5 = 53,
  /// <summary>
  /// The 6 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey6))]
  Key6 = 54,
  /// <summary>
  /// The 7 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey7))]
  Key7 = 55,
  /// <summary>
  /// The 8 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey8))]
  Key8 = 56,
  /// <summary>
  /// The 9 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKey9))]
  Key9 = 57,
  /// <summary>
  /// The A key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyA))]
  KeyA = 65,
  /// <summary>
  /// The B key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyB))]
  KeyB = 66,
  /// <summary>
  /// The C key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyC))]
  KeyC = 67,
  /// <summary>
  /// The D key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyD))]
  KeyD = 68,
  /// <summary>
  /// The E key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyE))]
  KeyE = 69,
  /// <summary>
  /// The F key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF))]
  KeyF = 70,
  /// <summary>
  /// The G key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyG))]
  KeyG = 71,
  /// <summary>
  /// The H key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyH))]
  KeyH = 72,
  /// <summary>
  /// The I key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyI))]
  KeyI = 73,
  /// <summary>
  /// The J key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyJ))]
  KeyJ = 74,
  /// <summary>
  /// The K key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyK))]
  KeyK = 75,
  /// <summary>
  /// The L key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyL))]
  KeyL = 76,
  /// <summary>
  /// The M key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyM))]
  KeyM = 77,
  /// <summary>
  /// The N key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyN))]
  KeyN = 78,
  /// <summary>
  /// The O key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyO))]
  KeyO = 79,
  /// <summary>
  /// The P key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyP))]
  KeyP = 80,
  /// <summary>
  /// The Q key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyQ))]
  KeyQ = 81,
  /// <summary>
  /// The R key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyR))]
  KeyR = 82,
  /// <summary>
  /// The S key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyS))]
  KeyS = 83,
  /// <summary>
  /// The T key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyT))]
  KeyT = 84,
  /// <summary>
  /// The U key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyU))]
  KeyU = 85,
  /// <summary>
  /// The V key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyV))]
  KeyV = 86,
  /// <summary>
  /// The W key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyW))]
  KeyW = 87,
  /// <summary>
  /// The X key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyX))]
  KeyX = 88,
  /// <summary>
  /// The Y key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyY))]
  KeyY = 89,
  /// <summary>
  /// The Z key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyZ))]
  KeyZ = 90,
  /// <summary>
  /// The 0 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric0))]
  KeyNumeric0 = 96,
  /// <summary>
  /// The 1 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric1))]
  KeyNumeric1 = 97,
  /// <summary>
  /// The 2 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric2))]
  KeyNumeric2 = 98,
  /// <summary>
  /// The 3 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric3))]
  KeyNumeric3 = 99,
  /// <summary>
  /// The 4 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric4))]
  KeyNumeric4 = 100,
  /// <summary>
  /// The 5 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric5))]
  KeyNumeric5 = 101,
  /// <summary>
  /// The 6 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric6))]
  KeyNumeric6 = 102,
  /// <summary>
  /// The 7 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric7))]
  KeyNumeric7 = 103,
  /// <summary>
  /// The 8 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric8))]
  KeyNumeric8 = 104,
  /// <summary>
  /// The 9 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumeric9))]
  KeyNumeric9 = 105,
  /// <summary>
  /// The * key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumericMultiply))]
  KeyNumericMultiply = 106,
  /// <summary>
  /// The + key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumericAdd))]
  KeyNumericAdd = 107,
  /// <summary>
  /// The - key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumericSubtract))]
  KeyNumericSubtract = 109,
  /// <summary>
  /// The . key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumericDecimal))]
  KeyNumericDecimal = 110,
  /// <summary>
  /// The / key on the numeric keypad.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyNumericDivide))]
  KeyNumericDivide = 111,
  /// <summary>
  /// The F1 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF1))]
  KeyF1 = 112,
  /// <summary>
  /// The F2 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF2))]
  KeyF2 = 113,
  /// <summary>
  /// The F3 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF3))]
  KeyF3 = 114,
  /// <summary>
  /// The F4 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF4))]
  KeyF4 = 115,
  /// <summary>
  /// The F5 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF5))]
  KeyF5 = 116,
  /// <summary>
  /// The F6 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF6))]
  KeyF6 = 117,
  /// <summary>
  /// The F7 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF7))]
  KeyF7 = 118,
  /// <summary>
  /// The F8 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF8))]
  KeyF8 = 119,
  /// <summary>
  /// The F9 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF9))]
  KeyF9 = 120,
  /// <summary>
  /// The F10 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF10))]
  KeyF10 = 121,
  /// <summary>
  /// The F11 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF11))]
  KeyF11 = 122,
  /// <summary>
  /// The F12 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF12))]
  KeyF12 = 123,
  /// <summary>
  /// The F13 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF13))]
  KeyF13 = 124,
  /// <summary>
  /// The F14 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF14))]
  KeyF14 = 125,
  /// <summary>
  /// The F15 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF15))]
  KeyF15 = 126,
  /// <summary>
  /// The F16 key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyF16))]
  KeyF16 = 127,
  /// <summary>
  /// The SCROLL LOCK key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyScrollLock))]
  KeyScrollLock = 145,
  /// <summary>
  /// The ; key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeySemiColon))]
  KeySemiColon = 186,
  /// <summary>
  /// The = key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyEquals))]
  KeyEquals = 187,
  /// <summary>
  /// The , key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyComma))]
  KeyComma = 188,
  /// <summary>
  /// The - key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyHyphen))]
  KeyHyphen = 189,
  /// <summary>
  /// The . key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyPeriod))]
  KeyPeriod = 190,
  /// <summary>
  /// The / key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeySlash))]
  KeySlash = 191,
  /// <summary>
  /// The ` key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyBackSingleQuote))]
  KeyBackSingleQuote = 192,
  /// <summary>
  /// The [ key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyOpenSquareBrace))]
  KeyOpenSquareBrace = 219,
  /// <summary>
  /// The \ key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyBackSlash))]
  KeyBackSlash = 220,
  /// <summary>
  /// The ] key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyCloseSquareBrace))]
  KeyCloseSquareBrace = 221,
  /// <summary>
  /// The ' key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeySingleQuote))]
  KeySingleQuote = 222,
  /// <summary>
  /// No key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdNoKey))]
  NoKey = 255,
  /// <summary>
  /// The SHIFT key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyShift))]
  KeyShift = 256,
  /// <summary>
  /// The CTRL key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyControl))]
  KeyControl = 512,
  /// <summary>
  /// The Windows command key or Macintosh COMMAND key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyCommand))]
  KeyCommand = 512,
  /// <summary>
  /// The mouse option key or Macintosh OPTION key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyOption))]
  KeyOption = 1024,
  /// <summary>
  /// The ALT key.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKey.wdKeyAlt))]
  KeyAlt = 1024
}
