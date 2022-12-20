namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
/// Defines the WordprocessingCanvas Class.
/// </summary>
public partial interface WordprocessingCanvas
{
  /// <summary>
  /// BackgroundFormatting.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingCanvas.BackgroundFormatting? BackgroundFormatting { get; set; }
  
  /// <summary>
  /// WholeFormatting.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingCanvas.WholeFormatting? WholeFormatting { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.WordprocessingShape? WordprocessingShape { get; set; }
  
  public DocumentModel.Drawings.Pictures.Picture? Picture { get; set; }
  
  public DocumentModel.Wordprocessing.ContentPart2? ContentPart { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGroup.WordprocessingGroup? WordprocessingGroup { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingCanvas.GraphicFrameType? GraphicFrameType { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingCanvas.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
