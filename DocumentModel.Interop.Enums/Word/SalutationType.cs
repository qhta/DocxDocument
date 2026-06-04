namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of salutation to use for a letter.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsalutationtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSalutationType")]
public enum SalutationType
{
  /// <summary>
  /// Informal salutation.
  /// </summary>
  [WordInteropEnumValue("wdSalutationInformal")]
  Informal = 0,
  /// <summary>
  /// Format salutation.
  /// </summary>
  [WordInteropEnumValue("wdSalutationFormal")]
  Formal = 1,
  /// <summary>
  /// Business salutation
  /// </summary>
  [WordInteropEnumValue("wdSalutationBusiness")]
  Business = 2,
  /// <summary>
  /// Custom salutation.
  /// </summary>
  [WordInteropEnumValue("wdSalutationOther")]
  Other = 3
}
