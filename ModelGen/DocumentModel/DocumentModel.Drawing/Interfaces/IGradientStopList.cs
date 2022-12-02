namespace DocumentModel.Drawing;

/// <summary>
/// Gradient Stop List.
/// </summary>
public interface IGradientStopList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IGradientStop>? GradientStops { get ; set; }
  
}
