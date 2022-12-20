namespace DocumentModel.Vml;

/// <summary>
/// Rule.
/// </summary>
public partial interface Rule
{
  /// <summary>
  /// Rule ID
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public DocumentModel.Vml.RuleKind? Type { get; set; }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public DocumentModel.Vml.AlignmentKind? How { get; set; }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  public String? ShapeReference { get; set; }
  
  public Collection<DocumentModel.Vml.Proxy>? Proxies { get; set; }
  
}
