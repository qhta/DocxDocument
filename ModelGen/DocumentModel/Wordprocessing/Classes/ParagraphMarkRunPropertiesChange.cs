namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public partial class ParagraphMarkRunPropertiesChange
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
  ///   dateUtc, this property is only available in Microsoft365 and later.
  /// </summary>
  public DateTime? DateUtc { get; set; }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties { get; set; }
  
}
