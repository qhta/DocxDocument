namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public partial class MarkupType
{
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [SchemaAttr("w:id")]
  public String? Id { get; set; }
  
}
