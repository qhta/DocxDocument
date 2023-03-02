namespace DocumentModel.Vml;

/// <summary>
///   Rule.
/// </summary>
public record Rule
{
  /// <summary>
  ///   Rule ID
  /// </summary>
  public String? Id { get; set; }

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

  public Collection<Proxy>? Proxies { get; set; }
}