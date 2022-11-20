namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableStyles Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITableStyle))]
public interface ITableStyles // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Style Count
  /// </summary>
  public uint? Count { get ; set; }
  
  /// <summary>
  /// Default Table Style
  /// </summary>
  public string? DefaultTableStyle { get ; set; }
  
  /// <summary>
  /// Default Pivot Style
  /// </summary>
  public string? DefaultPivotStyle { get ; set; }
  
}
