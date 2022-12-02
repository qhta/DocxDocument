namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFields Class.
/// </summary>
public interface IPivotFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPivotField>? PivotFields { get ; set; }
  
}
