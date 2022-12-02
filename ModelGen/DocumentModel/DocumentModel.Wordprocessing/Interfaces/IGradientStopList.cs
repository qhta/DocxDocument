namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStopList Class.
/// </summary>
public interface IGradientStopList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IGradientStop>? GradientStops { get ; set; }
  
}
