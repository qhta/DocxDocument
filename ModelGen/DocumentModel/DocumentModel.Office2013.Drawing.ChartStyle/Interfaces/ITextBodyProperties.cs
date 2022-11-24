namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the TextBodyProperties Class.
/// </summary>
public interface ITextBodyProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public TextVerticalOverflowValues? VerticalOverflow { get ; set; }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public TextHorizontalOverflowValues? HorizontalOverflow { get ; set; }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public TextVerticalValues? Vertical { get ; set; }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public TextWrappingValues? Wrap { get ; set; }
  
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
  public TextAnchoringTypeValues? Anchor { get ; set; }
  
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
  public IPresetTextWrap? PresetTextWrap { get ; set; }
  
}
