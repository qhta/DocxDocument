namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the GlitterTransition Class.
/// </summary>
public interface IGlitterTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Presentation.TransitionSlideDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// pattern, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.TransitionPatternKind? Pattern { get ; set; }
  
}
