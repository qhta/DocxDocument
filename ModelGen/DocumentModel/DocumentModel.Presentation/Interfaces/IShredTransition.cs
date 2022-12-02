namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ShredTransition Class.
/// </summary>
public interface IShredTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// pattern, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionShredPatternKind? Pattern { get ; set; }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionInOutDirectionKind? Direction { get ; set; }
  
}
