namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Picture Fill.
/// </summary>
public interface IBlipFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public System.Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawing.IBlip? Blip { get ; set; }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IRelativeRectangleType? SourceRectangle { get ; set; }
  
}
