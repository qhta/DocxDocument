namespace DocumentModel.Presentation;

/// <summary>
/// Animate Color Behavior.
/// </summary>
public interface AnimateColor // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Color Space
  /// </summary>
  public AnimateColorSpaceKind? ColorSpace { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public AnimateColorDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public CommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// By.
  /// </summary>
  public ByColor? ByColor { get ; set; }
  
  /// <summary>
  /// From.
  /// </summary>
  public FromColor? FromColor { get ; set; }
  
  /// <summary>
  /// To.
  /// </summary>
  public ToColor? ToColor { get ; set; }
  
}
