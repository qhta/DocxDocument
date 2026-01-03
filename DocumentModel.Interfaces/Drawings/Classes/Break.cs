namespace DocumentModel.Drawings;

/// <summary>
///   Text Line Break.
/// </summary>
public interface Break: IModelElement
{
  /// <summary>
  ///   Text Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
}