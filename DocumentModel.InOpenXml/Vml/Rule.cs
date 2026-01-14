namespace DocumentModel.Vml;

/// <summary>
/// Represents a VML rule, including rule type, alignment, shape reference, and proxies.
/// </summary>
public class Rule: CollectionItem
{
  /// <summary>
  /// Rule identifier string.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  /// Specifies the rule type.
  /// </summary>
  public RuleKind? Type { get; set; }

  /// <summary>
  /// Specifies the alignment rule type.
  /// </summary>
  public AlignmentKind? How { get; set; }

  /// <summary>
  /// Reference to the shape associated with this rule.
  /// </summary>
  public string? ShapeReference { get; set; }

  /// <summary>
  /// Proxies collection associated with this rule.
  /// </summary>
  public Proxies? Proxies { get; set; }
}