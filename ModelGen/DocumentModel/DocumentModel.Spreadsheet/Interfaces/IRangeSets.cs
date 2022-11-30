namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Sets.
/// </summary>
public interface IRangeSets // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference and Page Item Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IRangeSet>? RangeSets { get ; set; }
  
}
