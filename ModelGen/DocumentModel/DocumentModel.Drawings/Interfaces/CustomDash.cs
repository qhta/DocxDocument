namespace DocumentModel.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public interface CustomDash
{
  public Collection<DashStop>? DashStops { get ; set; }
  
}
