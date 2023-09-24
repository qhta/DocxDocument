namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table-wide properties applied to the current table. These properties affect the appearance of all rows and cells within the parent table but can be overridden by individual table-level exception, row, and cell level properties as defined by each property.
/// </summary>
public partial class TableProperties
{
  
  /// <summary>
  ///   TableStyle.
  /// </summary>
  public String? TableStyle { get; set; }
  
  
  /// <summary>
  ///   TablePositionProperties.
  /// </summary>
  public TablePositionProperties? TablePositionProperties { get; set; }
  
  
  /// <summary>
  ///   TableOverlap.
  /// </summary>
  public TableOverlapKind? TableOverlap { get; set; }
  
  
  /// <summary>
  ///   BiDiVisual.
  /// </summary>
  public Boolean? BiDiVisual { get; set; }
  
  
  /// <summary>
  ///   TableWidth.
  /// </summary>
  public TableWidthType? TableWidth { get; set; }
  
  
  /// <summary>
  ///   TableJustification.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }
  
  
  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  public TableWidthType? TableCellSpacing { get; set; }
  
  
  /// <summary>
  ///   TableIndentation.
  /// </summary>
  public TableIndentation? TableIndentation { get; set; }
  
  
  /// <summary>
  ///   TableBorders.
  /// </summary>
  public TableBorders? TableBorders { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   TableLayout.
  /// </summary>
  public TableLayout? TableLayout { get; set; }
  
  
  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
  
  /// <summary>
  ///   TableLook.
  /// </summary>
  public TableLook? TableLook { get; set; }
  
  
  /// <summary>
  ///   TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public String? TableCaption { get; set; }
  
  
  /// <summary>
  ///   TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public String? TableDescription { get; set; }
  
  
  /// <summary>
  ///   Revision Information for Table Properties.
  /// </summary>
  public TablePropertiesChange? TablePropertiesChange { get; set; }
  
}
