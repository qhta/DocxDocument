namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the visualizations for a content control, passed to and returned by the Appearance
/// property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontrolappearance?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdContentControlAppearance")]
public enum ContentControlAppearance
{
  /// <summary>
  /// Represents a content control shown as a shaded rectangle or bounding box (with optional title).
  /// </summary>
  [WordInteropEnumValue("wdContentControlBoundingBox")]
  BoundingBox = 0,
  /// <summary>
  /// Represents a content control that is not shown.
  /// </summary>
  [WordInteropEnumValue("wdContentControlTags")]
  Tags = 1,
  /// <summary>
  /// Represents a content control shown as start and end markers.
  /// </summary>
  [WordInteropEnumValue("wdContentControlHidden")]
  Hidden = 2
}
