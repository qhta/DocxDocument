namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the FlythroughTransition Class.
/// </summary>
public interface IFlythroughTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Presentation.TransitionInOutDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// hasBounce, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? HasBounce { get ; set; }
  
}
