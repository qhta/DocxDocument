namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMonikerList Class.
/// </summary>
public interface SlideMonikerList // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// DocumentMoniker.
  /// </summary>
  public Boolean? DocumentMoniker { get ; set; }
  
  /// <summary>
  /// SlideMoniker.
  /// </summary>
  public SlideMoniker? SlideMoniker { get ; set; }
  
}
