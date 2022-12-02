namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStopList Class.
/// </summary>
public interface IGradientStopList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IGradientStop>? GradientStops { get ; set; }
  
}
