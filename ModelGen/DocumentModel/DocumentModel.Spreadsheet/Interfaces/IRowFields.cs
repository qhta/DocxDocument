namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowFields Class.
/// </summary>
public interface IRowFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IField>? Fields { get ; set; }
  
}
