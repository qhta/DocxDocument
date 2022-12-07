namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public interface TablePositionProperties
{
  /// <summary>
  /// Table Vertical Anchor
  /// </summary>
  public VerticalAnchorKind? VerticalAnchor { get ; set; }
  
  /// <summary>
  /// Table Horizontal Anchor
  /// </summary>
  public HorizontalAnchorKind? HorizontalAnchor { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Alignment From Anchor
  /// </summary>
  public HorizontalAlignmentKind? TablePositionXAlignment { get ; set; }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  /// </summary>
  public VerticalAlignmentKind? TablePositionYAlignment { get ; set; }
  
}
