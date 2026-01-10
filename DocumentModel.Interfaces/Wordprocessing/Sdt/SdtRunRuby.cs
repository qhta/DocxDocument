namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Counterpart of <see cref="SdtRun"/> interface in the Ruby domain.
  /// This interface represents a collection of ruby content elements and provides properties for structured document tag configuration and end character formatting, enabling advanced handling of ruby annotations in structured document tags.
  /// </summary>
  public interface SdtRunRuby : ElementCollection<RubyContent>, RubyContent
  {
    
    /// <summary>
    /// Specifies the set of properties applied to this structured document tag.
    /// </summary>
    public SdtProperties? SdtProperties { get; set; }
    
    /// <summary>
    /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
    /// </summary>
    public SdtEndCharProperties? SdtEndCharProperties { get; set; }
  }