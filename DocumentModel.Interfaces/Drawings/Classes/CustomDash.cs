namespace DocumentModel.Drawings;

/// <summary>
///   Custom Dash.
/// </summary>
public class CustomDash: ModelElement
{
  public Collection<DashStop>? DashStops { get; set; }
}