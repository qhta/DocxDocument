namespace DocumentModel.Drawings;

/// <summary>
///   Defines the PredecessorDrawingElementReference interface.
/// </summary>
public interface PredecessorDrawingElementReference: IModelElement
{
  /// <summary>
  ///   pred
  /// </summary>
  public string? Pred { get; set; }
}