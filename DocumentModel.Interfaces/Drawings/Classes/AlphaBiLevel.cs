namespace DocumentModel.Drawings;

/// <summary>
///   Defines the AlphaBiLevel interface.
/// </summary>
public interface AlphaBiLevel: IModelElement
{
  /// <summary>
  ///   Threshold
  /// </summary>
  public Int32? Threshold { get; set; }
}