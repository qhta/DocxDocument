namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ShowProperties Class.
/// </summary>
public interface IShowProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Loop Slide Show
  /// </summary>
  public Boolean? Loop { get ; set; }
  
  /// <summary>
  /// Show Narration in Slide Show
  /// </summary>
  public Boolean? ShowNarration { get ; set; }
  
  /// <summary>
  /// Show Animation in Slide Show
  /// </summary>
  public Boolean? ShowAnimation { get ; set; }
  
  /// <summary>
  /// Use Timings in Slide Show
  /// </summary>
  public Boolean? UseTimings { get ; set; }
  
}
