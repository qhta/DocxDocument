namespace DocumentModel.Office2010.Word.DrawingCanvas;

/// <summary>
/// Defines the WholeFormatting Class.
/// </summary>
public interface IWholeFormatting // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Outline.
  /// </summary>
  public IOutline? Outline { get ; set; }
  
}
