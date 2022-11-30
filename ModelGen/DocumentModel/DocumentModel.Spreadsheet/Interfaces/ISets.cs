namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sets.
/// </summary>
public interface ISets // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tuple Set Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITupleSet>? TupleSets { get ; set; }
  
}
