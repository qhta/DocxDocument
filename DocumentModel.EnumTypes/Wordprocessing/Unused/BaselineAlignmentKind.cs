namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies baseline alignment for Asian text.
/// </summary>
[OpenXmlEnumType(typeof(DXW.VerticalTextAlignmentValues))]
public enum BaselineAlignmentKind
{
  /// <summary>Align to baseline</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Baseline))]
  Baseline = 0,
  /// <summary>Align to top</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Top))]
  Top = 1,
  /// <summary>Align to center</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Center))]
  Center = 2,
  /// <summary>Align to bottom</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Bottom))]
  Bottom = 3,
  /// <summary>Automatic alignment</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Auto))]
  Auto = 4
}