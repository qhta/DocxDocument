namespace ModelGen;

/// <summary>
/// Options for namespace and type display.
/// </summary>
public record DisplayOptions
{
  /// <summary>
  /// Determines which namespaces to display.
  /// </summary>
  public NTS NamespaceTypeSelector { get; set; } = NTS.Target;
  
  /// <summary>
  /// Specifies Namespaces do display. May be namespaces or wildcard patterns.
  /// </summary>
  public String[]? Namespaces { get; set; }

    /// <summary>
  /// Determines which namespaces to display.
  /// </summary>
  public TKS TypeKindSelector { get; set; }

  /// <summary>
  /// Specifies Namespaces do display. May be namespaces or wildcard patterns.
  /// </summary>
  public String[]? Typenames { get; set; }

  /// <summary>
  /// Determines what type data to display.
  /// </summary>
  public TDS TypeDataSelector { get; set; }

  /// <summary>
  /// Limit list wyszczególnianych elementów
  /// </summary>
  public int ListLimit {get; set; } = 10;

  /// <summary>
  /// Specifies relationships semantics selected to display or to exclude depending on TDS.
  /// </summary>
  public Semantics[]? SemanticsFilter { get; set; }

}
