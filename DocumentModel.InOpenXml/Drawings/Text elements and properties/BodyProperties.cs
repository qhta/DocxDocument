namespace DocumentModel.Drawings;

/// <summary>
/// Represents the properties of a text body in a drawing, including layout, overflow, wrapping, insets, columns, anchoring, and 3D effects.
/// </summary>
public interface BodyProperties: IExtendableElement
{
  /// <summary>
  /// Rotation of the text body.
  /// </summary>
  public Int32? Rotation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether paragraph spacing is used.
  /// </summary>
  public bool? UseParagraphSpacing { get; set; }

  /// <summary>
  /// Vertical overflow behavior for text.
  /// </summary>
  public TextVerticalOverflowKind? VerticalOverflow { get; set; }

  /// <summary>
  /// Horizontal overflow behavior for text.
  /// </summary>
  public TextHorizontalOverflowKind? HorizontalOverflow { get; set; }

  /// <summary>
  /// Vertical text orientation.
  /// </summary>
  public TextVerticalKind? Vertical { get; set; }

  /// <summary>
  /// Text wrapping type.
  /// </summary>
  public DMW.TextWrappingKind? Wrap { get; set; }

  /// <summary>
  /// Left inset of the text body.
  /// </summary>
  public Int32? LeftInset { get; set; }

  /// <summary>
  /// Top inset of the text body.
  /// </summary>
  public Int32? TopInset { get; set; }

  /// <summary>
  /// Right inset of the text body.
  /// </summary>
  public Int32? RightInset { get; set; }

  /// <summary>
  /// Bottom inset of the text body.
  /// </summary>
  public Int32? BottomInset { get; set; }

  /// <summary>
  /// Number of columns in the text body.
  /// </summary>
  public Int32? ColumnCount { get; set; }

  /// <summary>
  /// Space between columns.
  /// </summary>
  public Int32? ColumnSpacing { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether columns are right-to-left.
  /// </summary>
  public bool? RightToLeftColumns { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the text body is from WordArt.
  /// </summary>
  public bool? FromWordArt { get; set; }

  /// <summary>
  /// Text anchor type.
  /// </summary>
  public TextAnchoringKind? Anchor { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the anchor is centered.
  /// </summary>
  public bool? AnchorCenter { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether anti-aliasing is forced.
  /// </summary>
  public bool? ForceAntiAlias { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the text is upright.
  /// </summary>
  public bool? UpRight { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether compatible line spacing is used.
  /// </summary>
  public bool? CompatibleLineSpacing { get; set; }

  /// <summary>
  /// Preset text wrap type.
  /// </summary>
  public PresetTextWrap? PresetTextWrap { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether auto-fit is disabled.
  /// </summary>
  public bool? NoAutoFit { get; set; }

  /// <summary>
  /// Normal auto-fit settings.
  /// </summary>
  public NormalAutoFit? NormalAutoFit { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether shape auto-fit is enabled.
  /// </summary>
  public bool? ShapeAutoFit { get; set; }

  /// <summary>
  /// Gets or sets the 3D scene type for the text body.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// Gets or sets the 3D shape type for the text body.
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }

  /// <summary>
  /// Flat text properties.
  /// </summary>
  public FlatText? FlatText { get; set; }
}