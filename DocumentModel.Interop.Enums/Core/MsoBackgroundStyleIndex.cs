namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the background style for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobackgroundstyleindex?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoBackgroundStyleIndex))]
public enum BackgroundStyleIndex
{
  /// <summary>
  /// Specifies a combination of styles.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStyleMixed))]
  Mixed = -2,
  /// <summary>
  /// Specifies no styles.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStyleNotAPreset))]
  NotAPreset = 0,
  /// <summary>
  /// Specifies style 1.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset1))]
  Preset1 = 1,
  /// <summary>
  /// Specifies style 2.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset2))]
  Preset2 = 2,
  /// <summary>
  /// Specifies style 3.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset3))]
  Preset3 = 3,
  /// <summary>
  /// Specifies style 4.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset4))]
  Preset4 = 4,
  /// <summary>
  /// Specifies style 5.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset5))]
  Preset5 = 5,
  /// <summary>
  /// Specifies style 6.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset6))]
  Preset6 = 6,
  /// <summary>
  /// Specifies style 7.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset7))]
  Preset7 = 7,
  /// <summary>
  /// Specifies style 8.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset8))]
  Preset8 = 8,
  /// <summary>
  /// Specifies style 9.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset9))]
  Preset9 = 9,
  /// <summary>
  /// Specifies style 10.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset10))]
  Preset10 = 10,
  /// <summary>
  /// Specifies style 11.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset11))]
  Preset11 = 11,
  /// <summary>
  /// Specifies style 12.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBackgroundStyleIndex.msoBackgroundStylePreset12))]
  Preset12 = 12
}
