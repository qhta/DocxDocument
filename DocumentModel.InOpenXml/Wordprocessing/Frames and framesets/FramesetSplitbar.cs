namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the properties for a frameset splitter in a WordprocessingML document.
  /// This interface provides properties for splitter width, color, border visibility, and border style, enabling advanced customization of the appearance and behavior of frameset splitters within document layouts.
  /// </summary>
  public class FramesetSplitbar: ModelElement
  {
    
    /// <summary>
    /// Width of the frameset splitter, specified in twips.
    /// </summary>
    public Twips? Width { get; set; }
    
    /// <summary>
    /// Color of the frameset splitter, specified as an abstract color value.
    /// </summary>
    public IColor? Color { get; set; }
    
    /// <summary>
    /// Indicates whether frameset splitters should not be displayed (no border).
    /// </summary>
    public bool? NoBorder { get; set; }
    
    /// <summary>
    /// Indicates whether the frameset splitter uses a flat border style.
    /// </summary>
    public bool? FlatBorders { get; set; }
  }