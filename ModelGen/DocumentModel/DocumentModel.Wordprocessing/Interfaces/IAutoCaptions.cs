namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public interface IAutoCaptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IAutoCaption>? AutoCaptions { get ; set; }
  
}
