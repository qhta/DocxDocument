namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ISystem Color Value
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SystemColorKind
{
  /// <summary>
  ///   Scroll Bar ISystem Color.
  /// </summary>
  ScrollBar,

  /// <summary>
  ///   Background ISystem Color.
  /// </summary>
  Background,

  /// <summary>
  ///   Active Caption ISystem Color.
  /// </summary>
  ActiveCaption,

  /// <summary>
  ///   Inactive Caption ISystem Color.
  /// </summary>
  InactiveCaption,

  /// <summary>
  ///   Menu ISystem Color.
  /// </summary>
  Menu,

  /// <summary>
  ///   IWindow ISystem Color.
  /// </summary>
  IWindow,

  /// <summary>
  ///   IWindow IFrame ISystem Color.
  /// </summary>
  WindowFrame,

  /// <summary>
  ///   Menu Text ISystem Color.
  /// </summary>
  MenuText,

  /// <summary>
  ///   IWindow Text ISystem Color.
  /// </summary>
  WindowText,

  /// <summary>
  ///   Caption Text ISystem Color.
  /// </summary>
  CaptionText,

  /// <summary>
  ///   Active IBorder ISystem Color.
  /// </summary>
  ActiveBorder,

  /// <summary>
  ///   Inactive IBorder ISystem Color.
  /// </summary>
  InactiveBorder,

  /// <summary>
  ///   IApplication Workspace ISystem Color.
  /// </summary>
  ApplicationWorkspace,

  /// <summary>
  ///   Highlight ISystem Color.
  /// </summary>
  Highlight,

  /// <summary>
  ///   Highlight Text ISystem Color.
  /// </summary>
  HighlightText,

  /// <summary>
  ///   Button Face ISystem Color.
  /// </summary>
  ButtonFace,

  /// <summary>
  ///   Button Shadow ISystem Color.
  /// </summary>
  ButtonShadow,

  /// <summary>
  ///   Gray Text ISystem Color.
  /// </summary>
  GrayText,

  /// <summary>
  ///   Button Text ISystem Color.
  /// </summary>
  ButtonText,

  /// <summary>
  ///   Inactive Caption Text ISystem Color.
  /// </summary>
  InactiveCaptionText,

  /// <summary>
  ///   Button Highlight ISystem Color.
  /// </summary>
  ButtonHighlight,

  /// <summary>
  ///   3D Dark ISystem Color.
  /// </summary>
  ThreeDDarkShadow,

  /// <summary>
  ///   3D Light ISystem Color.
  /// </summary>
  ThreeDLight,

  /// <summary>
  ///   Info Text ISystem Color.
  /// </summary>
  InfoText,

  /// <summary>
  ///   Info Back ISystem Color.
  /// </summary>
  InfoBack,

  /// <summary>
  ///   Hot Light ISystem Color.
  /// </summary>
  HotLight,

  /// <summary>
  ///   Gradient Active Caption ISystem Color.
  /// </summary>
  GradientActiveCaption,

  /// <summary>
  ///   Gradient Inactive Caption ISystem Color.
  /// </summary>
  GradientInactiveCaption,

  /// <summary>
  ///   Menu Highlight ISystem Color.
  /// </summary>
  MenuHighlight,

  /// <summary>
  ///   Menu Bar ISystem Color.
  /// </summary>
  MenuBar
}
