namespace DocumentModel.Drawings;
/// <summary>
///   System Color Value
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.SystemColorValues))]
public enum SystemColors
{
  /// <summary>
  ///   Scroll Bar System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ScrollBar))]
  ScrollBar,
  /// <summary>
  ///   Background System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.Background))]
  Background,
  /// <summary>
  ///   Active Caption System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ActiveCaption))]
  ActiveCaption,
  /// <summary>
  ///   Inactive Caption System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.InactiveCaption))]
  InactiveCaption,
  /// <summary>
  ///   Menu System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.Menu))]
  Menu,
  /// <summary>
  ///   IWindow System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.Window))]
  Window,
  /// <summary>
  ///   IWindow IFrame System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.WindowFrame))]
  WindowFrame,
  /// <summary>
  ///   Menu Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.MenuText))]
  MenuText,
  /// <summary>
  ///   IWindow Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.WindowText))]
  WindowText,
  /// <summary>
  ///   Caption Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.CaptionText))]
  CaptionText,
  /// <summary>
  ///   Active Border System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ActiveBorder))]
  ActiveBorder,
  /// <summary>
  ///   Inactive Border System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.InactiveBorder))]
  InactiveBorder,
  /// <summary>
  ///   IApplication Workspace System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ApplicationWorkspace))]
  ApplicationWorkspace,
  /// <summary>
  ///   Highlight System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.Highlight))]
  Highlight,
  /// <summary>
  ///   Highlight Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.HighlightText))]
  HighlightText,
  /// <summary>
  ///   Button Face System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ButtonFace))]
  ButtonFace,
  /// <summary>
  ///   Button Shadow System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ButtonShadow))]
  ButtonShadow,
  /// <summary>
  ///   Gray Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.GrayText))]
  GrayText,
  /// <summary>
  ///   Button Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ButtonText))]
  ButtonText,
  /// <summary>
  ///   Inactive Caption Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.InactiveCaptionText))]
  InactiveCaptionText,
  /// <summary>
  ///   Button Highlight System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ButtonHighlight))]
  ButtonHighlight,
  /// <summary>
  ///   3D Dark System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ThreeDDarkShadow))]
  ThreeDDarkShadow,
  /// <summary>
  ///   3D Light System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.ThreeDLight))]
  ThreeDLight,
  /// <summary>
  ///   Info Text System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.InfoText))]
  InfoText,
  /// <summary>
  ///   Info Back System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.InfoBack))]
  InfoBack,
  /// <summary>
  ///   Hot Light System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.HotLight))]
  HotLight,
  /// <summary>
  ///   Gradient Active Caption System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.GradientActiveCaption))]
  GradientActiveCaption,
  /// <summary>
  ///   Gradient Inactive Caption System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.GradientInactiveCaption))]
  GradientInactiveCaption,
  /// <summary>
  ///   Menu Highlight System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.MenuHighlight))]
  MenuHighlight,
  /// <summary>
  ///   Menu Bar System Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SystemColorValues.MenuBar))]
  MenuBar
}
