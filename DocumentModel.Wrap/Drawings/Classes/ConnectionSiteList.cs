namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   List of Shape Connection Sites.
/// </summary>
public class ConnectionSiteList: ModelElement
{
  public Collection<ConnectionSite>? ConnectionSites { get; set; }
}