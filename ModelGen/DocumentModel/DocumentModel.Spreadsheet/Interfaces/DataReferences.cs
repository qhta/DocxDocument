namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation References.
/// </summary>
public interface DataReferences // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Data Consolidation Reference Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<DataReference>? DataReferences { get ; set; }
  
}
