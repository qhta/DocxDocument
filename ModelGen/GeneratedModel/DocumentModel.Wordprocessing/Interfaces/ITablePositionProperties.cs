namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public interface ITablePositionProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Distance From Left of Table to Text
  /// </summary>
  public short? LeftFromText { get ; set; }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  /// </summary>
  public short? RightFromText { get ; set; }
  
  /// <summary>
  /// Distance From Top of Table to Text
  /// </summary>
  public short? TopFromText { get ; set; }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  /// </summary>
  public short? BottomFromText { get ; set; }
  
  /// <summary>
  /// Table Vertical Anchor
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAnchor? VerticalAnchor { get ; set; }
  
  /// <summary>
  /// Table Horizontal Anchor
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAnchor? HorizontalAnchor { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Alignment From Anchor
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAlignment? TablePositionXAlignment { get ; set; }
  
  /// <summary>
  /// Absolute Horizontal Distance From Anchor
  /// </summary>
  public int? TablePositionX { get ; set; }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAlignment? TablePositionYAlignment { get ; set; }
  
  /// <summary>
  /// Absolute Vertical Distance From Anchor
  /// </summary>
  public int? TablePositionY { get ; set; }
  
}
