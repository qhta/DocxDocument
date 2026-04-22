namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Color Transform Definitions.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorsDefinition))]
[XmlRoot("ColorDefinition", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class ColorDefinition : ModelElement<DXDD.ColorsDefinition>
{
 /// <summary>
 ///   Unique ID
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorsDefinition.UniqueId))]
 public string? UniqueId { get => _UniqueId; set => UpdateField(ref _UniqueId, value, nameof(UniqueId)); }
 private string? _UniqueId;

 /// <summary>
 ///   Minimum Version
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorsDefinition.MinVersion))]
 public string? MinVersion { get => _MinVersion; set => UpdateField(ref _MinVersion, value, nameof(MinVersion)); }
 private string? _MinVersion;

 /// <summary>
 /// Color Definition Titles.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.ColorDefinitionTitle))]
 public ColorDefinitionTitles? ColorDefinitionTitles { get => _ColorDefinitionTitles; set => UpdateField(ref _ColorDefinitionTitles, value, nameof(ColorDefinitionTitles)); }
 private ColorDefinitionTitles? _ColorDefinitionTitles;

 /// <summary>
 /// Color Transform Descriptions.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.ColorTransformDescription))]
 public ColorTransformDescriptions? ColorTransformDescriptions { get => _ColorTransformDescriptions; set => UpdateField(ref _ColorTransformDescriptions, value, nameof(ColorTransformDescriptions)); }
 private ColorTransformDescriptions? _ColorTransformDescriptions;

 /// <summary>
 /// Color Transform Categories.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.ColorTransformCategories))]
 public ColorTransformCategories? ColorTransformCategories { get => _ColorTransformCategories; set => UpdateField(ref _ColorTransformCategories, value, nameof(ColorTransformCategories)); }
 private ColorTransformCategories? _ColorTransformCategories;

 /// <summary>
 /// Color Transform Style Labels.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.ColorTransformStyleLabel))]
 public ColorTransformStyleLabels? ColorTransformStyleLabels { get => _ColorTransformStyleLabels; set => UpdateField(ref _ColorTransformStyleLabels, value, nameof(ColorTransformStyleLabels)); }
 private ColorTransformStyleLabels? _ColorTransformStyleLabels;

 /// <summary>
 /// Extension List.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}