namespace DocumentModel.Wordprocessing;


/// <summary>
///   Nested Frameset Definition.
/// </summary>
public partial class Frameset
{
  
  /// <summary>
  ///   Nested Frameset Size.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameSize? FrameSize { get; set; }
  
  
  /// <summary>
  ///   Frameset Splitter Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.FramesetSplitbar? FramesetSplitbar { get; set; }
  
  
  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameLayoutKind? FrameLayout { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
