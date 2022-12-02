namespace DocumentModel.Spreadsheet;

/// <summary>
/// References.
/// </summary>
public interface IPivotAreaReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPivotAreaReference>? PivotAreaReferences { get ; set; }
  
}
