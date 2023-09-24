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
  public FramesetSplitbar? FramesetSplitbar { get; set; }
  
  
  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  public FrameLayoutKind? FrameLayout { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
