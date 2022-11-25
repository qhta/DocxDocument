namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BodyProperties Class.
/// </summary>
public interface IBodyProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rotation
  /// </summary>
  public System.Int32? Rotation { get ; set; }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  public System.Boolean? UseParagraphSpacing { get ; set; }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public DocumentModel.Drawing.TextVerticalOverflowKind? VerticalOverflow { get ; set; }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public DocumentModel.Drawing.TextHorizontalOverflowKind? HorizontalOverflow { get ; set; }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public DocumentModel.Drawing.TextVerticalKind? Vertical { get ; set; }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public DocumentModel.Drawing.TextWrappingKind? Wrap { get ; set; }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  public System.Int32? LeftInset { get ; set; }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  public System.Int32? TopInset { get ; set; }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  public System.Int32? RightInset { get ; set; }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  public System.Int32? BottomInset { get ; set; }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  public System.Int32? ColumnCount { get ; set; }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  public System.Int32? ColumnSpacing { get ; set; }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  public System.Boolean? RightToLeftColumns { get ; set; }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  public System.Boolean? FromWordArt { get ; set; }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public DocumentModel.Drawing.TextAnchoringTypeKind? Anchor { get ; set; }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public System.Boolean? AnchorCenter { get ; set; }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  public System.Boolean? ForceAntiAlias { get ; set; }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  public System.Boolean? UpRight { get ; set; }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  public System.Boolean? CompatibleLineSpacing { get ; set; }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public DocumentModel.Drawing.IPresetTextWrap? PresetTextWrap { get ; set; }
  
}
