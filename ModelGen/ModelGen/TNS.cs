namespace ModelGen;

/// <summary>
/// Name Kind Selector. Used to get <see cref="TypeInfo"/> full name.
/// </summary>
public record TNS
{
  /// <summary>
  /// Specifies whether to get Target or Origin name.
  /// </summary>
  public bool Target { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Specifies whether to get namespace.
  /// </summary>
  public bool Namespace { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// If namespace is got, specifies whether to get namespace shortcut.
  /// </summary>
  public bool NsShortcut { [DebuggerStepThrough] get; set; }

  [DebuggerStepThrough]
  public TNS (bool target, bool withNamespace, bool nsShortcut)
  {
    Target = target;
    Namespace = withNamespace;
    NsShortcut = nsShortcut;
  }
}