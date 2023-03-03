namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Resize Handle
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ResizeHandlesStringKind
{
  /// <summary>
  ///   Exact.
  /// </summary>
  Exact,

  /// <summary>
  ///   Relative.
  /// </summary>
  Relative
}