namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public interface ICaptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ICaption>? Captions { get ; set; }
  
  public DocumentModel.Wordprocessing.IAutoCaptions? AutoCaptions { get ; set; }
  
}
