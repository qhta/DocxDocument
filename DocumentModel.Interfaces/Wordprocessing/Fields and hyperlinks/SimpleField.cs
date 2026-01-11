namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Specifies the presence of a simple field at the current location in a WordprocessingML document.
  /// The semantics of this field are defined via its field codes. Simple fields provide a way to insert dynamic content, such as references, calculations, or dates, using a single field code instruction.
  /// </summary>
  public interface SimpleField : ParagraphContent, SdtRunContent, BidirectionalContent, DMM.MathArgumentContent
  {
    
    /// <summary>
    /// Field codes for the simple field, as defined in the WordprocessingML schema (§17.16.5).
    /// </summary>
    public string? Instruction { get; set; }
    
    /// <summary>
    /// Indicates that the parent field should not have its result recalculated, even if a recalculation is requested.
    /// </summary>
    public bool? FieldLock { get; set; }
    
    /// <summary>
    /// Indicates that the field result is invalidated (dirty) and should be updated before display if supported by the application.
    /// </summary>
    public bool? Dirty { get; set; }
    
    /// <summary>
    /// Custom field data associated with the parent field, used to store additional application-defined data.
    /// </summary>
    public string? FieldData { get; set; }
  }