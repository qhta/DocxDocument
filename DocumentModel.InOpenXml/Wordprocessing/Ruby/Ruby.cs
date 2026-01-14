namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a phonetic guide (ruby text) at the current location in the document.
  /// A phonetic guide is a run of content with base text at the normal baseline and phonetic guide text displayed above it. This construct is typically used to map words in one language to another phonetically, enabling pronunciation aids for East Asian scripts and other language learning scenarios.
  /// </summary>
  public interface Ruby : RunContent, RubyContent
  {
    
    /// <summary>
    /// Properties for the phonetic guide, specifying formatting and alignment options for the ruby text.
    /// </summary>
    public RubyProperties? RubyProperties { get; set; }
    
    /// <summary>
    /// Phonetic guide text content, displayed above the base text.
    /// </summary>
    public RubyContent? RubyContent { get; set; }
    
    /// <summary>
    /// Base text for the phonetic guide, displayed at the normal baseline location.
    /// </summary>
    public RubyBase? RubyBase { get; set; }
  }