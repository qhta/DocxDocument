namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.).
  /// This interface provides properties for SDT configuration and end character formatting, enabling advanced management and customization of structured document tags for block-level content.
  /// </summary>
  public interface SdtBlock: IElementCollection<ISdtBlockContent>,
    IStoryContent, ITableCellContent, ISdtBlockContent, ICustomXmlBlockContent, ICommentContent
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