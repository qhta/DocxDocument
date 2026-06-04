namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msomixedtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoMixedType")]
public enum MixedType
{
  /// <summary>
  /// Internal use only.
  /// </summary>
  [OfficeInteropEnumValue("msoIntegerMixed")]
  IntegerMixed = 32768,
  /// <summary>
  /// Internal use only.
  /// </summary>
  [OfficeInteropEnumValue("msoSingleMixed")]
  SingleMixed = int.MinValue
}
