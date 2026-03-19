namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Layout Definition.
/// </summary>
[OpenXmlType(typeof(DXDD.LayoutDefinition))]
/// <summary>
/// Represents the Layout Definition.
/// </summary>
public class LayoutDefinition: ModelElement<DXDD.LayoutDefinition>
{
  /// <summary>
  ///   uniqueId
  /// </summary>
  public string? UniqueId { get; set; }
  /// <summary>
  ///   minVer
  /// </summary>
  public string? MinVersion { get; set; }
  /// <summary>
  ///   defStyle
  /// </summary>
  public string? DefaultStyle { get; set; }
  /// <summary>
  /// Titles.
  /// </summary>
  public Titles? Titles { get; set; }
  /// <summary>
  /// Descriptions.
  /// </summary>
  public Descriptions? Descriptions { get; set; }
  /// <summary>
  /// Category List.
  /// </summary>
  public CategoryList? CategoryList { get; set; }
  /// <summary>
  /// Sample Data.
  /// </summary>
  public SampleData? SampleData { get; set; }
  /// <summary>
  /// Style Data.
  /// </summary>
  public StyleData? StyleData { get; set; }
  /// <summary>
  /// Color Data.
  /// </summary>
  public ColorData? ColorData { get; set; }
  /// <summary>
  /// Layout Node.
  /// </summary>
  public LayoutNode? LayoutNode { get; set; }
  /// <summary>
  /// Diagram Definition Extension List.
  /// </summary>
  public DiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get; set; }
}

