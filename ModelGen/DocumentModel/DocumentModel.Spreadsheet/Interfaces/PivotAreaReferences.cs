namespace DocumentModel.Spreadsheet;

/// <summary>
/// References.
/// </summary>
public interface PivotAreaReferences // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PivotAreaReference>? PivotAreaReferences { get ; set; }
  
}
