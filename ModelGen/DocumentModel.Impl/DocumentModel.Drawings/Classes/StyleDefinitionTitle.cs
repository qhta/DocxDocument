namespace DocumentModel.Drawings;

/// <summary>
/// Title.
/// </summary>
public class StyleDefinitionTitleImpl: ModelElementImpl, StyleDefinitionTitle
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Natural Language
  /// </summary>
  public String? Language
  {
    get;
    set;
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
}
