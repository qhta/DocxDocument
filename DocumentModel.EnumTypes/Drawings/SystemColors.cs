namespace DocumentModel.Drawings;
/// <summary>
///   ISystem Color Value
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.SystemColorValues))]
public enum SystemColors
{
  /// <summary>
  ///   Scroll Bar ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ScrollBar))]
  ScrollBar,
  /// <summary>
  ///   Background ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.Background))]
  Background,
  /// <summary>
  ///   Active Caption ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ActiveCaption))]
  ActiveCaption,
  /// <summary>
  ///   Inactive Caption ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InactiveCaption))]
  InactiveCaption,
  /// <summary>
  ///   Menu ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.Menu))]
  Menu,
  /// <summary>
  ///   IWindow ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.IWindow))]
  IWindow,
  /// <summary>
  ///   IWindow IFrame ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.WindowFrame))]
  WindowFrame,
  /// <summary>
  ///   Menu Text ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.MenuText))]
  MenuText,
  /// <summary>
  ///   IWindow Text ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.WindowText))]
  WindowText,
  /// <summary>
  ///   Caption Text ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.CaptionText))]
  CaptionText,
  /// <summary>
  ///   Active IBorder ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ActiveBorder))]
  ActiveBorder,
  /// <summary>
  ///   Inactive IBorder ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InactiveBorder))]
  InactiveBorder,
  /// <summary>
  ///   IApplication Workspace ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ApplicationWorkspace))]
  ApplicationWorkspace,
  /// <summary>
  ///   Highlight ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.Highlight))]
  Highlight,
  /// <summary>
  ///   Highlight Text ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.HighlightText))]
  HighlightText,
  /// <summary>
  ///   Button Face ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ButtonFace))]
  ButtonFace,
  /// <summary>
  ///   Button Shadow ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ButtonShadow))]
  ButtonShadow,
  /// <summary>
  ///   Gray Text ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.GrayText))]
  GrayText,
  /// <summary>
  ///   Button Text ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ButtonText))]
  ButtonText,
  /// <summary>
  ///   Inactive Caption Text ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InactiveCaptionText))]
  InactiveCaptionText,
  /// <summary>
  ///   Button Highlight ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ButtonHighlight))]
  ButtonHighlight,
  /// <summary>
  ///   3D Dark ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ThreeDDarkShadow))]
  ThreeDDarkShadow,
  /// <summary>
  ///   3D Light ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.ThreeDLight))]
  ThreeDLight,
  /// <summary>
  ///   Info Text ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InfoText))]
  InfoText,
  /// <summary>
  ///   Info Back ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.InfoBack))]
  InfoBack,
  /// <summary>
  ///   Hot Light ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.HotLight))]
  HotLight,
  /// <summary>
  ///   Gradient Active Caption ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.GradientActiveCaption))]
  GradientActiveCaption,
  /// <summary>
  ///   Gradient Inactive Caption ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.GradientInactiveCaption))]
  GradientInactiveCaption,
  /// <summary>
  ///   Menu Highlight ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.MenuHighlight))]
  MenuHighlight,
  /// <summary>
  ///   Menu Bar ISystem Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SystemColorValues.MenuBar))]
  MenuBar
}
