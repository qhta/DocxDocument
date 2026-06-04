namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopictureeffecttype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPictureEffectType))]
public enum PictureEffectType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectNone))]
  None,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectBackgroundRemoval))]
  BackgroundRemoval,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectBlur))]
  Blur,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectBrightnessContrast))]
  BrightnessContrast,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectCement))]
  Cement,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectCrisscrossEtching))]
  CrisscrossEtching,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectChalkSketch))]
  ChalkSketch,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectColorTemperature))]
  ColorTemperature,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectCutout))]
  Cutout,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectFilmGrain))]
  FilmGrain,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectGlass))]
  Glass,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectGlowDiffused))]
  GlowDiffused,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectGlowEdges))]
  GlowEdges,
  /// <summary>
  /// public enum class PictureEffectType
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectLightScreen))]
  LightScreen,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectLineDrawing))]
  LineDrawing,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectMarker))]
  Marker,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectMosiaicBubbles))]
  MosiaicBubbles,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectPaintBrush))]
  PaintBrush,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectPaintStrokes))]
  PaintStrokes,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectPastelsSmooth))]
  PastelsSmooth,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectPencilGrayscale))]
  PencilGrayscale,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectPencilSketch))]
  PencilSketch,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectPhotocopy))]
  Photocopy,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectPlasticWrap))]
  PlasticWrap,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectSaturation))]
  Saturation,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectSharpenSoften))]
  SharpenSoften,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectTexturizer))]
  Texturizer,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureEffectType.msoEffectWatercolorSponge))]
  WatercolorSponge
}
