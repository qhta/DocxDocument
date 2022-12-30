namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
public partial class SectionPropertiesChange
{
  /// <summary>
  /// author
  /// </summary>
  public String? Author { get; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousSectionProperties? PreviousSectionProperties { get; set; }
  
}
