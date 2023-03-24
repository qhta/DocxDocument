namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Break.
/// </summary>
public class Break: ModelElement
{
  /// <summary>
  ///   Index of Operator to Align To
  /// </summary>
  public Int64? AlignAt { get; set; }

  /// <summary>
  ///   Index of Operator to Align To
  /// </summary>
  public Int64? Val { get; set; }
}