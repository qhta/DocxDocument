namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Miter ILine Join.
/// </summary>
public class Miter: ModelElement
{
  /// <summary>
  ///   Miter Join Limit
  /// </summary>
  public Int32? Limit { get; set; }
}
