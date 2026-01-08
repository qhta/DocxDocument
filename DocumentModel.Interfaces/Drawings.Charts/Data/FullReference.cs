namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a full reference to a data source range.
/// </summary>
public interface FullReference
{
  /// <summary>
  ///   Sequence of references defining the full data range.
  /// </summary>
  public string? SequenceOfReferences { get; set; }
}