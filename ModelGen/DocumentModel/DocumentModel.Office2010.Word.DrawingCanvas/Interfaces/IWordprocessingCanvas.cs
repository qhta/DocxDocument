namespace DocumentModel.Office2010.Word.DrawingCanvas;

/// <summary>
/// Defines the WordprocessingCanvas Class.
/// </summary>
public interface IWordprocessingCanvas // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// BackgroundFormatting.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? BackgroundFormatting { get ; set; }
  
  /// <summary>
  /// WholeFormatting.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingCanvas.IWholeFormatting? WholeFormatting { get ; set; }
  
}
