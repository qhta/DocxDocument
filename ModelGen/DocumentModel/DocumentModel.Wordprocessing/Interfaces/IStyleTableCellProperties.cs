namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Cell Properties.
/// </summary>
public interface IStyleTableCellProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public INoWrap? NoWrap { get ; set; }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public ITableCellMargin? TableCellMargin { get ; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues>? TableCellVerticalAlignment { get ; set; }
  
}
