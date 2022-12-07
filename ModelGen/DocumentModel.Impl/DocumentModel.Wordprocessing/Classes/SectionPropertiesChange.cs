namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
public class SectionPropertiesChangeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange>, SectionPropertiesChange
{
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  public PreviousSectionProperties? PreviousSectionProperties
  {
    get;
    set;
  }
  
}
