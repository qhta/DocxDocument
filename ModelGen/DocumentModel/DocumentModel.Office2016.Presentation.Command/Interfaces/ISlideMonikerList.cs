namespace DocumentModel.Office2016.Presentation.Command;

/// <summary>
/// Defines the SlideMonikerList Class.
/// </summary>
public interface ISlideMonikerList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// DocumentMoniker.
  /// </summary>
  public IDocumentMoniker? DocumentMoniker { get ; set; }
  
  /// <summary>
  /// SlideMoniker.
  /// </summary>
  public ISlideMoniker? SlideMoniker { get ; set; }
  
}
