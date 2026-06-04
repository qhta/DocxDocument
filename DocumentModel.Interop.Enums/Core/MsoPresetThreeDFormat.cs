namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies an extrusion (three-dimensional) format.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetthreedformat?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetThreeDFormat))]
public enum PresetThreeDFormat
{
  /// <summary>
  /// Specifies an extrusion (three-dimensional) format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoPresetThreeDFormatMixed))]
  Mixed = -2,
  /// <summary>
  /// First 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD1))]
  ThreeD1 = 1,
  /// <summary>
  /// Second 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD2))]
  ThreeD2 = 2,
  /// <summary>
  /// Third 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD3))]
  ThreeD3 = 3,
  /// <summary>
  /// Fourth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD4))]
  ThreeD4 = 4,
  /// <summary>
  /// Fifth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD5))]
  ThreeD5 = 5,
  /// <summary>
  /// Sixth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD6))]
  ThreeD6 = 6,
  /// <summary>
  /// Seventh 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD7))]
  ThreeD7 = 7,
  /// <summary>
  /// Eighth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD8))]
  ThreeD8 = 8,
  /// <summary>
  /// Ninth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD9))]
  ThreeD9 = 9,
  /// <summary>
  /// Tenth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD10))]
  ThreeD10 = 10,
  /// <summary>
  /// Eleventh 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD11))]
  ThreeD11 = 11,
  /// <summary>
  /// Twelfth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD12))]
  ThreeD12 = 12,
  /// <summary>
  /// Thirteenth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD13))]
  ThreeD13 = 13,
  /// <summary>
  /// Fourteenth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD14))]
  ThreeD14 = 14,
  /// <summary>
  /// Fifteenth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD15))]
  ThreeD15 = 15,
  /// <summary>
  /// Sixteenth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD16))]
  ThreeD16 = 16,
  /// <summary>
  /// Seventeenth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD17))]
  ThreeD17 = 17,
  /// <summary>
  /// Eighteenth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD18))]
  ThreeD18 = 18,
  /// <summary>
  /// Nineteenth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD19))]
  ThreeD19 = 19,
  /// <summary>
  /// Twentieth 3-D format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetThreeDFormat.msoThreeD20))]
  ThreeD20 = 20
}
