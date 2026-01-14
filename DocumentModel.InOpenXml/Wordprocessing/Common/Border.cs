namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a border definition for elements in a WordprocessingML document.
  /// This class provides properties for border style, color, width, spacing, shadow, and frame effect, enabling advanced formatting and visual separation of document content.
  /// </summary>
  public class Border: CollectionItem
  {
    
    /// <summary>
    /// Border style, specifying the type of border (e.g., single, double, dashed).
    /// </summary>
    public BorderKind? Type { get; set; }
    
    /// <summary>
    /// Border color, specified as an abstract color value.
    /// </summary>
    public IColor? Color { get; set; }
    
    /// <summary>
    /// Border width, specified in twips.
    /// </summary>
    public Twips? Width { get; set; }
    
    /// <summary>
    /// Border spacing measurement, specifying the space between the border and the content.
    /// </summary>
    public Twips? Space { get; set; }
    
    /// <summary>
    /// Indicates whether the border has a shadow effect.
    /// </summary>
    public bool? Shadow { get; set; }
    
    /// <summary>
    /// Indicates whether the border has a frame effect.
    /// </summary>
    public bool? Frame { get; set; }
  }