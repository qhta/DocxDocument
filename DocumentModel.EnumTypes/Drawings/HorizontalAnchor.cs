namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the horizontal alignment of text Iin a text frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohorizontalanchor?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum HorizontalAnchor
{
  /// <summary>
  /// Return value Ionly; indicates a combination of the other states.
  /// </summary>
  HorizontalAnchorMixed = -2,
  /// <summary>
  /// No alignment.
  /// </summary>
  AnchorNone = 1,
  /// <summary>
  /// Text is centered horizontally.
  /// </summary>
  AnchorCenter = 2
}

