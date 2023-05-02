namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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