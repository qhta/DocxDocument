namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ShowProperties Class.
/// </summary>
public interface IShowProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Loop Slide Show
  /// </summary>
  public System.Boolean? Loop { get ; set; }
  
  /// <summary>
  /// Show Narration in Slide Show
  /// </summary>
  public System.Boolean? ShowNarration { get ; set; }
  
  /// <summary>
  /// Show Animation in Slide Show
  /// </summary>
  public System.Boolean? ShowAnimation { get ; set; }
  
  /// <summary>
  /// Use Timings in Slide Show
  /// </summary>
  public System.Boolean? UseTimings { get ; set; }
  
}
