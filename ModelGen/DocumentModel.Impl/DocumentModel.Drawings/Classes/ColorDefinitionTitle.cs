namespace DocumentModel.Drawings;

/// <summary>
/// Title.
/// </summary>
public class ColorDefinitionTitleImpl: ModelElementImpl, ColorDefinitionTitle
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Language
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
