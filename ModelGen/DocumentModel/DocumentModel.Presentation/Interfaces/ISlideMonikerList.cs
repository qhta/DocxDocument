namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMonikerList Class.
/// </summary>
public interface ISlideMonikerList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// DocumentMoniker.
  /// </summary>
  public Boolean? DocumentMoniker { get ; set; }
  
  /// <summary>
  /// SlideMoniker.
  /// </summary>
  public ISlideMoniker? SlideMoniker { get ; set; }
  
}
