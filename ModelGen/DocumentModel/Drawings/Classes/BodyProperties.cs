namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the body properties for the text body within a shape.
/// </summary>
public partial class BodyProperties
{
  
  /// <summary>
  ///   Specifies the rotation that is being applied to the text within the bounding box. If it not specified, the rotation of the accompanying shape is used. If it is specified, then this is applied independently from the shape. That is the shape can have a rotation applied in addition to the text itself having a rotation applied to it. If this attribute is omitted, then a value of 0, is implied.
  /// </summary>
  public Int32? Rotation { get; set; }
  
  
  /// <summary>
  ///   Specifies whether the before and after paragraph spacing defined by the user is to be respected. While the spacing between paragraphs is helpful, it is additionally useful to be able to set a flag as to whether this spacing is to be followed at the edges of the text body, in other words the first and last paragraphs in the text body. More precisely since this is a text body level property it should only effect the before paragraph spacing of the first paragraph and the after paragraph spacing of the last paragraph for a given text body. If this attribute is omitted, then a value of 0, or false is implied.
  /// </summary>
  public Boolean? UseParagraphSpacing { get; set; }
  
  
  /// <summary>
  ///   Determines whether the text can flow out of the bounding box vertically. This is used to determine what happens in the event that the text within a shape is too large for the bounding box it is contained within. If this attribute is omitted, then a value of overflow is implied.
  /// </summary>
  public TextVerticalOverflowKind? VerticalOverflow { get; set; }
  
  
  /// <summary>
  ///   Determines whether the text can flow out of the bounding box horizontally. This is used to determine what happens in the event that the text within a shape is too large for the bounding box it is contained within. If this attribute is omitted, then a value of overflow is implied.
  /// </summary>
  public TextHorizontalOverflowKind? HorizontalOverflow { get; set; }
  
  
  /// <summary>
  ///   Determines if the text within the given text body should be displayed vertically. If this attribute is omitted, then a value of horz, or no vertical text is implied.
  /// </summary>
  public TextVerticalKind? Vertical { get; set; }
  
  
  /// <summary>
  ///   Specifies the wrapping options to be used for this text body. If this attribute is omitted, then a value of square is implied which wraps the text using the bounding text box.
  /// </summary>
  public TextWrappingKind? Wrap { get; set; }
  
  
  /// <summary>
  ///   Specifies the left inset of the bounding rectangle. Insets are used just as internal margins for text boxes within shapes. If this attribute is omitted, then a value of 91440 or 0.1 inches is implied.
  /// </summary>
  public Int32? LeftInset { get; set; }
  
  
  /// <summary>
  ///   Specifies the top inset of the bounding rectangle. Insets are used just as internal margins for text boxes within shapes. If this attribute is omitted, then a value of 45720 or 0.05 inches is implied.
  /// </summary>
  public Int32? TopInset { get; set; }
  
  
  /// <summary>
  ///   Specifies the right inset of the bounding rectangle. Insets are used just as internal margins for text boxes within shapes. If this attribute is omitted, then a value of 91440 or 0.1 inches is implied.
  /// </summary>
  public Int32? RightInset { get; set; }
  
  
  /// <summary>
  ///   Specifies the bottom inset of the bounding rectangle. Insets are used just as internal margins for text boxes within shapes. If this attribute is omitted, a value of 45720 or 0.05 inches is implied.
  /// </summary>
  public Int32? BottomInset { get; set; }
  
  
  /// <summary>
  ///   Specifies the number of columns of text in the bounding rectangle. When applied to a text run this property takes the width of the bounding box for the text and divides it by the number of columns specified. These columns are then treated as overflow containers in that when the previous column has been filled with text the next column acts as the repository for additional text. When all columns have been filled and text still remains then the overflow properties set for this text body are used and the text is reflowed to make room for additional text. If this attribute is omitted, then a value of 1 is implied.
  /// </summary>
  public Int32? ColumnCount { get; set; }
  
  
  /// <summary>
  ///   Specifies the space between text columns in the text area. This should only apply when there is more than 1 column present. If this attribute is omitted, then a value of 0 is implied.
  /// </summary>
  public Int32? ColumnSpacing { get; set; }
  
  
  /// <summary>
  ///   Specifies whether columns are used in a right-to-left or left-to-right order. The usage of this attribute only sets the column order that is used to determine which column overflow text should go to next. If this attribute is omitted, then a value of 0 or false is implied in which case text starts in the leftmost column and flow to the right.
  /// </summary>
  public Boolean? RightToLeftColumns { get; set; }
  
  
  /// <summary>
  ///   From WordArt
  /// </summary>
  public Boolean? FromWordArt { get; set; }
  
  
  /// <summary>
  ///   Specifies the anchoring position of the txBody within the shape. If this attribute is omitted, then a value of t, or top is implied.
  /// </summary>
  public TextAnchoringTypeKind? Anchor { get; set; }
  
  
  /// <summary>
  ///   Specifies the centering of the text box. The way it works fundamentally is to determine the smallest possible &quot;bounds box&quot; for the text and then to center that &quot;bounds box&quot; accordingly. This is different than paragraph alignment, which aligns the text within the &quot;bounds box&quot; for the text. This flag is compatible with all of the different kinds of anchoring. If this attribute is omitted, then a value of 0 or false is implied.
  /// </summary>
  public Boolean? AnchorCenter { get; set; }
  
  
  /// <summary>
  ///   Forces the text to be rendered anti-aliased regardless of the font size. Certain fonts can appear grainy around their edges unless they are anti-aliased. Therefore this attribute allows for the specifying of which bodies of text should always be anti-aliased and which ones should not. If this attribute is omitted, then a value of 0 or false is implied.
  /// </summary>
  public Boolean? ForceAntiAlias { get; set; }
  
  
  /// <summary>
  ///   Specifies whether text should remain upright, regardless of the transform applied to it
  /// </summary>
  public Boolean? UpRight { get; set; }
  
  
  /// <summary>
  ///   Compatible Line Spacing
  /// </summary>
  public Boolean? CompatibleLineSpacing { get; set; }
  
  
  /// <summary>
  ///   Preset Text Shape.
  /// </summary>
  public PresetTextWrap? PresetTextWrap { get; set; }
  
  public Boolean? NoAutoFit { get; set; }
  
  public NormalAutoFit? NormalAutoFit { get; set; }
  
  public Boolean? ShapeAutoFit { get; set; }
  
  public Scene3DType? Scene3DType { get; set; }
  
  public Shape3DType? Shape3DType { get; set; }
  
  public FlatText? FlatText { get; set; }
  
  public ExtensionList? ExtensionList { get; set; }
  
}
