namespace DocumentModel.Drawings;

/// <summary>
///   Custom Dash.
/// </summary>
public record CustomDash
{
  public Collection<DashStop>? DashStops { get; set; }
}