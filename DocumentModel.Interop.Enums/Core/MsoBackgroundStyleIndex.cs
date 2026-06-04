namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the background style for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobackgroundstyleindex?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBackgroundStyleIndex")]
public enum BackgroundStyleIndex
{
  /// <summary>
  /// Specifies a combination of styles.
  /// </summary>
  [InteropEnumValue("msoBackgroundStyleMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies no styles.
  /// </summary>
  [InteropEnumValue("msoBackgroundStyleNotAPreset")]
  NotAPreset = 0,
  /// <summary>
  /// Specifies style 1.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset1")]
  Preset1 = 1,
  /// <summary>
  /// Specifies style 2.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset2")]
  Preset2 = 2,
  /// <summary>
  /// Specifies style 3.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset3")]
  Preset3 = 3,
  /// <summary>
  /// Specifies style 4.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset4")]
  Preset4 = 4,
  /// <summary>
  /// Specifies style 5.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset5")]
  Preset5 = 5,
  /// <summary>
  /// Specifies style 6.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset6")]
  Preset6 = 6,
  /// <summary>
  /// Specifies style 7.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset7")]
  Preset7 = 7,
  /// <summary>
  /// Specifies style 8.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset8")]
  Preset8 = 8,
  /// <summary>
  /// Specifies style 9.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset9")]
  Preset9 = 9,
  /// <summary>
  /// Specifies style 10.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset10")]
  Preset10 = 10,
  /// <summary>
  /// Specifies style 11.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset11")]
  Preset11 = 11,
  /// <summary>
  /// Specifies style 12.
  /// </summary>
  [InteropEnumValue("msoBackgroundStylePreset12")]
  Preset12 = 12
}
