namespace DocumentModel.Drawings;

/// <summary>
/// Shape Connection Site.
/// </summary>
public partial class ConnectionSiteImpl: ModelElementImpl, ConnectionSite
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ConnectionSite? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectionSite?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ConnectionSiteImpl(): base() {}
  
  public ConnectionSiteImpl(DocumentFormat.OpenXml.Drawing.ConnectionSite openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public String? Angle
  {
    get => (System.String?)OpenXmlElement?.Angle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Angle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawings.AdjustPoint2DType? Position
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustPoint2DType>();
        if (item != null)
          return new DocumentModel.Drawings.AdjustPoint2DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustPoint2DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AdjustPoint2DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
