namespace DocumentModel.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public interface CustomDash
{
  public Collection<DocumentModel.Drawings.DashStop>? DashStops { get ; set; }
  
}
