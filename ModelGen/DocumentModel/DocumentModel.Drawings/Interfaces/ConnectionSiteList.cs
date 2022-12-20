namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public partial interface ConnectionSiteList
{
  public Collection<DocumentModel.Drawings.ConnectionSite>? ConnectionSites { get; set; }
  
}
