namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a repeated section structured document tag in a Wordprocessing document.
///   This interface provides properties for the section title and options to restrict insertion or deletion of sections, enabling advanced configuration and management of repeated sections in structured document tags.
/// </summary>
public interface SdtRepeatedSection
{
  /// <summary>
  ///   Title of the repeated section, used for identification and display purposes.
  /// </summary>
  public string? SectionTitle { get; set; }

  /// <summary>
  ///   Indicates whether insertion or deletion of sections is disallowed.
  /// </summary>
  public bool? DoNotAllowInsertDeleteSection { get; set; }
}