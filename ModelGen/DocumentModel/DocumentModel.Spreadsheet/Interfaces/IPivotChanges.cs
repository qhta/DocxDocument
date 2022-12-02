namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotChanges Class.
/// </summary>
public interface IPivotChanges // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPivotChange>? PivotChanges { get ; set; }
  
}
