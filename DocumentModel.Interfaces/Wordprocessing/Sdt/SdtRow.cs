namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the presence of a structured document tag around a single table row.
/// This interface represents a collection of structured document tag row content and provides properties for tag configuration and end character formatting, enabling advanced handling of structured document tags for table rows.
/// </summary>
public interface SdtRow : ElementCollection<SdtRowContent>, TableContent, SdtRowContent
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