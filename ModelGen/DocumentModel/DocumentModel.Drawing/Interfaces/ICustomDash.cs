namespace DocumentModel.Drawing;

/// <summary>
/// Custom Dash.
/// </summary>
public interface ICustomDash // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDashStop>? DashStops { get ; set; }
  
}
