namespace DocumentModel.Office2016.Presentation.Command;

/// <summary>
/// Defines the SlideMonikerList Class.
/// </summary>
public interface ISlideMonikerList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// DocumentMoniker.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? DocumentMoniker { get ; set; }
  
  /// <summary>
  /// SlideMoniker.
  /// </summary>
  public DocumentModel.Office2016.Presentation.Command.ISlideMoniker? SlideMoniker { get ; set; }
  
}
