namespace DocumentModel.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public partial interface CustomDash
{
  public Collection<DocumentModel.Drawings.DashStop>? DashStops { get; set; }
  
}
