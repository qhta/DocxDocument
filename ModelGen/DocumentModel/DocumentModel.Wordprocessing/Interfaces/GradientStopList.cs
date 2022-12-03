namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStopList Class.
/// </summary>
public interface GradientStopList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<GradientStop>? GradientStops { get ; set; }
  
}
