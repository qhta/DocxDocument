namespace DocumentModel.Wordprocessing;


/// <summary>
///   Comment Content.
/// </summary>
public partial class Comment
{
  
  /// <summary>
  ///   initials
  /// </summary>
  [SchemaAttr("w:initials")]
  public String? Initials { get; set; }
  
  
  /// <summary>
  ///   author
  /// </summary>
  [SchemaAttr("w:author")]
  public String? Author { get; set; }
  
  
  /// <summary>
  ///   date
  /// </summary>
  [SchemaAttr("w:date")]
  public DateTime? Date { get; set; }
  
  
  /// <summary>
  ///   dateUtc, this property is only available in Microsoft365 and later.
  /// </summary>
  [SchemaAttr("w16du:dateUtc")]
  public DateTime? DateUtc { get; set; }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [SchemaAttr("w:id")]
  public String? Id { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
