namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Properties.
/// </summary>
public interface ITableProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TableStyle.
  /// </summary>
  public ITableStyle? TableStyle { get ; set; }
  
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  public ITablePositionProperties? TablePositionProperties { get ; set; }
  
  /// <summary>
  /// TableOverlap.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues>? TableOverlap { get ; set; }
  
  /// <summary>
  /// BiDiVisual.
  /// </summary>
  public IBiDiVisual? BiDiVisual { get ; set; }
  
  /// <summary>
  /// TableWidth.
  /// </summary>
  public ITableWidth? TableWidth { get ; set; }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues>? TableJustification { get ; set; }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public ITableCellSpacing? TableCellSpacing { get ; set; }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public ITableIndentation? TableIndentation { get ; set; }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public ITableBorders? TableBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// TableLayout.
  /// </summary>
  public ITableLayout? TableLayout { get ; set; }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public ITableCellMarginDefault? TableCellMarginDefault { get ; set; }
  
  /// <summary>
  /// TableLook.
  /// </summary>
  public ITableLook? TableLook { get ; set; }
  
  /// <summary>
  /// TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public ITableCaption? TableCaption { get ; set; }
  
  /// <summary>
  /// TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public ITableDescription? TableDescription { get ; set; }
  
  /// <summary>
  /// Revision Information for Table Properties.
  /// </summary>
  public ITablePropertiesChange? TablePropertiesChange { get ; set; }
  
}
