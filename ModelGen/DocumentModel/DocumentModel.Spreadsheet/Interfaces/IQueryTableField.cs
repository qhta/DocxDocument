namespace DocumentModel.Spreadsheet;

/// <summary>
/// QueryTable Field.
/// </summary>
public interface IQueryTableField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Data Bound Column
  /// </summary>
  public System.Boolean? DataBound { get ; set; }
  
  /// <summary>
  /// Row Numbers
  /// </summary>
  public System.Boolean? RowNumbers { get ; set; }
  
  /// <summary>
  /// Fill This Formula On Refresh
  /// </summary>
  public System.Boolean? FillFormulas { get ; set; }
  
  /// <summary>
  /// Clipped Column
  /// </summary>
  public System.Boolean? Clipped { get ; set; }
  
  /// <summary>
  /// Table Column Id
  /// </summary>
  public System.UInt32? TableColumnId { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
