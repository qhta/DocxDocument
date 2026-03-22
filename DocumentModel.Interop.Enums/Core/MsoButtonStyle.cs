namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style of a command bar button.
/// </summary>
public enum MsoButtonStyle
{
  /// <summary>
  /// Default behavior.
  /// </summary>
  msoButtonAutomatic = 0,
  /// <summary>
  /// Image only.
  /// </summary>
  msoButtonIcon = 1,
  /// <summary>
  /// Text only.
  /// </summary>
  msoButtonCaption = 2,
  /// <summary>
  /// Image and text, with text to the right of image. msoButtonIconAndWrapCaption7 Image with text wrapped and to
  /// the right of the image. msoButtonIconAndCaptionBelow11 Image with text below.
  /// </summary>
  msoButtonIconAndCaption = 3,
  /// <summary>
  /// Specifies the style of a command bar button.
  /// </summary>
  msoButtonIconAndWrapCaption = 7,
  /// <summary>
  /// Specifies the style of a command bar button.
  /// </summary>
  msoButtonIconAndCaptionBelow = 11,
  /// <summary>
  /// Text only, centered and wrapped. msoButtonIconAndWrapCaptionBelow15 Image with text wrapped below image.
  /// </summary>
  msoButtonWrapCaption = 14,
  /// <summary>
  /// Specifies the style of a command bar button.
  /// </summary>
  msoButtonIconAndWrapCaptionBelow = 15
}
