namespace DocumentModel.Drawings;

/// <summary>
/// Layout Definition.
/// </summary>
public class LayoutDefinitionImpl: ModelElementImpl, LayoutDefinition
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// uniqueId
  /// </summary>
  public String? UniqueId
  {
    get;
    set;
  }
  
  /// <summary>
  /// minVer
  /// </summary>
  public String? MinVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public String? DefaultStyle
  {
    get;
    set;
  }
  
  public Collection<Title2>? Titles
  {
    get;
    set;
  }
  
  public Collection<Description>? Descriptions
  {
    get;
    set;
  }
  
  public CategoryList? CategoryList
  {
    get;
    set;
  }
  
  public SampleData? SampleData
  {
    get;
    set;
  }
  
  public StyleData? StyleData
  {
    get;
    set;
  }
  
  public ColorData? ColorData
  {
    get;
    set;
  }
  
  public LayoutNode? LayoutNode
  {
    get;
    set;
  }
  
  public DiagramDefinitionExtensionList? DiagramDefinitionExtensionList
  {
    get;
    set;
  }
  
}
