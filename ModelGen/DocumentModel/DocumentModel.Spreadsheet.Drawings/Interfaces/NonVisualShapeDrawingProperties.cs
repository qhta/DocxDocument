namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Connection Non-Visual Shape Properties.
/// </summary>
public interface NonVisualShapeDrawingProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Text Box
  /// </summary>
  public Boolean? TextBox { get ; set; }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public DocumentModel.Drawings.ShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
