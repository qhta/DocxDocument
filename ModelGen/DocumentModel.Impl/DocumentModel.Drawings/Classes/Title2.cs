namespace DocumentModel.Drawings;

/// <summary>
/// Title.
/// </summary>
public class Title2Impl: ModelElementImpl, Title2
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Title? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Title?)_OpenXmlElement;
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
