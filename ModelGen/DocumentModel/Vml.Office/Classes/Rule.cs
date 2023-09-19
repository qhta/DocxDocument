namespace DocumentModel.Vml.Office;


/// <summary>
///   Rule.
/// </summary>
public partial class Rule
{
  
  /// <summary>
  ///   Rule ID
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Rule Type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Vml.Office.RuleValues? Type { get; set; }
  
  
  /// <summary>
  ///   Alignment Rule Type
  /// </summary>
  [SchemaAttr("how")]
  public DocumentModel.Vml.Office.AlignmentValues? How { get; set; }
  
  
  /// <summary>
  ///   Rule Shape Reference
  /// </summary>
  [SchemaAttr("idref")]
  public String? ShapeReference { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Vml.Office.Proxy>? Items { get; set; }
  
}
