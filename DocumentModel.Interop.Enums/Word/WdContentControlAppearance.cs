namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the visualizations for a content control, passed to and returned by the Appearance
/// property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontrolappearance?view=office-pia` for Office interop details.
/// </remarks>
public enum WdContentControlAppearance
{
  /// <summary>
  /// Constants that represent the visualizations for a content control, passed to and returned by the Appearance
  /// property.
  /// </summary>
  BoundingBox = 0,
  /// <summary>
  /// Constants that represent the visualizations for a content control, passed to and returned by the Appearance
  /// property.
  /// </summary>
  Tags = 1,
  /// <summary>
  /// Constants that represent the visualizations for a content control, passed to and returned by the Appearance
  /// property.
  /// </summary>
  Hidden = 2
}
