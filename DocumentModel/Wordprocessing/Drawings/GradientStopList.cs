namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GradientStopList Class.
/// </summary>
public class GradientStopList: ModelElement
{
  public Collection<GradientStop>? GradientStops { get; set; }
}