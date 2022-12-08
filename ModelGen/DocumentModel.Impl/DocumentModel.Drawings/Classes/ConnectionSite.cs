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
  
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public String? Angle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public AdjustPoint2DType? Position
  {
    get;
    set;
  }
  
}
