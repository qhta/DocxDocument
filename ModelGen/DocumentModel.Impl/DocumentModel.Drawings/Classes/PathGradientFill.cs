namespace DocumentModel.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public class PathGradientFillImpl: ModelElementImpl, PathGradientFill
{
  public DocumentFormat.OpenXml.Drawing.PathGradientFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PathGradientFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  public RelativeRectangleType? FillToRectangle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
