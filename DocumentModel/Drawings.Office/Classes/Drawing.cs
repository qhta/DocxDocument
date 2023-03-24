namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Drawing Class.
/// </summary>
public class Drawing: ModelElement
{
  /// <summary>
  ///   ShapeTree.
  /// </summary>
  public ShapeTree? ShapeTree { get; set; }
}