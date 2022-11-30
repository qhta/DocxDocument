namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFields Class.
/// </summary>
public interface IDataFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Data Items Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IDataField>? DataFields { get ; set; }
  
}
