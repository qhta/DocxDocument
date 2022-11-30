namespace DocumentModel.Drawing;

/// <summary>
/// Custom Dash.
/// </summary>
public interface ICustomDash // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDashStop>? DashStops { get ; set; }
  
}
