namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the GradientStopList Class.
/// </summary>
public interface IGradientStopList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Word.IGradientStop>? GradientStops { get ; set; }
  
}
