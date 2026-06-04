namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies animation style for Microsoft Office command bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msomenuanimation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoMenuAnimation")]
public enum MenuAnimation
{
  /// <summary>
  /// No animation.
  /// </summary>
  [InteropEnumValue("msoMenuAnimationNone")]
  None,
  /// <summary>
  /// Random animation.
  /// </summary>
  [InteropEnumValue("msoMenuAnimationRandom")]
  Random,
  /// <summary>
  /// Menus unfold into view.
  /// </summary>
  [InteropEnumValue("msoMenuAnimationUnfold")]
  Unfold,
  /// <summary>
  /// Menus slide into view.
  /// </summary>
  [InteropEnumValue("msoMenuAnimationSlide")]
  Slide
}
