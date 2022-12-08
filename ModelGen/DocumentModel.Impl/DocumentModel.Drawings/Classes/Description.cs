namespace DocumentModel.Drawings;

/// <summary>
/// Description.
/// </summary>
public class DescriptionImpl: ModelElementImpl, Description
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Description? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Description?)_OpenXmlElement;
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
  /// Value
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
}
