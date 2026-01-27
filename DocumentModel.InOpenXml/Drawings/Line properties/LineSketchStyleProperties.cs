namespace DocumentModel.Drawings;
/// <summary>
///   Represents sketch style properties for a line, including geometry, type, and seed information.
/// </summary>
[OpenXmlType(typeof(DXO21DSS.LineSketchStyleProperties))]
public partial class LineSketchStyleProperties : ModelElement<DXO21DSS.LineSketchStyleProperties>, IOfficeArtExtendableElement
{
 /// <summary>
 ///   Sketch style definition identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO21DSS.LineSketchStyleProperties.Sd))]
 public UInt32? Sd { get => _Sd; set => UpdateField(ref _Sd, value, nameof(Sd)); }

 private UInt32? _Sd;
 /// <summary>
 ///   Custom geometry used for the sketch style.
 /// </summary>
 public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }

 private CustomGeometry? _CustomGeometry;
 /// <summary>
 ///   Preset geometry used for the sketch style.
 /// </summary>
 public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }

 private PresetGeometry? _PresetGeometry;
 /// <summary>
 ///   Additional properties for the sketch style type.
 /// </summary>
 public LineSketchTypeProperties? LineSketchTypeProperties { get => _LineSketchTypeProperties; set => UpdateField(ref _LineSketchTypeProperties, value, nameof(LineSketchTypeProperties)); }

 private LineSketchTypeProperties? _LineSketchTypeProperties;
 /// <summary>
 ///   Seed value for generating the sketch style.
 /// </summary>
 public string? LineSketchSeed { get => _LineSketchSeed; set => UpdateField(ref _LineSketchSeed, value, nameof(LineSketchSeed)); }

 private string? _LineSketchSeed;
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}