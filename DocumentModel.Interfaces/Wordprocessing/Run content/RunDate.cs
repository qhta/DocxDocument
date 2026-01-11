namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a date block at the current location in the run content of a WordprocessingML document.
  /// A date block is a non-editable region of text that displays the current date filtered through specified date properties. This legacy construct is used for compatibility with older word processors and should not be produced unless consumed from an existing document. The date block is displayed using the primary editing language of the host application, regardless of the parent run's language property.
  /// </summary>
  public interface RunDate : RunContent
  {
    
    /// <summary>
    /// Specifies which part of the date is presented (e.g., full date, year, month, day).
    /// </summary>
    [DefaultValue(DateItem.Full)]
    public DateItem Part { get; set; }
    
    /// <summary>
    /// Indicates whether the date is displayed in long format. If false, a short format is used by default.
    /// </summary>
    [DefaultValue(false)]
    public bool IsLong { get; set; }
  }