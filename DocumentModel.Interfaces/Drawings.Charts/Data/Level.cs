namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a level in a multi-level string cache, containing string points.
/// </summary>
public interface Level: CollectionItem, ElementCollection<StringPoint>
{
}