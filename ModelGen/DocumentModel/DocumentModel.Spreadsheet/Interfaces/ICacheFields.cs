namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFields Class.
/// </summary>
public interface ICacheFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ICacheField>? CacheFields { get ; set; }
  
}
