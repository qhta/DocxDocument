namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IList of IShape Connection Sites.
/// </summary>
public class ConnectionSiteList: ModelElement
{
  public Collection<ConnectionSite>? ConnectionSites { get; set; }
}
