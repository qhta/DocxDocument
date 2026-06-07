namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the Spanish speller modes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspanishspeller?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSpanishSpeller")]
public enum SpanishSpeller
{
  /// <summary>
  /// The Spanish spelling checker recognizes only tuteo verb forms.
  /// </summary>
  [InteropEnumValue("wdSpanishTuteoOnly")]
  TuteoOnly = 0,
  /// <summary>
  /// The Spanish spelling checker recognizes both tuteo and voseo verb forms.
  /// </summary>
  [InteropEnumValue("wdSpanishTuteoAndVoseo")]
  TuteoAndVoseo = 1,
  /// <summary>
  /// The Spanish spelling checker recognizes only voseo verb forms.
  /// </summary>
  [InteropEnumValue("wdSpanishVoseoOnly")]
  VoseoOnly = 2
}
