namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the TextBodyProperties Class.
/// </summary>
public interface TextBodyProperties
{
  /// <summary>
  /// Rotation
  /// </summary>
  public Int32? Rotation { get ; set; }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  public Boolean? UseParagraphSpacing { get ; set; }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public DocumentModel.Drawings.TextVerticalOverflowKind? VerticalOverflow { get ; set; }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public DocumentModel.Drawings.TextHorizontalOverflowKind? HorizontalOverflow { get ; set; }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public DocumentModel.Drawings.TextVerticalKind? Vertical { get ; set; }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public DocumentModel.Drawings.TextWrappingKind? Wrap { get ; set; }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  public Int32? LeftInset { get ; set; }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  public Int32? TopInset { get ; set; }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  public Int32? RightInset { get ; set; }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  public Int32? BottomInset { get ; set; }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  public Int32? ColumnCount { get ; set; }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  public Int32? ColumnSpacing { get ; set; }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  public Boolean? RightToLeftColumns { get ; set; }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  public Boolean? FromWordArt { get ; set; }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public DocumentModel.Drawings.TextAnchoringKind? Anchor { get ; set; }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public Boolean? AnchorCenter { get ; set; }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  public Boolean? ForceAntiAlias { get ; set; }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  public Boolean? UpRight { get ; set; }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  public Boolean? CompatibleLineSpacing { get ; set; }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public DocumentModel.Drawings.PresetTextWrap? PresetTextWrap { get ; set; }
  
  public Boolean? NoAutoFit { get ; set; }
  
  public DocumentModel.Drawings.NormalAutoFit? NormalAutoFit { get ; set; }
  
  public Boolean? ShapeAutoFit { get ; set; }
  
  public DocumentModel.Drawings.Scene3DType? Scene3DType { get ; set; }
  
  public DocumentModel.Drawings.Shape3DType? Shape3DType { get ; set; }
  
  public DocumentModel.Drawings.FlatText? FlatText { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
