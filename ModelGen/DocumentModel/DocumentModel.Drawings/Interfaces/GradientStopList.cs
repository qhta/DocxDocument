namespace DocumentModel.Drawings;

/// <summary>
/// Gradient Stop List.
/// </summary>
public interface GradientStopList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<GradientStop>? GradientStops { get ; set; }
  
}
