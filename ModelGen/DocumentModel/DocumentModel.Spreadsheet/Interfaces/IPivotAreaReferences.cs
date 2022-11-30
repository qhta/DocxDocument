namespace DocumentModel.Spreadsheet;

/// <summary>
/// References.
/// </summary>
public interface IPivotAreaReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotAreaReference>? PivotAreaReferences { get ; set; }
  
}
