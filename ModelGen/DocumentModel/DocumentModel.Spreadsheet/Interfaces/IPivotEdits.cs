namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotEdits Class.
/// </summary>
public interface IPivotEdits // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotEdit>? PivotEdits { get ; set; }
  
}
