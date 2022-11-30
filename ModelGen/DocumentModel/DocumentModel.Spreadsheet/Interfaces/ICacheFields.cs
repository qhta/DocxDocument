namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFields Class.
/// </summary>
public interface ICacheFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICacheField>? CacheFields { get ; set; }
  
}
