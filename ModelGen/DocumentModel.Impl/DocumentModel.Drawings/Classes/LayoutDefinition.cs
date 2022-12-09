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
    get => (String?)OpenXmlElement?.UniqueId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UniqueId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// minVer
  /// </summary>
  public String? MinVersion
  {
    get => (String?)OpenXmlElement?.MinVersion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinVersion = (System.String?)value;
    }
  }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public String? DefaultStyle
  {
    get => (String?)OpenXmlElement?.DefaultStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultStyle = (System.String?)value;
    }
  }
  
  public Collection<Title1>? Titles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Description>? Descriptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public CategoryList? CategoryList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public SampleData? SampleData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public StyleData? StyleData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ColorData? ColorData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LayoutNode? LayoutNode
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DiagramDefinitionExtensionList? DiagramDefinitionExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
