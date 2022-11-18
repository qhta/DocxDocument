namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Columns Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColumn))]
public interface IColumns // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Equal Column Widths
  /// </summary>
  public bool? EqualWidth { get ; set; }
  
  /// <summary>
  /// Spacing Between Equal Width Columns
  /// </summary>
  public string? Space { get ; set; }
  
  /// <summary>
  /// Number of Equal Width Columns
  /// </summary>
  public short? ColumnCount { get ; set; }
  
  /// <summary>
  /// Draw Line Between Columns
  /// </summary>
  public bool? Separator { get ; set; }
  
}
