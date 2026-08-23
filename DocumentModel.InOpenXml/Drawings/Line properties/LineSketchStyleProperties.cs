namespace DocumentModel.Drawings;

/// <summary>
///   Represents sketch style properties for a line in DrawingML, including geometry, sketch type, and seed information for randomized rendering effects.
///   Enables advanced visual effects for lines, such as hand-drawn or artistic styles, by configuring geometry and sketch parameters.
/// </summary>
[OpenXmlType(typeof(DXO21DSS.LineSketchStyleProperties))]
[DataContract]
[XmlRoot("LineSketchStyleProperties", Namespace = "DocumentModel.Drawings")]
public partial class LineSketchStyleProperties: ModelElement<DXO21DSS.LineSketchStyleProperties>,
  IOfficeArtExtendableElement
{
  /// <summary>
  ///   Identifier for the sketch style definition, referencing a specific sketch style preset or configuration.
  /// </summary>
  [OpenXmlProperty(nameof(DXO21DSS.LineSketchStyleProperties.Sd))]
  public UInt32? Sd
  {
    get => _Sd ??= GetProperty<UInt32?>(GetUpdatableElement()?.Sd);
    set => UpdateField(ref _Sd, value, nameof(Sd));
  }

  private UInt32? _Sd;

  /// <summary>
  ///   Custom geometry used for the sketch style, allowing for user-defined shapes and paths.
  /// </summary>
  public CustomGeometry? CustomGeometry
  {
    get => _CustomGeometry;
    set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry));
  }

  private CustomGeometry? _CustomGeometry;

  /// <summary>
  ///   Preset geometry used for the sketch style, selecting from predefined shapes and line types.
  /// </summary>
  public PresetGeometry? PresetGeometry
  {
    get => _PresetGeometry;
    set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry));
  }

  private PresetGeometry? _PresetGeometry;

  /// <summary>
  ///   Additional properties for the sketch style type, specifying rendering options and style variations.
  /// </summary>
  public LineSketchTypeProperties? LineSketchTypeProperties
  {
    get => _LineSketchTypeProperties;
    set => UpdateField(ref _LineSketchTypeProperties, value, nameof(LineSketchTypeProperties));
  }

  private LineSketchTypeProperties? _LineSketchTypeProperties;

  /// <summary>
  ///   Seed value for generating the sketch style, enabling randomized or unique hand-drawn effects for each instance.
  /// </summary>
  public string? LineSketchSeed
  {
    get => _LineSketchSeed;
    set => UpdateField(ref _LineSketchSeed, value, nameof(LineSketchSeed));
  }

  private string? _LineSketchSeed;

  /// <summary>
  ///   List of OfficeArt extension elements for the sketch style, supporting extensibility and application-specific data.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => _OfficeArtExtensionList;
    set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList));
  }

  private OfficeArtExtensionList? _OfficeArtExtensionList;
}