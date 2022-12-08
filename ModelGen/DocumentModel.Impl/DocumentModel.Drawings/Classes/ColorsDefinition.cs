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
  
  /// <summary>
  /// Unique ID
  /// </summary>
  public String? UniqueId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion
  {
    get;
    set;
  }
  
  public Collection<ColorDefinitionTitle>? ColorDefinitionTitles
  {
    get;
    set;
  }
  
  public Collection<ColorTransformDescription>? ColorTransformDescriptions
  {
    get;
    set;
  }
  
  public ColorTransformCategories? ColorTransformCategories
  {
    get;
    set;
  }
  
  public Collection<ColorTransformStyleLabel>? ColorTransformStyleLabels
  {
    get;
    set;
  }
  
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
