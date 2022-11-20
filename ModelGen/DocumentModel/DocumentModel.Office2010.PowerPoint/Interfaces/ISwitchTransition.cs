namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SwitchTransition Class.
/// </summary>
public interface ISwitchTransition // : DocumentFormat.OpenXml.Office2010.PowerPoint.LeftRightDirectionTransitionType
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionLeftRightDirectionTypeValues? Direction { get ; set; }
  
}
