namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Properties.
/// </summary>
public interface IPreviousTableProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TableStyle.
  /// </summary>
  public System.String? TableStyle { get ; set; }
  
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.ITablePositionProperties? TablePositionProperties { get ; set; }
  
  /// <summary>
  /// TableOverlap.
  /// </summary>
  public DocumentModel.Wordprocessing.TableOverlapKind? TableOverlap { get ; set; }
  
  /// <summary>
  /// BiDiVisual.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? BiDiVisual { get ; set; }
  
  /// <summary>
  /// TableWidth.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableWidthType? TableWidth { get ; set; }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get ; set; }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableWidthType? TableCellSpacing { get ; set; }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableIndentation? TableIndentation { get ; set; }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableBorders? TableBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.IShading? Shading { get ; set; }
  
  /// <summary>
  /// TableLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableLayout? TableLayout { get ; set; }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableCellMarginDefault? TableCellMarginDefault { get ; set; }
  
  /// <summary>
  /// TableLook.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableLook? TableLook { get ; set; }
  
  /// <summary>
  /// TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public System.String? TableCaption { get ; set; }
  
  /// <summary>
  /// TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public System.String? TableDescription { get ; set; }
  
}
