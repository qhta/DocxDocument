namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoreflectiontype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoReflectionType")]
public enum ReflectionType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionTypeMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionTypeNone")]
  None = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType1")]
  Type1 = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType2")]
  Type2 = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType3")]
  Type3 = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType4")]
  Type4 = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType5")]
  Type5 = 5,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType6")]
  Type6 = 6,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType7")]
  Type7 = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType8")]
  Type8 = 8,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoReflectionType9")]
  Type9 = 9,
}
