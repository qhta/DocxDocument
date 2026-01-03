namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Connection Sites.
/// </summary>
public interface ConnectionSiteList: IModelElement
{
  public Collection<ConnectionSite>? ConnectionSites { get; set; }
}