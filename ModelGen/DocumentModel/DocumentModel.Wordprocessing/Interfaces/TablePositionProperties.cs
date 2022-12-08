namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public interface TablePositionProperties
{
  /// <summary>
  /// Distance From Left of Table to Text
  /// </summary>
  public Int16? LeftFromText { get ; set; }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  /// </summary>
  public Int16? RightFromText { get ; set; }
  
  /// <summary>
  /// Distance From Top of Table to Text
  /// </summary>
  public Int16? TopFromText { get ; set; }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  /// </summary>
  public Int16? BottomFromText { get ; set; }
  
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
  /// Absolute Horizontal Distance From Anchor
  /// </summary>
  public Int32? TablePositionX { get ; set; }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  /// </summary>
  public VerticalAlignmentKind? TablePositionYAlignment { get ; set; }
  
  /// <summary>
  /// Absolute Vertical Distance From Anchor
  /// </summary>
  public Int32? TablePositionY { get ; set; }
  
}
