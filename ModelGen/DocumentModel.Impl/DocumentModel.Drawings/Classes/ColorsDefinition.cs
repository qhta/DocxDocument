namespace DocumentModel.Drawings;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public class ColorsDefinitionImpl: ModelElementImpl, ColorsDefinition
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorsDefinitionImpl(): base() {}
  
  public ColorsDefinitionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique ID
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
  /// Minimum Version
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
  
  public Collection<ColorDefinitionTitle>? ColorDefinitionTitles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ColorTransformDescription>? ColorTransformDescriptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ColorTransformCategories? ColorTransformCategories
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ColorTransformStyleLabel>? ColorTransformStyleLabels
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
