namespace DocumentModel.Drawings;

/// <summary>
///   Represents a reference to a predecessor drawing element.
/// </summary>
public interface PredecessorDrawingElementReference
{
  /// <summary>
  ///   Identifier of the predecessor drawing element.
  /// </summary>
  public string? Predecessor { get; set; }
}