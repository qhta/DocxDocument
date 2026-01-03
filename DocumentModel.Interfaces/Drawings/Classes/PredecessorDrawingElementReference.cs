namespace DocumentModel.Drawings;

/// <summary>
///   Defines the PredecessorDrawingElementReference interface.
/// </summary>
public interface PredecessorDrawingElementReference: IModelElement
{
  /// <summary>
  ///   pred, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Pred { get; set; }
}