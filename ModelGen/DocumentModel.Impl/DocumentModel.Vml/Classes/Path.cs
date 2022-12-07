namespace DocumentModel.Vml;

/// <summary>
/// Defines the Path Class.
/// </summary>
public class PathImpl: ModelElement<DocumentFormat.OpenXml.Vml.Path>, Path
{
  /// <summary>
  /// Connection Point Type
  /// </summary>
  public ConnectKind? ConnectionPointType
  {
    get => (ConnectKind?)OpenXmlElement?.ConnectionPointType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectionPointType = (DocumentFormat.OpenXml.Vml.Office.ConnectValues?)value;
    }
  }
  
}
