namespace DocumentModel.Math;

/// <summary>
/// Border Box Properties.
/// </summary>
public interface IBorderBoxProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hide Top Edge.
  /// </summary>
  public BooleanKind? HideTop { get ; set; }
  
  /// <summary>
  /// Hide Bottom Edge.
  /// </summary>
  public BooleanKind? HideBottom { get ; set; }
  
  /// <summary>
  /// Hide Left Edge.
  /// </summary>
  public BooleanKind? HideLeft { get ; set; }
  
  /// <summary>
  /// Hide Right Edge.
  /// </summary>
  public BooleanKind? HideRight { get ; set; }
  
  /// <summary>
  /// Border Box Strikethrough Horizontal.
  /// </summary>
  public BooleanKind? StrikeHorizontal { get ; set; }
  
  /// <summary>
  /// Border Box Strikethrough Vertical.
  /// </summary>
  public BooleanKind? StrikeVertical { get ; set; }
  
  /// <summary>
  /// Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  public BooleanKind? StrikeBottomLeftToTopRight { get ; set; }
  
  /// <summary>
  /// Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  public BooleanKind? StrikeTopLeftToBottomRight { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
