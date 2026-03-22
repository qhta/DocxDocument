namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies animation style for Microsoft Office command bars.
/// </summary>
public enum MsoMenuAnimation
{
  /// <summary>
  /// No animation.
  /// </summary>
  msoMenuAnimationNone,
  /// <summary>
  /// Random animation.
  /// </summary>
  msoMenuAnimationRandom,
  /// <summary>
  /// Menus unfold into view.
  /// </summary>
  msoMenuAnimationUnfold,
  /// <summary>
  /// Menus slide into view.
  /// </summary>
  msoMenuAnimationSlide
}
