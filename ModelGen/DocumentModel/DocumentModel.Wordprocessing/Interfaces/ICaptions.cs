namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public interface ICaptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICaption>? Captions { get ; set; }
  
  public IAutoCaptions? AutoCaptions { get ; set; }
  
}
