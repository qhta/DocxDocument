namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Connection Sites.
/// </summary>
public class ConnectionSiteList: ModelElement
{
  public Collection<ConnectionSite>? ConnectionSites { get; set; }
}