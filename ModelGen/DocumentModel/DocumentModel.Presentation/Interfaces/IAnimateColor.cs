namespace DocumentModel.Presentation;

/// <summary>
/// Animate Color Behavior.
/// </summary>
public interface IAnimateColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Color Space
  /// </summary>
  public DocumentModel.Presentation.AnimateColorSpaceKind? ColorSpace { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Presentation.AnimateColorDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public DocumentModel.Presentation.ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// By.
  /// </summary>
  public DocumentModel.Presentation.IByColor? ByColor { get ; set; }
  
  /// <summary>
  /// From.
  /// </summary>
  public DocumentModel.Presentation.IFromColor? FromColor { get ; set; }
  
  /// <summary>
  /// To.
  /// </summary>
  public DocumentModel.Presentation.IToColor? ToColor { get ; set; }
  
}
