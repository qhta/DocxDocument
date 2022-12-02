namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMonikerList Class.
/// </summary>
public interface ISlideMonikerList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// DocumentMoniker.
  /// </summary>
  public System.Boolean? DocumentMoniker { get ; set; }
  
  /// <summary>
  /// SlideMoniker.
  /// </summary>
  public DocumentModel.Presentation.ISlideMoniker? SlideMoniker { get ; set; }
  
}
