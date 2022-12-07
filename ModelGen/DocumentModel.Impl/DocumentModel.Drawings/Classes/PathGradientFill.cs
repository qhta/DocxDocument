namespace DocumentModel.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public class PathGradientFillImpl: ModelElement<DocumentFormat.OpenXml.Drawing.PathGradientFill>, PathGradientFill
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public PathShadeKind? Path
  {
    get => (PathShadeKind?)OpenXmlElement?.Path?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Path = (DocumentFormat.OpenXml.Drawing.PathShadeValues?)value;
    }
  }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public Boolean? FillToRectangle
  {
    get;
    set;
  }
  
}
