namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the GradientStopList Class.
/// </summary>
public interface GradientStopList: IModelElement
{
  public Collection<GradientStop>? GradientStops { get; set; }
}