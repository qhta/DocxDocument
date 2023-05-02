namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Text Rectangle.
/// </summary>
public class Rectangle: ModelElement
{
  /// <summary>
  ///   Left
  /// </summary>
  public string? Left { get; set; }

  /// <summary>
  ///   Top
  /// </summary>
  public string? Top { get; set; }

  /// <summary>
  ///   Right
  /// </summary>
  public string? Right { get; set; }

  /// <summary>
  ///   Bottom Position
  /// </summary>
  public string? Bottom { get; set; }
}