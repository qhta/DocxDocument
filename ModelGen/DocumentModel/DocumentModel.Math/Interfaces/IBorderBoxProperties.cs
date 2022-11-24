namespace DocumentModel.Math;

/// <summary>
/// Border Box Properties.
/// </summary>
public interface IBorderBoxProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IControlProperties? ControlProperties { get ; set; }
  
}
