namespace DocumentModel.Vml;

/// <summary>
///   Shape Grouping History.
/// </summary>
public record RegroupTable
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  public Collection<Entry>? Entries { get; set; }
}