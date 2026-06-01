namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   String IPoint.
/// </summary>
public class StringPoint: ModelElement
{
  /// <summary>
  ///   IIndex
  /// </summary>
  public UInt32? IIndex { get; set; }

  /// <summary>
  ///   Text Value.
  /// </summary>
  public string? NumericValue { get; set; }
}
