namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DdeValues Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IValue))]
public interface IDdeValues // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rows
  /// </summary>
  public uint? Rows { get ; set; }
  
  /// <summary>
  /// Columns
  /// </summary>
  public uint? Columns { get ; set; }
  
}
