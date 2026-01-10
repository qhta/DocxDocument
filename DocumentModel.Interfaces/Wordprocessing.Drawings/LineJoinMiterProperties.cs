namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the properties for a miter line join in a drawing element within a Wordprocessing document.
/// This interface provides configuration for the miter limit, which determines how sharp a mitered corner can be before it is beveled.
/// </summary>
public interface LineJoinMiterProperties
{
  /// <summary>
  /// The miter limit value, specifying the maximum allowed ratio of miter length to line width before the join is beveled.
  /// </summary>
  public Int32? Limit { get; set; }
}