namespace DocumentModel.Office2010.Word.DrawingCanvas;

/// <summary>
/// Defines the WordprocessingCanvas Class.
/// </summary>
public interface IWordprocessingCanvas // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// BackgroundFormatting.
  /// </summary>
  public IBackgroundFormatting? BackgroundFormatting { get ; set; }
  
  /// <summary>
  /// WholeFormatting.
  /// </summary>
  public IWholeFormatting? WholeFormatting { get ; set; }
  
}
