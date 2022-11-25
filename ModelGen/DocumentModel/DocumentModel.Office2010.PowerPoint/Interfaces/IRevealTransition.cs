namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the RevealTransition Class.
/// </summary>
public interface IRevealTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// thruBlk, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ThroughBlack { get ; set; }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.TransitionLeftRightDirectionTypeKind? Direction { get ; set; }
  
}
