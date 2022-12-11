namespace DocumentModel.Drawings;

/// <summary>
/// Shape Connection Site.
/// </summary>
public class ConnectionSiteImpl: ModelElementImpl, ConnectionSite
{
  public DocumentFormat.OpenXml.Drawing.ConnectionSite? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectionSite?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => (String?)OpenXmlElement?.Angle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Angle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public AdjustPoint2DType? Position
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
