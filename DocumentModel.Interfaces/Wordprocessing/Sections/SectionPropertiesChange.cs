namespace DocumentModel.Wordprocessing;

/// <summary>
///   Revision Information for ISection Properties.
/// </summary>
public class SectionPropertiesChange: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   author
  /// </summary>
  public string? Author { get; set; }
  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Previous ISection Properties.
  /// </summary>
  public PreviousSectionProperties? PreviousSectionProperties { get; set; }
}