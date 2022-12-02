namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public interface IAutoCaptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAutoCaption>? AutoCaptions { get ; set; }
  
}
