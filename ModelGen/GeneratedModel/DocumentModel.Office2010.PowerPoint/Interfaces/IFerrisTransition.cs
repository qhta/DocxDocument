namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the FerrisTransition Class.
/// </summary>
public interface IFerrisTransition // : DocumentFormat.OpenXml.Office2010.PowerPoint.LeftRightDirectionTransitionType
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionLeftRightDirectionType? Direction { get ; set; }
  
}
