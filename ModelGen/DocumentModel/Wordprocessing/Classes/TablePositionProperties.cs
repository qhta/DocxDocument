namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies information about the current table with regard to floating tables. Floating tables are tables in a document which are not part of the main text flow in the document and are instead absolutely positioned with a specific size and position relative to non-frame content in the current document.
/// </summary>
public partial class TablePositionProperties
{
  
  /// <summary>
  ///   Distance From Left of Table to Text
  /// </summary>
  [SchemaAttr("w:leftFromText")]
  public Int16? LeftFromText { get; set; }
  
  
  /// <summary>
  ///   (Distance From Right of Table to Text
  /// </summary>
  [SchemaAttr("w:rightFromText")]
  public Int16? RightFromText { get; set; }
  
  
  /// <summary>
  ///   Distance From Top of Table to Text
  /// </summary>
  [SchemaAttr("w:topFromText")]
  public Int16? TopFromText { get; set; }
  
  
  /// <summary>
  ///   Distance From Bottom of Table to Text
  /// </summary>
  [SchemaAttr("w:bottomFromText")]
  public Int16? BottomFromText { get; set; }
  
  
  /// <summary>
  ///   Table Vertical Anchor
  /// </summary>
  [SchemaAttr("w:vertAnchor")]
  public DocumentModel.Wordprocessing.VerticalAnchorValues? VerticalAnchor { get; set; }
  
  
  /// <summary>
  ///   Table Horizontal Anchor
  /// </summary>
  [SchemaAttr("w:horzAnchor")]
  public DocumentModel.Wordprocessing.HorizontalAnchorValues? HorizontalAnchor { get; set; }
  
  
  /// <summary>
  ///   Relative Horizontal Alignment From Anchor
  /// </summary>
  [SchemaAttr("w:tblpXSpec")]
  public DocumentModel.Wordprocessing.HorizontalAlignmentValues? TablePositionXAlignment { get; set; }
  
  
  /// <summary>
  ///   Absolute Horizontal Distance From Anchor
  /// </summary>
  [SchemaAttr("w:tblpX")]
  public Int32? TablePositionX { get; set; }
  
  
  /// <summary>
  ///   Relative Vertical Alignment from Anchor
  /// </summary>
  [SchemaAttr("w:tblpYSpec")]
  public DocumentModel.Wordprocessing.VerticalAlignmentValues? TablePositionYAlignment { get; set; }
  
  
  /// <summary>
  ///   Absolute Vertical Distance From Anchor
  /// </summary>
  [SchemaAttr("w:tblpY")]
  public Int32? TablePositionY { get; set; }
  
}
