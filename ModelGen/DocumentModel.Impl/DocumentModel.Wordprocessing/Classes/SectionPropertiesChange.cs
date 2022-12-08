namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
public class SectionPropertiesChangeImpl: ModelElementImpl, SectionPropertiesChange
{
  public DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  public PreviousSectionProperties? PreviousSectionProperties
  {
    get;
    set;
  }
  
}
