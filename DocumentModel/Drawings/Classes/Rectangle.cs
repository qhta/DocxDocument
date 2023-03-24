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
  public String? Left { get; set; }

  /// <summary>
  ///   Top
  /// </summary>
  public String? Top { get; set; }

  /// <summary>
  ///   Right
  /// </summary>
  public String? Right { get; set; }

  /// <summary>
  ///   Bottom Position
  /// </summary>
  public String? Bottom { get; set; }
}