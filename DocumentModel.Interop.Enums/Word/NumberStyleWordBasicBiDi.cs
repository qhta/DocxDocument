namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnumberstylewordbasicbidi?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdNumberStyleWordBasicBiDi")]
public enum NumberStyleWordBasicBiDi
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdCaptionNumberStyleBidiLetter1")]
  CaptionNumberStyleBidiLetter1 = 49,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleBidi1")]
  ListNumberStyleBidi1 = 49,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleBidiLetter1")]
  PageNumberStyleBidiLetter1 = 49,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleBidiLetter1")]
  NoteNumberStyleBidiLetter1 = 49,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdCaptionNumberStyleBidiLetter2")]
  CaptionNumberStyleBidiLetter2 = 50,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdListNumberStyleBidi2")]
  ListNumberStyleBidi2 = 50,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdNoteNumberStyleBidiLetter2")]
  NoteNumberStyleBidiLetter2 = 50,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPageNumberStyleBidiLetter2")]
  PageNumberStyleBidiLetter2 = 50
}
