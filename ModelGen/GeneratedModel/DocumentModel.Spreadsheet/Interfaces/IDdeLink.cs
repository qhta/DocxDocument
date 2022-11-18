namespace DocumentModel.Spreadsheet;

/// <summary>
/// DDE Connection.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDdeItems))]
public interface IDdeLink // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Service name
  /// </summary>
  public string? DdeService { get ; set; }
  
  /// <summary>
  /// Topic for DDE server
  /// </summary>
  public string? DdeTopic { get ; set; }
  
  /// <summary>
  /// DDE Items Collection.
  /// </summary>
  public IDdeItems? DdeItems { get ; set; }
  
}
