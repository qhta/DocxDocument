namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Controls Class.
/// </summary>
public interface IControls // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IControl>? Controls { get ; set; }
  
}
