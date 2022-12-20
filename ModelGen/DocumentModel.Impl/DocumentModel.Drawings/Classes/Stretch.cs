namespace DocumentModel.Drawings;

/// <summary>
/// Stretch.
/// </summary>
public partial class StretchImpl: ModelElementImpl, Stretch
{
  public DocumentFormat.OpenXml.Drawing.Stretch? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Stretch?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StretchImpl(): base() {}
  
  public StretchImpl(DocumentFormat.OpenXml.Drawing.Stretch openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  public DocumentModel.Drawings.RelativeRectangleType? FillRectangle
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
