namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a file or folder path.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopathformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPathFormat")]
public enum PathFormat
{
  /// <summary>
  /// Represents a mixed format.
  /// </summary>
  [InteropEnumValue("msoPathTypeMixed")]
  Mixed = -2,
  /// <summary>
  /// Represents no format.
  /// </summary>
  [InteropEnumValue("msoPathTypeNone")]
  None = 0,
  /// <summary>
  /// Represents the Type1 format.
  /// </summary>
  [InteropEnumValue("msoPathType1")]
  Type1 = 1,
  /// <summary>
  /// Represents the Type2 format.
  /// </summary>
  [InteropEnumValue("msoPathType2")]
  Type2 = 2,
  /// <summary>
  /// Represents the Type3 format.
  /// </summary>
  [InteropEnumValue("msoPathType3")]
  Type3 = 3,
  /// <summary>
  /// Represents the Type4 format.
  /// </summary>
  [InteropEnumValue("msoPathType4")]
  Type4 = 4
}
