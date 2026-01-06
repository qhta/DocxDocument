namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtRepeatedSection Class.
/// </summary>
public interface SdtRepeatedSection
{
  /// <summary>
  ///   SectionTitle.
  /// </summary>
  public string? SectionTitle { get; set; }
  /// <summary>
  ///   DoNotAllowInsertDeleteSection.
  /// </summary>
  public bool? DoNotAllowInsertDeleteSection { get; set; }
}