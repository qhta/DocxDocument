namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public interface ConnectionSiteList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ConnectionSite>? ConnectionSites { get ; set; }
  
}
