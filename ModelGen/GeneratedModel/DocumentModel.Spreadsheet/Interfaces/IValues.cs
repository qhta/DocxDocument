namespace DocumentModel.Spreadsheet;

/// <summary>
/// DDE Name Values.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IValue))]
public interface IValues // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
