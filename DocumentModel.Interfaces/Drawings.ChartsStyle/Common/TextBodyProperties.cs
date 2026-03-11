namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Describes the properties for formatting and layout of text bodies in chart elements, including rotation, overflow, insets, columns, anchoring, and 3D effects.
/// </summary>
public interface TextBodyProperties
{
  /// <summary>
  /// Rotation angle applied to the text body.
  /// </summary>
  public Int32? Rotation { get; set; }

  /// <summary>
  /// Indicates whether paragraph spacing is used between paragraphs.
  /// </summary>
  public bool? UseParagraphSpacing { get; set; }

  /// <summary>
  /// Vertical overflow behavior for text that exceeds the text box height.
  /// </summary>
  public TextVerticalOverflowKind? VerticalOverflow { get; set; }

  /// <summary>
  /// Horizontal overflow behavior for text that exceeds the text box width.
  /// </summary>
  public TextHorizontalOverflowKind? HorizontalOverflow { get; set; }

  /// <summary>
  /// Vertical text orientation setting.
  /// </summary>
  public TextVerticalKind? Vertical { get; set; }

  /// <summary>
  /// Wrapping type for text within the text body.
  /// </summary>
  public DMW.TextWrapping? Wrap { get; set; }

  /// <summary>
  /// Left inset distance between the text and the text box edge.
  /// </summary>
  public Int32? LeftInset { get; set; }

  /// <summary>
  /// Top inset distance between the text and the text box edge.
  /// </summary>
  public Int32? TopInset { get; set; }

  /// <summary>
  /// Right inset distance between the text and the text box edge.
  /// </summary>
  public Int32? RightInset { get; set; }

  /// <summary>
  /// Bottom inset distance between the text and the text box edge.
  /// </summary>
  public Int32? BottomInset { get; set; }

  /// <summary>
  /// Number of columns in the text body.
  /// </summary>
  public Int32? ColumnCount { get; set; }

  /// <summary>
  /// Space between columns in the text body.
  /// </summary>
  public Int32? ColumnSpacing { get; set; }

  /// <summary>
  /// Indicates if columns are arranged right-to-left.
  /// </summary>
  public bool? RightToLeftColumns { get; set; }

  /// <summary>
  /// Indicates if the text body is derived from WordArt.
  /// </summary>
  public bool? FromWordArt { get; set; }

  /// <summary>
  /// Anchoring type for the text body within the shape.
  /// </summary>
  public TextAnchoringKind? Anchor { get; set; }

  /// <summary>
  /// Indicates if the anchor is centered within the text body.
  /// </summary>
  public bool? AnchorCenter { get; set; }

  /// <summary>
  /// Indicates if anti-aliasing is forced for the text.
  /// </summary>
  public bool? ForceAntiAlias { get; set; }

  /// <summary>
  /// Indicates if the text is rendered upright.
  /// </summary>
  public bool? UpRight { get; set; }

  /// <summary>
  /// Indicates if compatible line spacing is used.
  /// </summary>
  public bool? CompatibleLineSpacing { get; set; }

  /// <summary>
  /// Preset text shape wrapping option.
  /// </summary>
  public PresetTextWrap? PresetTextWrap { get; set; }

  /// <summary>
  /// Indicates if auto-fit is disabled for the text body.
  /// </summary>
  public bool? NoAutoFit { get; set; }

  /// <summary>
  /// Normal auto-fit settings for the text body.
  /// </summary>
  public NormalAutoFit? NormalAutoFit { get; set; }

  /// <summary>
  /// Indicates if shape auto-fit is enabled for the text body.
  /// </summary>
  public bool? ShapeAutoFit { get; set; }

  /// <summary>
  /// 3D scene type applied to the text body.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// 3D shape type applied to the text body.
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }

  /// <summary>
  /// Flat text formatting for the text body.
  /// </summary>
  public FlatText? FlatText { get; set; }

  /// <summary>
  /// Extension list for additional text body properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}