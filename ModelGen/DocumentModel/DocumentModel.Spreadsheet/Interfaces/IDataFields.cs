namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFields Class.
/// </summary>
public interface IDataFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Data Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IDataField>? DataFields { get ; set; }
  
}
