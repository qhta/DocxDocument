namespace DocumentModel.Presentation;

/// <summary>
/// Slide Transition.
/// </summary>
public interface ITransition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// spd
  /// </summary>
  public TransitionSpeedValues? Speed { get ; set; }
  
  /// <summary>
  /// dur, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Duration { get ; set; }
  
  /// <summary>
  /// Specifies whether a mouse click will advance the slide.
  /// </summary>
  public Boolean? AdvanceOnClick { get ; set; }
  
  /// <summary>
  /// advTm
  /// </summary>
  public String? AdvanceAfterTime { get ; set; }
  
}
