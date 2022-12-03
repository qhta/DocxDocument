namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotChanges Class.
/// </summary>
public interface PivotChanges // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<PivotChange>? PivotChanges { get ; set; }
  
}
