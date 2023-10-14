namespace DocumentModel.Vml.Office;


/// <summary>
///   Rule.
/// </summary>
public partial class Rule
{
  
  /// <summary>
  ///   Rule ID
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Rule Type
  /// </summary>
  public DocumentModel.Vml.Office.RuleKind? Type { get; set; }
  
  
  /// <summary>
  ///   Alignment Rule Type
  /// </summary>
  public DocumentModel.Vml.Office.AlignmentKind? How { get; set; }
  
  
  /// <summary>
  ///   Rule Shape Reference
  /// </summary>
  public String? ShapeReference { get; set; }
  
  public DM.ElementCollection<Proxy>? Items { get; set; }
  
}
