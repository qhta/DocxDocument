namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtRepeatedSection Class.
/// </summary>
public class SdtRepeatedSection: ModelElement
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