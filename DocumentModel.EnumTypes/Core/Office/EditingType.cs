namespace DocumentMode.Office;

/// <summary>
/// Specifies the editing type of a node.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoeditingtype?view=office-pia` for Office interop details.
/// </remarks>
public enum EditingType
{
  /// <summary>
  /// Editing type is appropriate to the segments being connected.
  /// </summary>
  Auto,
  /// <summary>
  /// Corner node.
  /// </summary>
  Corner,
  /// <summary>
  /// Smooth node.
  /// </summary>
  Smooth,
  /// <summary>
  /// Symmetric node.
  /// </summary>
  Symmetric
}
