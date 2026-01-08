namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a reference to a level in a data source.
/// </summary>
public interface LevelReference
{
  /// <summary>
  ///   Sequence of references defining the level data.
  /// </summary>
  public string? SequenceOfReferences { get; set; }
}