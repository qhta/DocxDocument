namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a file or folder path.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopathformat?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPathFormat))]
public enum PathFormat
{
  /// <summary>
  /// Represents a mixed format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPathFormat.msoPathTypeMixed))]
  Mixed = -2,
  /// <summary>
  /// Represents no format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPathFormat.msoPathTypeNone))]
  None = 0,
  /// <summary>
  /// Represents the Type1 format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPathFormat.msoPathType1))]
  Type1 = 1,
  /// <summary>
  /// Represents the Type2 format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPathFormat.msoPathType2))]
  Type2 = 2,
  /// <summary>
  /// Represents the Type3 format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPathFormat.msoPathType3))]
  Type3 = 3,
  /// <summary>
  /// Represents the Type4 format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPathFormat.msoPathType4))]
  Type4 = 4
}
