namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the Spanish speller modes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspanishspeller?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSpanishSpeller))]
public enum SpanishSpeller
{
  /// <summary>
  /// The Spanish spelling checker recognizes only tuteo verb forms.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpanishSpeller.wdSpanishTuteoOnly))]
  TuteoOnly = 0,
  /// <summary>
  /// The Spanish spelling checker recognizes both tuteo and voseo verb forms.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpanishSpeller.wdSpanishTuteoAndVoseo))]
  TuteoAndVoseo = 1,
  /// <summary>
  /// The Spanish spelling checker recognizes only voseo verb forms.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpanishSpeller.wdSpanishVoseoOnly))]
  VoseoOnly = 2
}
