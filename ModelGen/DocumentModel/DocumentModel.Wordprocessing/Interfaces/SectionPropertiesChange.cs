namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
public interface SectionPropertiesChange
{
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  public PreviousSectionProperties? PreviousSectionProperties { get ; set; }
  
}
