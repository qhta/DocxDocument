namespace DocumentModel.Drawings;
/// <summary>
///   Represents sketch style properties for a line, including geometry, type, and seed information.
/// </summary>
public partial class LineSketchStyleProperties : ModelElement<DXO21DSS.LineSketchStyleProperties>, IOfficeArtExtendableElement
{
    /// <summary>
    ///   Sketch style definition identifier.
    /// </summary>
    [OpenXmlProperty(nameof(DXO21DSS.LineSketchStyleProperties.Sd))]
    /// <summary>
    ///   Sketch style definition identifier.
    /// </summary>
    [OpenXmlElement(typeof(DXO21DSS.LineSketchStyleProperties))]
    public UInt32? Sd { get => _Sd; set => UpdateField(ref _Sd, value, nameof(Sd)); }

    private UInt32? _Sd;
    /// <summary>
    ///   Custom geometry used for the sketch style.
    /// </summary>
    [OpenXmlElement(typeof(DXO21DSS.LineSketchStyleProperties))]
    public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }

    private CustomGeometry? _CustomGeometry;
    /// <summary>
    ///   Preset geometry used for the sketch style.
    /// </summary>
    [OpenXmlElement(typeof(DXO21DSS.LineSketchStyleProperties))]
    public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }

    private PresetGeometry? _PresetGeometry;
    /// <summary>
    ///   Additional properties for the sketch style type.
    /// </summary>
    [OpenXmlElement(typeof(DXO21DSS.LineSketchStyleProperties))]
    public LineSketchTypeProperties? LineSketchTypeProperties { get => _LineSketchTypeProperties; set => UpdateField(ref _LineSketchTypeProperties, value, nameof(LineSketchTypeProperties)); }

    private LineSketchTypeProperties? _LineSketchTypeProperties;
    /// <summary>
    ///   Seed value for generating the sketch style.
    /// </summary>
    [OpenXmlElement(typeof(DXO21DSS.LineSketchStyleProperties))]
    public string? LineSketchSeed { get => _LineSketchSeed; set => UpdateField(ref _LineSketchSeed, value, nameof(LineSketchSeed)); }

    private string? _LineSketchSeed;
    [OpenXmlElement(typeof(DXO21DSS.LineSketchStyleProperties))]
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}