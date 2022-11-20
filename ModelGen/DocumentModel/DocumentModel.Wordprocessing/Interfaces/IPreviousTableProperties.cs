namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBiDiVisual))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCaption))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableDescription))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellMarginDefault))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableJustification))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableLayout))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableLook))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableOverlap))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITablePositionProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableWidth))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellSpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableIndentation))]
public interface IPreviousTableProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// TableStyle.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableStyle? TableStyle { get ; set; }
  
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  public ITablePositionProperties? TablePositionProperties { get ; set; }
  
  /// <summary>
  /// TableOverlap.
  /// </summary>
  public ITableOverlap? TableOverlap { get ; set; }
  
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
  public ITableJustification? TableJustification { get ; set; }
  
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
  
}
