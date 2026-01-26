namespace DocumentModel.Drawings;
/// <summary>
///   Represents a format scheme, including name and style lists for fills, lines, effects, and background fills.
/// </summary>
[OpenXmlType(typeof(DXD.FormatScheme))]
/// <summary>
///   Represents a format scheme, including name and style lists for fills, lines, effects, and background fills.
/// </summary>
public partial class FormatScheme : ModelElement<DXD.FormatScheme>
{
 /// <summary>
 ///   FontName of the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.Name))]
 [OpenXmlElement(typeof(DXD.FormatScheme))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 ///   List of fill styles used in the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.FillStyleList))]
 [OpenXmlElement(typeof(DXD.FormatScheme))]
 public FillStyleList? FillStyleList { get => _FillStyleList; set => UpdateField(ref _FillStyleList, value, nameof(FillStyleList)); }

 private FillStyleList? _FillStyleList;
 /// <summary>
 ///   List of line styles used in the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.LineStyleList))]
 [OpenXmlElement(typeof(DXD.FormatScheme))]
 public LineStyleList? LineStyleList { get => _LineStyleList; set => UpdateField(ref _LineStyleList, value, nameof(LineStyleList)); }

 private LineStyleList? _LineStyleList;
 /// <summary>
 ///   List of effect styles used in the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.EffectStyleList))]
 [OpenXmlElement(typeof(DXD.FormatScheme))]
 public EffectStyleList? EffectStyleList { get => _EffectStyleList; set => UpdateField(ref _EffectStyleList, value, nameof(EffectStyleList)); }

 private EffectStyleList? _EffectStyleList;
 /// <summary>
 ///   List of background fill styles used in the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.BackgroundFillStyleList))]
 [OpenXmlElement(typeof(DXD.FormatScheme))]
 public FillStyleList? BackgroundFillStyleList { get => _BackgroundFillStyleList; set => UpdateField(ref _BackgroundFillStyleList, value, nameof(BackgroundFillStyleList)); }

 private FillStyleList? _BackgroundFillStyleList;
}