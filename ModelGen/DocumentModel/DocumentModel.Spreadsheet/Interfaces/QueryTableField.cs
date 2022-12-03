namespace DocumentModel.Spreadsheet;

/// <summary>
/// QueryTable Field.
/// </summary>
public interface QueryTableField // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Field Id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Data Bound Column
  /// </summary>
  public Boolean? DataBound { get ; set; }
  
  /// <summary>
  /// Row Numbers
  /// </summary>
  public Boolean? RowNumbers { get ; set; }
  
  /// <summary>
  /// Fill This Formula On Refresh
  /// </summary>
  public Boolean? FillFormulas { get ; set; }
  
  /// <summary>
  /// Clipped Column
  /// </summary>
  public Boolean? Clipped { get ; set; }
  
  /// <summary>
  /// Table Column Id
  /// </summary>
  public UInt32? TableColumnId { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
