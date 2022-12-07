namespace DocumentModel.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public class PathImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Path>, Path
{
  /// <summary>
  /// Path Fill
  /// </summary>
  public PathFillMode? Fill
  {
    get => (PathFillMode?)OpenXmlElement?.Fill?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Fill = (DocumentFormat.OpenXml.Drawing.PathFillModeValues?)value;
    }
  }
  
}
