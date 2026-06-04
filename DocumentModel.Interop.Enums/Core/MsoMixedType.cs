namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msomixedtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoMixedType))]
public enum MixedType
{
  /// <summary>
  /// Internal use only.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMixedType.msoIntegerMixed))]
  IntegerMixed = 32768,
  /// <summary>
  /// Internal use only.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMixedType.msoSingleMixed))]
  SingleMixed = int.MinValue
}
