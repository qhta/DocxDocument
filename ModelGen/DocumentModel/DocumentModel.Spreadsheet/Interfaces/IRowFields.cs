namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowFields Class.
/// </summary>
public interface IRowFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IField>? Fields { get ; set; }
  
}
