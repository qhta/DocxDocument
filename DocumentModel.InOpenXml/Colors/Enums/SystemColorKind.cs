namespace DocumentModel.Drawings;
/// <summary>
///   System Color Value
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.SystemColorValues))]
public enum SystemColorKind
{
  /// <summary>
  ///   Scroll Bar System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ScrollBar))]
  ScrollBar,
  /// <summary>
  ///   Background System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.Background))]
  Background,
  /// <summary>
  ///   Active Caption System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ActiveCaption))]
  ActiveCaption,
  /// <summary>
  ///   Inactive Caption System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InactiveCaption))]
  InactiveCaption,
  /// <summary>
  ///   Menu System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.Menu))]
  Menu,
  /// <summary>
  ///   Window System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.Window))]
  Window,
  /// <summary>
  ///   Window Frame System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.WindowFrame))]
  WindowFrame,
  /// <summary>
  ///   Menu Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.MenuText))]
  MenuText,
  /// <summary>
  ///   Window Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.WindowText))]
  WindowText,
  /// <summary>
  ///   Caption Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.CaptionText))]
  CaptionText,
  /// <summary>
  ///   Active Border System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ActiveBorder))]
  ActiveBorder,
  /// <summary>
  ///   Inactive Border System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InactiveBorder))]
  InactiveBorder,
  /// <summary>
  ///   Application Workspace System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ApplicationWorkspace))]
  ApplicationWorkspace,
  /// <summary>
  ///   Highlight System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.Highlight))]
  Highlight,
  /// <summary>
  ///   Highlight Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.HighlightText))]
  HighlightText,
  /// <summary>
  ///   Button Face System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ButtonFace))]
  ButtonFace,
  /// <summary>
  ///   Button Shadow System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ButtonShadow))]
  ButtonShadow,
  /// <summary>
  ///   Gray Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.GrayText))]
  GrayText,
  /// <summary>
  ///   Button Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ButtonText))]
  ButtonText,
  /// <summary>
  ///   Inactive Caption Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InactiveCaptionText))]
  InactiveCaptionText,
  /// <summary>
  ///   Button Highlight System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ButtonHighlight))]
  ButtonHighlight,
  /// <summary>
  ///   3D Dark System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ThreeDDarkShadow))]
  ThreeDDarkShadow,
  /// <summary>
  ///   3D Light System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ThreeDLight))]
  ThreeDLight,
  /// <summary>
  ///   Info Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InfoText))]
  InfoText,
  /// <summary>
  ///   Info Back System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InfoBack))]
  InfoBack,
  /// <summary>
  ///   Hot Light System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.HotLight))]
  HotLight,
  /// <summary>
  ///   Gradient Active Caption System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.GradientActiveCaption))]
  GradientActiveCaption,
  /// <summary>
  ///   Gradient Inactive Caption System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.GradientInactiveCaption))]
  GradientInactiveCaption,
  /// <summary>
  ///   Menu Highlight System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.MenuHighlight))]
  MenuHighlight,
  /// <summary>
  ///   Menu Bar System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.MenuBar))]
  MenuBar
}