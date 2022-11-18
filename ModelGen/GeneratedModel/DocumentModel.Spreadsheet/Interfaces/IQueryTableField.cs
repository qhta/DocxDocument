namespace DocumentModel.Spreadsheet;

/// <summary>
/// QueryTable Field.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IQueryTableField // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Id
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Data Bound Column
  /// </summary>
  public bool? DataBound { get ; set; }
  
  /// <summary>
  /// Row Numbers
  /// </summary>
  public bool? RowNumbers { get ; set; }
  
  /// <summary>
  /// Fill This Formula On Refresh
  /// </summary>
  public bool? FillFormulas { get ; set; }
  
  /// <summary>
  /// Clipped Column
  /// </summary>
  public bool? Clipped { get ; set; }
  
  /// <summary>
  /// Table Column Id
  /// </summary>
  public uint? TableColumnId { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
