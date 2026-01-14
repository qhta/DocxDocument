namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents revision information for section properties in a Wordprocessing document.
/// This interface provides properties for author, date, annotation identifier, and previous section properties, enabling tracking and management of section property revisions.
/// </summary>
public interface SectionPropertiesChange : ISectionPropertiesContent
{
  
  /// <summary>
  /// Author of the change to the section properties.
  /// </summary>
  public string? Author { get; set; }
  
  /// <summary>
  /// Date of the change to the section properties.
  /// </summary>
  public DateTime? Date { get; set; }
  
  /// <summary>
  /// Annotation identifier for the change, used to uniquely identify the revision.
  /// </summary>
  public string? Id { get; set; }
  
  /// <summary>
  /// Previous section properties before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousSectionProperties? PreviousSectionProperties { get; set; }
}