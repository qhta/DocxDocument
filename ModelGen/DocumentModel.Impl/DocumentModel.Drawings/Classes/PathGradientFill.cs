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
  
  public PathGradientFillImpl(): base() {}
  
  public PathGradientFillImpl(DocumentFormat.OpenXml.Drawing.PathGradientFill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public DocumentModel.Drawings.PathShadeKind? Path
  {
    get => (DocumentModel.Drawings.PathShadeKind?)OpenXmlElement?.Path?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Path = (DocumentFormat.OpenXml.Drawing.PathShadeValues?)value;
    }
  }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public DocumentModel.Drawings.RelativeRectangleType? FillToRectangle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeRectangleType>();
        if (item != null)
          return new DocumentModel.Drawings.RelativeRectangleTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeRectangleType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RelativeRectangleTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
