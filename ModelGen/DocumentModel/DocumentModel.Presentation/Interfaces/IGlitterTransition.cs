namespace DocumentModel.Presentation;

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
  public DocumentModel.Presentation.TransitionPatternKind? Pattern { get ; set; }
  
}
