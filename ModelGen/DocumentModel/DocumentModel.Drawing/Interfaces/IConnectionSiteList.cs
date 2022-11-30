namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public interface IConnectionSiteList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IConnectionSite>? ConnectionSites { get ; set; }
  
}
