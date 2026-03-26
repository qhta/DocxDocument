namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the visualizations for a content control, passed to and returned by the Appearance
/// property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontrolappearance?view=office-pia` for Office interop details.
/// </remarks>
public enum ContentControlAppearance
{
  /// <summary>
  /// Represents a content control shown as a shaded rectangle or bounding box (with optional title).
  /// </summary>
  BoundingBox = 0,
  /// <summary>
  /// Represents a content control that is not shown.
  /// </summary>
  Tags = 1,
  /// <summary>
  /// Represents a content control shown as start and end markers.
  /// </summary>
  Hidden = 2
}
