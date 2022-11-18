namespace DocumentModel.Math;

/// <summary>
/// Border Box Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IHideTop))]
[ChildElementInfo(typeof(DocumentModel.Math.IHideBottom))]
[ChildElementInfo(typeof(DocumentModel.Math.IHideLeft))]
[ChildElementInfo(typeof(DocumentModel.Math.IHideRight))]
[ChildElementInfo(typeof(DocumentModel.Math.IStrikeHorizontal))]
[ChildElementInfo(typeof(DocumentModel.Math.IStrikeVertical))]
[ChildElementInfo(typeof(DocumentModel.Math.IStrikeBottomLeftToTopRight))]
[ChildElementInfo(typeof(DocumentModel.Math.IStrikeTopLeftToBottomRight))]
public interface IBorderBoxProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hide Top Edge.
  /// </summary>
  public IHideTop? HideTop { get ; set; }
  
  /// <summary>
  /// Hide Bottom Edge.
  /// </summary>
  public IHideBottom? HideBottom { get ; set; }
  
  /// <summary>
  /// Hide Left Edge.
  /// </summary>
  public IHideLeft? HideLeft { get ; set; }
  
  /// <summary>
  /// Hide Right Edge.
  /// </summary>
  public IHideRight? HideRight { get ; set; }
  
  /// <summary>
  /// Border Box Strikethrough Horizontal.
  /// </summary>
  public IStrikeHorizontal? StrikeHorizontal { get ; set; }
  
  /// <summary>
  /// Border Box Strikethrough Vertical.
  /// </summary>
  public IStrikeVertical? StrikeVertical { get ; set; }
  
  /// <summary>
  /// Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  public IStrikeBottomLeftToTopRight? StrikeBottomLeftToTopRight { get ; set; }
  
  /// <summary>
  /// Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  public IStrikeTopLeftToBottomRight? StrikeTopLeftToBottomRight { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
