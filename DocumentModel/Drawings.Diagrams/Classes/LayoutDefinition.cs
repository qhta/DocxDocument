namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Layout Definition.
/// </summary>
public class LayoutDefinition: ModelElement
{
  /// <summary>
  ///   uniqueId
  /// </summary>
  public String? UniqueId { get; set; }

  /// <summary>
  ///   minVer
  /// </summary>
  public String? MinVersion { get; set; }

  /// <summary>
  ///   defStyle
  /// </summary>
  public String? DefaultStyle { get; set; }

  public Collection<Title>? Titles { get; set; }

  public Collection<Description>? Descriptions { get; set; }

  public CategoryList? CategoryList { get; set; }

  public SampleData? SampleData { get; set; }

  public StyleData? StyleData { get; set; }

  public ColorData? ColorData { get; set; }

  public LayoutNode? LayoutNode { get; set; }

  public DiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get; set; }
}