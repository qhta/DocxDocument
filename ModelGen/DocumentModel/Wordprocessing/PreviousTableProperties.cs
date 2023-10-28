namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a previous set of table properties, the modifications to which shall be attributed to a revision by a particular author and at a particular time. This element contains the table property settings which were previously in place before a specific set of revisions by one author. These properties affect the appearance of all rows and cells within the parent table but can be overridden by individual table-level exception, row, and cell level properties, as defined by each property.
/// </summary>
public partial class PreviousTableProperties
{
  
  /// <summary>
  ///   TableStyle.
  /// </summary>
  public DMW.TableStyle? TableStyle { get; set; }
  
  
  /// <summary>
  ///   TablePositionProperties.
  /// </summary>
  public DMW.TablePositionProperties? TablePositionProperties { get; set; }
  
  
  /// <summary>
  ///   TableOverlap.
  /// </summary>
  public DMW.TableOverlapKind? TableOverlap { get; set; }
  
  
  /// <summary>
  ///   BiDiVisual.
  /// </summary>
  public DMW.BiDiVisual? BiDiVisual { get; set; }
  
  
  /// <summary>
  ///   TableWidth.
  /// </summary>
  public DMW.TableWidth? TableWidth { get; set; }
  
  
  /// <summary>
  ///   TableJustification.
  /// </summary>
  public DMW.TableRowAlignmentKind? TableJustification { get; set; }
  
  
  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  public DMW.TableCellSpacing? TableCellSpacing { get; set; }
  
  
  /// <summary>
  ///   TableIndentation.
  /// </summary>
  public DMW.TableIndentation? TableIndentation { get; set; }
  
  
  /// <summary>
  ///   TableBorders.
  /// </summary>
  public DMW.TableBorders? TableBorders { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public DMW.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   TableLayout.
  /// </summary>
  public DMW.TableLayout? TableLayout { get; set; }
  
  
  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  public DMW.TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
  
  /// <summary>
  ///   TableLook.
  /// </summary>
  public DMW.TableLook? TableLook { get; set; }
  
  
  /// <summary>
  ///   TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.TableCaption? TableCaption { get; set; }
  
  
  /// <summary>
  ///   TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW.TableDescription? TableDescription { get; set; }
  
}
