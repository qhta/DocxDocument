namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotChanges Class.
/// </summary>
public interface IPivotChanges // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IPivotChange>? PivotChanges { get ; set; }
  
}
