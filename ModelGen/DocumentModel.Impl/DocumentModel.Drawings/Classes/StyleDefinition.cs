namespace DocumentModel.Drawings;

/// <summary>
/// Style Definition.
/// </summary>
public class StyleDefinitionImpl: ModelElementImpl, StyleDefinition
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Unique Style ID
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
  
  public Collection<StyleDefinitionTitle>? StyleDefinitionTitles
  {
    get;
    set;
  }
  
  public Collection<StyleLabelDescription>? StyleLabelDescriptions
  {
    get;
    set;
  }
  
  public StyleDisplayCategories? StyleDisplayCategories
  {
    get;
    set;
  }
  
  public Scene3D? Scene3D
  {
    get;
    set;
  }
  
  public Collection<StyleLabel>? StyleLabels
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
