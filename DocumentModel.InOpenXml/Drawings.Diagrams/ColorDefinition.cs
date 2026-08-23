namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Color Transform Definitions.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorsDefinition))]
[DataContract]
[XmlRoot("ColorDefinition", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class ColorDefinition: ModelElement<DXDD.ColorsDefinition>
{
  /// <summary>
  ///   Unique ID
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ColorsDefinition.UniqueId))]
  public string? UniqueId
  {
    get => _UniqueId ??= GetProperty<string?>(GetUpdatableElement()?.UniqueId);
    set => UpdateField(ref _UniqueId, value, nameof(UniqueId));
  }

  private string? _UniqueId;

  /// <summary>
  ///   Minimum Version
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ColorsDefinition.MinVersion))]
  public string? MinVersion
  {
    get => _MinVersion ??= GetProperty<string?>(GetUpdatableElement()?.MinVersion);
    set => UpdateField(ref _MinVersion, value, nameof(MinVersion));
  }

  private string? _MinVersion;

  /// <summary>
  /// Color Definition Titles.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ColorDefinitionTitle))]
  public ColorDefinitionTitles? ColorDefinitionTitles
  {
    get => _ColorDefinitionTitles ??=
      GetElement<ColorDefinitionTitles, DXDD.ColorDefinitionTitle>(GetUpdatableElement());
    set => UpdateField(ref _ColorDefinitionTitles, value, nameof(ColorDefinitionTitles));
  }

  private ColorDefinitionTitles? _ColorDefinitionTitles;

  /// <summary>
  /// Color Transform Descriptions.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ColorTransformDescription))]
  public ColorTransformDescriptions? ColorTransformDescriptions
  {
    get => _ColorTransformDescriptions ??=
      GetElement<ColorTransformDescriptions, DXDD.ColorTransformDescription>(GetUpdatableElement());
    set => UpdateField(ref _ColorTransformDescriptions, value, nameof(ColorTransformDescriptions));
  }

  private ColorTransformDescriptions? _ColorTransformDescriptions;

  /// <summary>
  /// Color Transform Categories.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ColorTransformCategories))]
  public ColorTransformCategories? ColorTransformCategories
  {
    get => _ColorTransformCategories ??=
      GetElement<ColorTransformCategories, DXDD.ColorTransformCategories>(GetUpdatableElement());
    set => UpdateField(ref _ColorTransformCategories, value, nameof(ColorTransformCategories));
  }

  private ColorTransformCategories? _ColorTransformCategories;

  /// <summary>
  /// Color Transform Style Labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ColorTransformStyleLabel))]
  public ColorTransformStyleLabels? ColorTransformStyleLabels
  {
    get => _ColorTransformStyleLabels ??=
      GetElement<ColorTransformStyleLabels, DXDD.ColorTransformStyleLabel>(GetUpdatableElement());
    set => UpdateField(ref _ColorTransformStyleLabels, value, nameof(ColorTransformStyleLabels));
  }

  private ColorTransformStyleLabels? _ColorTransformStyleLabels;

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