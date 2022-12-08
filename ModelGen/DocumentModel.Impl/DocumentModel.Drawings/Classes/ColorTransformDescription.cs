namespace DocumentModel.Drawings;

/// <summary>
/// Description.
/// </summary>
public class ColorTransformDescriptionImpl: ModelElementImpl, ColorTransformDescription
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription?)_OpenXmlElement;
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
