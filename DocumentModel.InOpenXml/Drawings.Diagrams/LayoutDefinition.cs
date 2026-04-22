namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Layout Definition.
/// </summary>
[OpenXmlType(typeof(DXDD.LayoutDefinition))]
[XmlRoot("LayoutDefinition", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class LayoutDefinition : ModelElement<DXDD.LayoutDefinition>
{
 /// <summary>
 ///   uniqueId
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.LayoutDefinition.UniqueId))]
 public string? UniqueId { get => _UniqueId; set => UpdateField(ref _UniqueId, value, nameof(UniqueId)); }
 private string? _UniqueId;

 /// <summary>
 ///   minVer
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.LayoutDefinition.MinVersion))]
 public string? MinVersion { get => _MinVersion; set => UpdateField(ref _MinVersion, value, nameof(MinVersion)); }
 private string? _MinVersion;

 /// <summary>
 ///   defStyle
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.LayoutDefinition.DefaultStyle))]
 public string? DefaultStyle { get => _DefaultStyle; set => UpdateField(ref _DefaultStyle, value, nameof(DefaultStyle)); }
 private string? _DefaultStyle;

 /// <summary>
 /// Titles.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.Title))]
 public Titles? Titles { get => _Titles; set => UpdateField(ref _Titles, value, nameof(Titles)); }
 private Titles? _Titles;

 /// <summary>
 /// Descriptions.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.Description))]
 public Descriptions? Descriptions { get => _Descriptions; set => UpdateField(ref _Descriptions, value, nameof(Descriptions)); }
 private Descriptions? _Descriptions;

 /// <summary>
 /// Category List.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.CategoryList))]
 public CategoryList? CategoryList { get => _CategoryList; set => UpdateField(ref _CategoryList, value, nameof(CategoryList)); }
 private CategoryList? _CategoryList;

 /// <summary>
 /// Sample Data.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.SampleData))]
 public SampleData? SampleData { get => _SampleData; set => UpdateField(ref _SampleData, value, nameof(SampleData)); }
 private SampleData? _SampleData;

 /// <summary>
 /// Style Data.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.StyleData))]
 public StyleData? StyleData { get => _StyleData; set => UpdateField(ref _StyleData, value, nameof(StyleData)); }
 private StyleData? _StyleData;

 /// <summary>
 /// Color Data.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.ColorData))]
 public ColorData? ColorData { get => _ColorData; set => UpdateField(ref _ColorData, value, nameof(ColorData)); }
 private ColorData? _ColorData;

 /// <summary>
 /// Layout Node.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.LayoutNode))]
 public LayoutNode? LayoutNode { get => _LayoutNode; set => UpdateField(ref _LayoutNode, value, nameof(LayoutNode)); }
 private LayoutNode? _LayoutNode;

 /// <summary>
 /// Diagram Definition Extension List.
 /// </summary>
 [OpenXmlElement(typeof(DXDD.DiagramDefinitionExtensionList))]
 public DiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get => _DiagramDefinitionExtensionList; set => UpdateField(ref _DiagramDefinitionExtensionList, value, nameof(DiagramDefinitionExtensionList)); }
 private DiagramDefinitionExtensionList? _DiagramDefinitionExtensionList;
}