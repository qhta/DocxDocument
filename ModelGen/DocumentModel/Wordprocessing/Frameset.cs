namespace DocumentModel.Wordprocessing;


/// <summary>
///   Nested Frameset Definition.
/// </summary>
public partial class Frameset
{
  
  /// <summary>
  ///   Nested Frameset Size.
  /// </summary>
  public DMW.FrameSize? FrameSize { get; set; }
  
  
  /// <summary>
  ///   Frameset Splitter Properties.
  /// </summary>
  public DMW.FramesetSplitbar? FramesetSplitbar { get; set; }
  
  
  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  public DMW.FrameLayoutKind? FrameLayout { get; set; }
  
}
