namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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