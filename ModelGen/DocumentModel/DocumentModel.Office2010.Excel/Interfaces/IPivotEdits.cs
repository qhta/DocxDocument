namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotEdits Class.
/// </summary>
public interface IPivotEdits // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IPivotEdit>? PivotEdits { get ; set; }
  
}
