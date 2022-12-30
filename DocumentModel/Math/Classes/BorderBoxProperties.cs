namespace DocumentModel.Math;

/// <summary>
/// Border Box Properties.
/// </summary>
public partial class BorderBoxProperties
{
  /// <summary>
  /// Hide Top Edge.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideTop { get; set; }
  
  /// <summary>
  /// Hide Bottom Edge.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideBottom { get; set; }
  
  /// <summary>
  /// Hide Left Edge.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideLeft { get; set; }
  
  /// <summary>
  /// Hide Right Edge.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideRight { get; set; }
  
  /// <summary>
  /// Border Box Strikethrough Horizontal.
  /// </summary>
  public DocumentModel.Math.BooleanKind? StrikeHorizontal { get; set; }
  
  /// <summary>
  /// Border Box Strikethrough Vertical.
  /// </summary>
  public DocumentModel.Math.BooleanKind? StrikeVertical { get; set; }
  
  /// <summary>
  /// Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  public DocumentModel.Math.BooleanKind? StrikeBottomLeftToTopRight { get; set; }
  
  /// <summary>
  /// Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  public DocumentModel.Math.BooleanKind? StrikeTopLeftToBottomRight { get; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
