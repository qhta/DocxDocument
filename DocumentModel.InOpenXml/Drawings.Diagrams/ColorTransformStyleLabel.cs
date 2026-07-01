namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Style Label.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformStyleLabel))]
[DataContract]
[XmlRoot("ColorTransformStyleLabel", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class ColorTransformStyleLabel : ModelElement<DXDD.ColorTransformStyleLabel>
{
 /// <summary>
 ///   Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;

 /// <summary>
 ///   Fill Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.FillColorList))]
 public FillColor? FillColorList { get => _FillColorList; set => UpdateField(ref _FillColorList, value, nameof(FillColorList)); }
 private FillColor? _FillColorList;

 /// <summary>
 ///   Line Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.LineColorList))]
 public LineColorList? LineColorList { get => _LineColorList; set => UpdateField(ref _LineColorList, value, nameof(LineColorList)); }
 private LineColorList? _LineColorList;

 /// <summary>
 ///   Effect Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.EffectColorList))]
 public EffectColorList? EffectColorList { get => _EffectColorList; set => UpdateField(ref _EffectColorList, value, nameof(EffectColorList)); }
 private EffectColorList? _EffectColorList;

 /// <summary>
 ///   Text Line Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextLineColorList))]
 public TextLineColorList? TextLineColorList { get => _TextLineColorList; set => UpdateField(ref _TextLineColorList, value, nameof(TextLineColorList)); }
 private TextLineColorList? _TextLineColorList;

 /// <summary>
 ///   Text Fill Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextFillColorList))]
 public TextFillColorList? TextFillColorList { get => _TextFillColorList; set => UpdateField(ref _TextFillColorList, value, nameof(TextFillColorList)); }
 private TextFillColorList? _TextFillColorList;

 /// <summary>
 ///   Text Effect Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextEffectColorList))]
 public TextEffectColorList? TextEffectColorList { get => _TextEffectColorList; set => UpdateField(ref _TextEffectColorList, value, nameof(TextEffectColorList)); }
 private TextEffectColorList? _TextEffectColorList;

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}