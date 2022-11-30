namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation References.
/// </summary>
public interface IDataReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Data Consolidation Reference Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IDataReference>? DataReferences { get ; set; }
  
}
