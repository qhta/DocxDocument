namespace DocumentModel.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public interface CustomDash // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<DashStop>? DashStops { get ; set; }
  
}
