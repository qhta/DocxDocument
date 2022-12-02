namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotChanges Class.
/// </summary>
public interface IPivotChanges // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotChange>? PivotChanges { get ; set; }
  
}
