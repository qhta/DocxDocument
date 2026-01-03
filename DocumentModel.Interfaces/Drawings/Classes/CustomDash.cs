namespace DocumentModel.Drawings;

/// <summary>
///   Custom Dash.
/// </summary>
public interface CustomDash: IModelElement
{
  public Collection<DashStop>? DashStops { get; set; }
}