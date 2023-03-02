namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the GradientStopList Class.
/// </summary>
public record GradientStopList
{
  public Collection<GradientStop>? GradientStops { get; set; }
}