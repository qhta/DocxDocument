namespace DocumentModel.Wordprocessing;


/// <summary>
///   Nested Frameset Definition.
/// </summary>
public partial class Frameset
{
  
  /// <summary>
  ///   Nested Frameset Size.
  /// </summary>
  public String? FrameSize { get; set; }
  
  
  /// <summary>
  ///   Frameset Splitter Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.FramesetSplitbar? FramesetSplitbar { get; set; }
  
  
  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameLayoutValues? FrameLayout { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
