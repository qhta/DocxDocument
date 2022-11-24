namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Worksheet Drawing.
/// </summary>
public interface IWorksheetDrawing // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the DrawingsPart associated with this element.
  /// </summary>
  public DrawingsPart? DrawingsPart { get ; set; }
  
}
