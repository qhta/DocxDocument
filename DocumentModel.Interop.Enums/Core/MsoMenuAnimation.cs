namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies animation style for Microsoft Office command bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msomenuanimation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoMenuAnimation))]
public enum MenuAnimation
{
  /// <summary>
  /// No animation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMenuAnimation.msoMenuAnimationNone))]
  None,
  /// <summary>
  /// Random animation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMenuAnimation.msoMenuAnimationRandom))]
  Random,
  /// <summary>
  /// Menus unfold into view.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMenuAnimation.msoMenuAnimationUnfold))]
  Unfold,
  /// <summary>
  /// Menus slide into view.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMenuAnimation.msoMenuAnimationSlide))]
  Slide
}
