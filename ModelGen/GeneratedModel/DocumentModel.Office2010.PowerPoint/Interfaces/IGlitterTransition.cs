namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the GlitterTransition Class.
/// </summary>
public interface IGlitterTransition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionSlideDirection? Direction { get ; set; }
  
  /// <summary>
  /// pattern, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionPattern? Pattern { get ; set; }
  
}
