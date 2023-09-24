namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ParagraphPropertiesChange Class.
/// </summary>
public partial class ParagraphPropertiesChange
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
  ///   Previous Paragraph Properties.
  /// </summary>
  public ParagraphPropertiesExtended? ParagraphPropertiesExtended { get; set; }
  
}
