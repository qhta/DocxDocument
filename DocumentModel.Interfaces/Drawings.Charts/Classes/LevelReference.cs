namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LevelReference Class.
/// </summary>
public interface LevelReference: IModelElement
{
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public string? SequenceOfReferences { get; set; }
}