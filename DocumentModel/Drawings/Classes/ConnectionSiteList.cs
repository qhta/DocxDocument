namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Connection Sites.
/// </summary>
public record ConnectionSiteList
{
  public Collection<ConnectionSite>? ConnectionSites { get; set; }
}