namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BodyProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IFlatText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetTextWrap))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IScene3DType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShape3DType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoAutoFit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INormalAutoFit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeAutoFit))]
public interface IBodyProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rotation
  /// </summary>
  public int? Rotation { get ; set; }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  public bool? UseParagraphSpacing { get ; set; }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public TextVerticalOverflow? VerticalOverflow { get ; set; }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public TextHorizontalOverflow? HorizontalOverflow { get ; set; }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public TextVertical? Vertical { get ; set; }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public DocumentModel.Drawing.TextWrapping? Wrap { get ; set; }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  public int? LeftInset { get ; set; }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  public int? TopInset { get ; set; }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  public int? RightInset { get ; set; }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  public int? BottomInset { get ; set; }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  public int? ColumnCount { get ; set; }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  public int? ColumnSpacing { get ; set; }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  public bool? RightToLeftColumns { get ; set; }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  public bool? FromWordArt { get ; set; }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public TextAnchoringType? Anchor { get ; set; }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public bool? AnchorCenter { get ; set; }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  public bool? ForceAntiAlias { get ; set; }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  public bool? UpRight { get ; set; }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  public bool? CompatibleLineSpacing { get ; set; }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public IPresetTextWrap? PresetTextWrap { get ; set; }
  
}
