namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousSectionProperties))]
public class SectionPropertiesChange: ISectionPropertiesChange
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author
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
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  public IPreviousSectionProperties? PreviousSectionProperties
  {
    get;
    set;
  }
  
}
