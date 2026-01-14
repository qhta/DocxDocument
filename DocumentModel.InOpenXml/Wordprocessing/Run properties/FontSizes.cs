namespace DocumentModel;

  /// <summary>
  /// Represents dual font size values in half-points for text formatting, where the first value applies to regular script and the second to complex script.
  /// If the complex script value is null, it is assumed to be the same as the regular script value. Used for specifying font sizes that can differ between regular and complex scripts in WordprocessingML documents.
  /// </summary>
  public class FontSizes: ModelElement
  {
    
    /// <summary>
    /// Font size value for regular script, specified in half-points.
    /// </summary>
    public HalfPoints? Val { get; set; }
    
    /// <summary>
    /// Font size value for complex script, specified in half-points. If null, the regular script value is used.
    /// </summary>
    public HalfPoints? ValCS { get; set; }
  }