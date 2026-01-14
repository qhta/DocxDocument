namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a frameset definition in a WordprocessingML document.
  /// This interface extends <see cref="ElementCollection{FramesetItem}"/> and provides properties for advisory information, nested frameset size, splitter properties, and layout, enabling advanced configuration and management of frameset structures within documents.
  /// </summary>
  public interface Frameset: IElementCollection<FramesetItem>
  {
    
    /// <summary>
    /// Advisory information about the frameset, typically used as a title or description.
    /// </summary>
    public String? Title { get; set; }
    
    /// <summary>
    /// Size of the nested frameset, specified as a width or height value depending on the frameset orientation.
    /// </summary>
    public UInt32? FrameSize { get; set; }
    
    /// <summary>
    /// Properties for the frameset splitter, enabling customization of the splitter appearance and behavior.
    /// </summary>
    public FramesetSplitbar? FramesetSplitbar { get; set; }
    
    /// <summary>
    /// Layout of the frameset, specifying how frames are arranged within the frameset.
    /// </summary>
    public FrameLayoutKind? FrameLayout { get; set; }
  }