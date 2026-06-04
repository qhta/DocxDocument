namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of salutation to use for a letter.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsalutationtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSalutationType))]
public enum SalutationType
{
  /// <summary>
  /// Informal salutation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSalutationType.wdSalutationInformal))]
  Informal = 0,
  /// <summary>
  /// Format salutation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSalutationType.wdSalutationFormal))]
  Formal = 1,
  /// <summary>
  /// Business salutation
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSalutationType.wdSalutationBusiness))]
  Business = 2,
  /// <summary>
  /// Custom salutation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSalutationType.wdSalutationOther))]
  Other = 3
}
