namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnFields Class.
/// </summary>
public interface IColumnFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IField>? Fields { get ; set; }
  
}
