namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Custom Dash.
/// </summary>
public class CustomDash: ModelElement
{
  public Collection<DashStop>? DashStops { get; set; }
}
