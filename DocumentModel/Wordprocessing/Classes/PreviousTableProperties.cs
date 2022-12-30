namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Properties.
/// </summary>
public partial class PreviousTableProperties
{
  /// <summary>
  /// TableStyle.
  /// </summary>
  public String? TableStyle { get; set; }
  
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.TablePositionProperties? TablePositionProperties { get; set; }
  
  /// <summary>
  /// TableOverlap.
  /// </summary>
  public DocumentModel.Wordprocessing.TableOverlapKind? TableOverlap { get; set; }
  
  /// <summary>
  /// BiDiVisual.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? BiDiVisual { get; set; }
  
  /// <summary>
  /// TableWidth.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableWidth { get; set; }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get; set; }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing { get; set; }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation { get; set; }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders { get; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  /// <summary>
  /// TableLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayout? TableLayout { get; set; }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
  /// <summary>
  /// TableLook.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLook? TableLook { get; set; }
  
  /// <summary>
  /// TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public String? TableCaption { get; set; }
  
  /// <summary>
  /// TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public String? TableDescription { get; set; }
  
}
