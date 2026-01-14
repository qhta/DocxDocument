namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a complex field character in the text run of a WordprocessingML document.
  /// A complex field character is a special character that delimits the start and end of a complex field or separates its field codes from its current field result. Two complex field characters are required: a start character, which specifies the beginning of a complex field within the document content, and an end character, which specifies the end of a complex field. This syntax allows multiple fields to be embedded within each other. These two items are separated by the optional separator character, which defines the end of the field codes and the beginning of the field contents. When the separator character is missing, it specifies that the field has no result.
  /// </summary>
  public interface FieldChar : IRunContent
  {
    
    /// <summary>
    /// Field character type, specifying whether this is a start, separator, or end character for the complex field.
    /// </summary>
    public FieldCharKind? FieldCharType { get; set; }
    
    /// <summary>
    /// Indicates whether the field should not be recalculated.
    /// </summary>
    public bool? FieldLock { get; set; }
    
    /// <summary>
    /// Indicates whether the field result is invalidated and needs to be updated.
    /// </summary>
    public bool? Dirty { get; set; }
    
    /// <summary>
    /// Custom field data associated with the field character.
    /// </summary>
    public string? FieldData { get; set; }
    
    /// <summary>
    /// Form field properties associated with the field character.
    /// </summary>
    public FormFieldData? FormFieldData { get; set; }
    
    /// <summary>
    /// Previous numbering field properties associated with the field character.
    /// </summary>
    public NumberingChange? NumberingChange { get; set; }
  }