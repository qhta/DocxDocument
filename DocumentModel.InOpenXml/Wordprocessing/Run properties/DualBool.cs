namespace DocumentModel;

  /// <summary>
  /// Represents a dual boolean value for text formatting, where the first value applies to regular script and the second to complex script.
  /// If the complex script value is null, it is assumed to be the same as the regular script value. Used for properties that can differ between regular and complex scripts in WordprocessingML documents.
  /// </summary>
  public interface DualBool : TypedModelElement
  {
    
    /// <summary>
    /// Boolean value for regular script text formatting.
    /// </summary>
    public bool? Val { get; set; }
    
    /// <summary>
    /// Boolean value for complex script text formatting. If null, the regular script value is used.
    /// </summary>
    public bool? CS { get; set; }
  }