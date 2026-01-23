namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents revision information for section properties in a Wordprocessing document.
/// This class provides properties for author, date, annotation identifier, and previous section properties, enabling tracking and management of section property revisions.
/// </summary>
public partial class SectionPropertiesChange : IdentifiedChange<DXW.SectionPropertiesChange>
{
  /// <summary>
  /// Previous section properties before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousSectionProperties? PreviousSectionProperties { get; set; }
}