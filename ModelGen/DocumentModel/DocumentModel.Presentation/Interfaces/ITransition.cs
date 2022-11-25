namespace DocumentModel.Presentation;

/// <summary>
/// Slide Transition.
/// </summary>
public interface ITransition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// spd
  /// </summary>
  public DocumentModel.Presentation.TransitionSpeedKind? Speed { get ; set; }
  
  /// <summary>
  /// dur, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Duration { get ; set; }
  
  /// <summary>
  /// Specifies whether a mouse click will advance the slide.
  /// </summary>
  public System.Boolean? AdvanceOnClick { get ; set; }
  
  /// <summary>
  /// advTm
  /// </summary>
  public System.String? AdvanceAfterTime { get ; set; }
  
}
