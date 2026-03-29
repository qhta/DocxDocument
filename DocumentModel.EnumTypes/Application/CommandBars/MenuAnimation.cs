namespace DocumentModel.Application;

/// <summary>
/// Specifies animation style for Microsoft Office command bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msomenuanimation?view=office-pia` for Office interop details.
/// </remarks>
public enum MenuAnimation
{
  /// <summary>
  /// No animation.
  /// </summary>
  None,
  /// <summary>
  /// Random animation.
  /// </summary>
  Random,
  /// <summary>
  /// Menus unfold into view.
  /// </summary>
  Unfold,
  /// <summary>
  /// Menus slide into view.
  /// </summary>
  Slide
}
