namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public class ConnectionSiteListImpl: ModelElementImpl, ConnectionSiteList
{
  public DocumentFormat.OpenXml.Drawing.ConnectionSiteList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectionSiteList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<ConnectionSite>? ConnectionSites
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
