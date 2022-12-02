namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public interface IConnectionSiteList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IConnectionSite>? ConnectionSites { get ; set; }
  
}
