namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Relative Offset Effect.
/// </summary>
public class RelativeOffset: ModelElement
{
  /// <summary>
  ///   Offset X
  /// </summary>
  public Int32? OffsetX { get; set; }

  /// <summary>
  ///   Offset Y
  /// </summary>
  public Int32? OffsetY { get; set; }
}