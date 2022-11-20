namespace DocumentModel.Office2010.Word.DrawingCanvas;

/// <summary>
/// Defines the WordprocessingCanvas Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingCanvas.IBackgroundFormatting))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingCanvas.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingCanvas.IWholeFormatting))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Pictures.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IContentPart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingCanvas.IGraphicFrameType))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.IWordprocessingGroup))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.IWordprocessingShape))]
public class WordprocessingCanvas: IWordprocessingCanvas
{
  /// <summary>
  /// BackgroundFormatting.
  /// </summary>
  public IBackgroundFormatting? BackgroundFormatting
  {
    get;
    set;
  }
  
  /// <summary>
  /// WholeFormatting.
  /// </summary>
  public IWholeFormatting? WholeFormatting
  {
    get;
    set;
  }
  
}
