namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the PrismTransition Class.
/// </summary>
public interface IPrismTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Presentation.TransitionSlideDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// isContent, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? IsContent { get ; set; }
  
  /// <summary>
  /// isInverted, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? IsInverted { get ; set; }
  
}
