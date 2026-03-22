namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Style Definition.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDefinition))]
public partial class StyleDefinition : ModelElement<DXDD.StyleDefinition>
{
  /// <summary>
  ///   Unique Style ID
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleDefinition.UniqueId))]
  public string? UniqueId { get => _UniqueId; set => UpdateField(ref _UniqueId, value, nameof(UniqueId)); }
  private string? _UniqueId;
  /// <summary>
  ///   Minimum Version
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleDefinition.MinVersion))]
  public string? MinVersion { get => _MinVersion; set => UpdateField(ref _MinVersion, value, nameof(MinVersion)); }
  private string? _MinVersion;
  /// <summary>
  /// Style Definition Titles.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.StyleDefinitionTitle))]
  public StyleDefinitionTitles? StyleDefinitionTitles { get => _StyleDefinitionTitles; set => UpdateField(ref _StyleDefinitionTitles, value, nameof(StyleDefinitionTitles)); }
  private StyleDefinitionTitles? _StyleDefinitionTitles;
  /// <summary>
  /// Style Label Descriptions.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.StyleLabelDescription))]
  public StyleLabelDescriptions? StyleLabelDescriptions { get => _StyleLabelDescriptions; set => UpdateField(ref _StyleLabelDescriptions, value, nameof(StyleLabelDescriptions)); }
  private StyleLabelDescriptions? _StyleLabelDescriptions;
  /// <summary>
  /// Style Display Categories.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.StyleDisplayCategories))]
  public StyleDisplayCategories? StyleDisplayCategories { get => _StyleDisplayCategories; set => UpdateField(ref _StyleDisplayCategories, value, nameof(StyleDisplayCategories)); }
  private StyleDisplayCategories? _StyleDisplayCategories;
  /// <summary>
  /// Scene3 D.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Scene3D))]
  public Scene3D? Scene3D { get => _Scene3D; set => UpdateField(ref _Scene3D, value, nameof(Scene3D)); }
  private Scene3D? _Scene3D;
  /// <summary>
  /// Style Label.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.StyleLabel))]
  public StyleLabel? StyleLabel { get => _StyleLabel; set => UpdateField(ref _StyleLabel, value, nameof(StyleLabel)); }
  private StyleLabel? _StyleLabel;
  /// <summary>
  /// Extension List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
  private ExtensionList? _ExtensionList;
}