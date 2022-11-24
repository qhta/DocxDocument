namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Picture Fill.
/// </summary>
public interface IBlipFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get ; set; }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public IBlip? Blip { get ; set; }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public ISourceRectangle? SourceRectangle { get ; set; }
  
}
