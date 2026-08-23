namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Style Definition.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDefinition))]
[DataContract]
[XmlRoot("StyleDefinition", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class StyleDefinition: ModelElement<DXDD.StyleDefinition>
{
  /// <summary>
  ///   Unique Style ID
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleDefinition.UniqueId))]
  public string? UniqueId
  {
    get => _UniqueId ??= GetProperty<string?>(GetUpdatableElement()?.UniqueId);
    set => UpdateField(ref _UniqueId, value, nameof(UniqueId));
  }

  private string? _UniqueId;

  /// <summary>
  ///   Minimum Version
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleDefinition.MinVersion))]
  public string? MinVersion
  {
    get => _MinVersion ??= GetProperty<string?>(GetUpdatableElement()?.MinVersion);
    set => UpdateField(ref _MinVersion, value, nameof(MinVersion));
  }

  private string? _MinVersion;

  /// <summary>
  /// Style Definition Titles.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.StyleDefinitionTitle))]
  public StyleDefinitionTitles? StyleDefinitionTitles
  {
    get => _StyleDefinitionTitles ??=
      GetElement<StyleDefinitionTitles, DXDD.StyleDefinitionTitle>(GetUpdatableElement());
    set => UpdateField(ref _StyleDefinitionTitles, value, nameof(StyleDefinitionTitles));
  }

  private StyleDefinitionTitles? _StyleDefinitionTitles;

  /// <summary>
  /// Style Label Descriptions.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.StyleLabelDescription))]
  public StyleLabelDescriptions? StyleLabelDescriptions
  {
    get => _StyleLabelDescriptions ??=
      GetElement<StyleLabelDescriptions, DXDD.StyleLabelDescription>(GetUpdatableElement());
    set => UpdateField(ref _StyleLabelDescriptions, value, nameof(StyleLabelDescriptions));
  }

  private StyleLabelDescriptions? _StyleLabelDescriptions;

  /// <summary>
  /// Style Display Categories.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.StyleDisplayCategories))]
  public StyleDisplayCategories? StyleDisplayCategories
  {
    get => _StyleDisplayCategories ??=
      GetElement<StyleDisplayCategories, DXDD.StyleDisplayCategories>(GetUpdatableElement());
    set => UpdateField(ref _StyleDisplayCategories, value, nameof(StyleDisplayCategories));
  }

  private StyleDisplayCategories? _StyleDisplayCategories;

  /// <summary>
  /// Scene3 D.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Scene3D))]
  public Scene3D? Scene3D
  {
    get => _Scene3D ??= GetElement<Scene3D, DXDD.Scene3D>(GetUpdatableElement());
    set => UpdateField(ref _Scene3D, value, nameof(Scene3D));
  }

  private Scene3D? _Scene3D;

  /// <summary>
  /// Style Label.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.StyleLabel))]
  public StyleLabel? StyleLabel
  {
    get => _StyleLabel ??= GetElement<StyleLabel, DXDD.StyleLabel>(GetUpdatableElement());
    set => UpdateField(ref _StyleLabel, value, nameof(StyleLabel));
  }

  private StyleLabel? _StyleLabel;

  /// <summary>
  /// Extension List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetElement<IExtensionList, DXDD.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}