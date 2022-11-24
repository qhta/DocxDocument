namespace DocumentModel.Presentation;

/// <summary>
/// Animate Color Behavior.
/// </summary>
public interface IAnimateColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Color Space
  /// </summary>
  public AnimateColorSpaceValues? ColorSpace { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public AnimateColorDirectionValues? Direction { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// By.
  /// </summary>
  public IByColor? ByColor { get ; set; }
  
  /// <summary>
  /// From.
  /// </summary>
  public IFromColor? FromColor { get ; set; }
  
  /// <summary>
  /// To.
  /// </summary>
  public IToColor? ToColor { get ; set; }
  
}
