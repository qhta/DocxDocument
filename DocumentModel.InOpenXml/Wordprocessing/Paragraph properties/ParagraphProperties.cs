namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the properties for a paragraph in a WordprocessingML document.
/// This interface extends <see cref="ExtBaseParagraphProperties"/> and provides properties for paragraph mark run formatting, section properties, and tracked changes to paragraph properties, enabling advanced formatting, layout, and revision management for paragraphs.
/// </summary>
public class ParagraphProperties : ExtBaseParagraphProperties
{
  
  /// <summary>
  /// Run properties for the paragraph mark, specifying formatting for the paragraph end character.
  /// </summary>
  public ParagraphMarkRunProperties? ParagraphMarkRunProperties { get; set; }
  
  /// <summary>
  /// Section properties associated with the paragraph, specifying layout and configuration for the section containing the paragraph.
  /// </summary>
  public SectionProperties? SectionProperties { get; set; }
  
  /// <summary>
  /// Tracked changes to paragraph properties, enabling revision tracking and management of property changes.
  /// </summary>
  public ParagraphPropertiesChange? ParagraphPropertiesChange { get; set; }
}