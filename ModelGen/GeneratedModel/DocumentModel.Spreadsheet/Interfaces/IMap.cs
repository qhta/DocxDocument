namespace DocumentModel.Spreadsheet;

/// <summary>
/// XML Mapping Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataBinding))]
public interface IMap // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// XML Mapping ID
  /// </summary>
  public uint? ID { get ; set; }
  
  /// <summary>
  /// XML Mapping Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Schema Name
  /// </summary>
  public string? SchemaId { get ; set; }
  
  /// <summary>
  /// Show Validation Errors
  /// </summary>
  public bool? ShowImportExportErrors { get ; set; }
  
  /// <summary>
  /// AutoFit Table on Refresh
  /// </summary>
  public bool? AutoFit { get ; set; }
  
  /// <summary>
  /// Append Data to Table
  /// </summary>
  public bool? AppendData { get ; set; }
  
  /// <summary>
  /// Preserve AutoFilter State
  /// </summary>
  public bool? PreserveAutoFilterState { get ; set; }
  
  /// <summary>
  /// Preserve Cell Formatting
  /// </summary>
  public bool? PreserveFormat { get ; set; }
  
  /// <summary>
  /// XML Mapping.
  /// </summary>
  public DocumentModel.Spreadsheet.IDataBinding? DataBinding { get ; set; }
  
}
