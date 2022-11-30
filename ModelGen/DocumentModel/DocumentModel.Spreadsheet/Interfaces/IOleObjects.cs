namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the OleObjects Class.
/// </summary>
public interface IOleObjects // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IOleObject>? OleObjects { get ; set; }
  
}
