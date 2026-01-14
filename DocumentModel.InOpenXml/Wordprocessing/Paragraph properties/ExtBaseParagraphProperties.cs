namespace DocumentModel.Wordprocessing;

/// <summary>
/// Extended base interface for paragraph properties, containing additional formatting and metadata properties not applied to <see cref="BaseParagraphProperties"/>.
/// This interface provides support for paragraph style identification, HTML div mapping, and conditional table style formatting, enabling advanced paragraph layout and compatibility features in WordprocessingML documents.
/// </summary>
public class ExtBaseParagraphProperties : BaseParagraphProperties
{
  
  /// <summary>
  /// Style ID of the paragraph style used to format the contents of this paragraph.
  /// </summary>
  public string? ParagraphStyleId { get; set; }
  
  /// <summary>
  /// HTML div ID for the paragraph, used to map the paragraph to a specific HTML div when saving as HTML. Preserves fidelity of existing HTML documents in WordprocessingML format.
  /// </summary>
  public string? DivId { get; set; }
  
  /// <summary>
  /// Set of conditional table style formatting properties applied to this paragraph, if contained within a table cell.
  /// </summary>
  public ConditionalFormatFlags? ConditionalFormatStyle { get; set; }
}