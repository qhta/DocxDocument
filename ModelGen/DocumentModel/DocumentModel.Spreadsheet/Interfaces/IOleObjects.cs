namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the OleObjects Class.
/// </summary>
public interface IOleObjects // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IOleObject>? OleObjects { get ; set; }
  
}
