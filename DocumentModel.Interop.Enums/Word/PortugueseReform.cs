namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the mode for the Brazilian or European Portuguese spellers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdportuguesereform?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPortugueseReform))]
public enum PortugueseReform
{
  /// <summary>
  /// Use the pre-reform spelling rules.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPortugueseReform.wdPortuguesePreReform))]
  PreReform = 1,
  /// <summary>
  /// Use the post-reform spelling rules.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPortugueseReform.wdPortuguesePostReform))]
  PostReform = 2,
  /// <summary>
  /// Use both the pre-reform and post-reform spelling rules.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPortugueseReform.wdPortugueseBoth))]
  Both = 3
}
