namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query table fields.
/// </summary>
public interface IQueryTableFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IQueryTableField>? QueryTableFields { get ; set; }
  
}
