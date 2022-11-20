namespace DocumentModel.Wordprocessing;

/// <summary>
/// Frameset Splitter Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColor))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFlatBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWidth))]
public class FramesetSplitbar: IFramesetSplitbar
{
  /// <summary>
  /// Frameset Splitter Width.
  /// </summary>
  public DocumentModel.Wordprocessing.IWidth? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Frameset Splitter Color.
  /// </summary>
  public DocumentModel.Wordprocessing.IColor? Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Do Not Display Frameset Splitters.
  /// </summary>
  public INoBorder? NoBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Frameset Splitter Border Style.
  /// </summary>
  public IFlatBorders? FlatBorders
  {
    get;
    set;
  }
  
}
