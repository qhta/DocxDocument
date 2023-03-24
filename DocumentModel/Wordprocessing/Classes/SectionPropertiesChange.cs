namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Revision Information for Section Properties.
/// </summary>
public class SectionPropertiesChange: ModelElement, ISectionPropertiesElement
{
  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Previous Section Properties.
  /// </summary>
  public PreviousSectionProperties? PreviousSectionProperties { get; set; }
}