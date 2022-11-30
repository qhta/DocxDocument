namespace DocumentModel.Drawing;

/// <summary>
/// Gradient Stop List.
/// </summary>
public interface IGradientStopList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IGradientStop>? GradientStops { get ; set; }
  
}
