namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Stroke Arrowhead Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeArrowKind
{
  /// <summary>
  ///   No Arrowhead.
  /// </summary>
  None,

  /// <summary>
  ///   Block Arrowhead.
  /// </summary>
  Block,

  /// <summary>
  ///   Classic Arrowhead.
  /// </summary>
  Classic,

  /// <summary>
  ///   Oval Arrowhead.
  /// </summary>
  Oval,

  /// <summary>
  ///   Diamond Arrowhead.
  /// </summary>
  Diamond,

  /// <summary>
  ///   Open Arrowhead.
  /// </summary>
  Open
}