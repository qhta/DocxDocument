namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtRepeatedSection Class.
/// </summary>
public class SdtRepeatedSection: ModelElement
{
  /// <summary>
  ///   SectionTitle.
  /// </summary>
  public String? SectionTitle { get; set; }

  /// <summary>
  ///   DoNotAllowInsertDeleteSection.
  /// </summary>
  public Boolean? DoNotAllowInsertDeleteSection { get; set; }
}