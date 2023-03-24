namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Miter Line Join.
/// </summary>
public class Miter: ModelElement
{
  /// <summary>
  ///   Miter Join Limit
  /// </summary>
  public Int32? Limit { get; set; }
}