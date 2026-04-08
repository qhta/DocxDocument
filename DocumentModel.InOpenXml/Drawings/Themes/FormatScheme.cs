namespace DocumentModel.Drawings;
/// <summary>
///   Represents a format scheme, including name and style lists for fills, lines, effects, and background fills.
/// </summary>
[OpenXmlType(typeof(DXD.FormatScheme))]
public partial class FormatScheme : ModelElement<DXD.FormatScheme>
{
 /// <summary>
 ///   Name of the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;
 /// <summary>
 ///   List of fill styles used in the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.FillStyleList))]
 public FillStyleList? FillStyleList { get => _FillStyleList; set => UpdateField(ref _FillStyleList, value, nameof(FillStyleList)); }
 private FillStyleList? _FillStyleList;
 /// <summary>
 ///   List of line styles used in the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.LineStyleList))]
 public LineStyleList? LineStyleList { get => _LineStyleList; set => UpdateField(ref _LineStyleList, value, nameof(LineStyleList)); }
 private LineStyleList? _LineStyleList;
 /// <summary>
 ///   List of effect styles used in the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.EffectStyleList))]
 public EffectStyleList? EffectStyleList { get => _EffectStyleList; set => UpdateField(ref _EffectStyleList, value, nameof(EffectStyleList)); }
 private EffectStyleList? _EffectStyleList;
 /// <summary>
 ///   List of background fill styles used in the format scheme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FormatScheme.BackgroundFillStyleList))]
 public FillStyleList? BackgroundFillStyleList { get => _BackgroundFillStyleList; set => UpdateField(ref _BackgroundFillStyleList, value, nameof(BackgroundFillStyleList)); }
 private FillStyleList? _BackgroundFillStyleList;
}