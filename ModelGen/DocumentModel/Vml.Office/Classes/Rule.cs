namespace DocumentModel.Vml.Office;


/// <summary>
///   Rule.
/// </summary>
public partial class Rule
{
  
  /// <summary>
  ///   Rule ID
  /// </summary>
  public HexInt? Id { get; set; }
  
  
  /// <summary>
  ///   Rule Type
  /// </summary>
  public RuleKind? Type { get; set; }
  
  
  /// <summary>
  ///   Alignment Rule Type
  /// </summary>
  public AlignmentKind? How { get; set; }
  
  
  /// <summary>
  ///   Rule Shape Reference
  /// </summary>
  public String? ShapeReference { get; set; }
  
  public ElementCollection<Proxy>? Items { get; set; }
  
}
