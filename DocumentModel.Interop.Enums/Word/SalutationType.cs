namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of salutation to use for a letter.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsalutationtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSalutationType")]
public enum SalutationType
{
  /// <summary>
  /// Informal salutation.
  /// </summary>
  [InteropEnumValue("wdSalutationInformal")]
  Informal = 0,
  /// <summary>
  /// Format salutation.
  /// </summary>
  [InteropEnumValue("wdSalutationFormal")]
  Formal = 1,
  /// <summary>
  /// Business salutation
  /// </summary>
  [InteropEnumValue("wdSalutationBusiness")]
  Business = 2,
  /// <summary>
  /// Custom salutation.
  /// </summary>
  [InteropEnumValue("wdSalutationOther")]
  Other = 3
}
