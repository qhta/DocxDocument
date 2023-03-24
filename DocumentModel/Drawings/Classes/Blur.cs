namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Blur Class.
/// </summary>
public class Blur: ModelElement
{
  /// <summary>
  ///   Radius
  /// </summary>
  public Int64? Radius { get; set; }

  /// <summary>
  ///   Grow Bounds
  /// </summary>
  public Boolean? Grow { get; set; }
}