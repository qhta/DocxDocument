namespace DocumentModel.Vml;

/// <summary>
///   Rule.
/// </summary>
public class Rule: ModelElement
{
  /// <summary>
  ///   Rule ID
  /// </summary>
  public string? Id { get; set; }
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
  public string? ShapeReference { get; set; }
  public Collection<Proxy>? Proxies { get; set; }
}