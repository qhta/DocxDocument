namespace DocumentModel.Presentation;

/// <summary>
/// Animate Color Behavior.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IFromColor))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IToColor))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IByColor))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
public interface IAnimateColor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
