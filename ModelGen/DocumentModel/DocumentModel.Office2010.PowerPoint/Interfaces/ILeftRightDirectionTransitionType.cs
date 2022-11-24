namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the LeftRightDirectionTransitionType Class.
/// </summary>
public interface ILeftRightDirectionTransitionType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionLeftRightDirectionTypeValues? Direction { get ; set; }
  
}
