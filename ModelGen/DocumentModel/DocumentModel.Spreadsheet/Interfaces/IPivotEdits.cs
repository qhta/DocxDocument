namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotEdits Class.
/// </summary>
public interface IPivotEdits // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPivotEdit>? PivotEdits { get ; set; }
  
}
