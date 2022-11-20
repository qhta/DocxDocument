namespace DocumentModel.Office2016.Presentation.Command;

/// <summary>
/// Defines the SlideMonikerList Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Presentation.Command.IDocumentMoniker))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Presentation.Command.ISlideMoniker))]
public interface ISlideMonikerList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
