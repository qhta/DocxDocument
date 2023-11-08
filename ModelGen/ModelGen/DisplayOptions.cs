namespace ModelGen;

/// <summary>
/// Options for namespace and type display.
/// </summary>
public record DisplayOptions
{
  /// <summary>
  /// Specifies Namespaces do display. May be namespaces or wildcard patterns.
  /// </summary>
  public String[]? Namespaces { [DebuggerStepThrough] get; set; }
  
  /// <summary>
  /// Specifies Namespaces do display. May be namespaces or wildcard patterns.
  /// </summary>
  public String[]? Typenames { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Determines which namespaces to display.
  /// </summary>
  public NTS NamespaceTypeSelector { [DebuggerStepThrough] get; set; } = NTS.Target;
  
  /// <summary>
  /// Determines which namespaces to display.
  /// </summary>
  public TKS TypeKindSelector { [DebuggerStepThrough] get; set; } = TKS.Any;

  /// <summary>
  /// Determines which namespaces to display.
  /// </summary>
  public MSS TypeStatusSelector { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Determines what type data to display.
  /// </summary>
  public TDS TypeDataSelector { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Determines which members to display.
  /// </summary>
  public MSS MemberStatusSelector { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Limits list of enumerated types
  /// </summary>
  public int TypesLimit {get; set; }

  /// <summary>
  /// Limit list of enumerated details
  /// </summary>
  public int DetailsLimit {get; set; } = 10;

  /// <summary>
  /// Limit line length for summary
  /// </summary>
  public int LineWidthLimit {get; set; } = 120;

  /// <summary>
  /// Specifies relationships semantics selected to display or to exclude depending on TDS.
  /// </summary>
  public Semantics[]? SemanticsFilter { [DebuggerStepThrough] get; set; }

}
