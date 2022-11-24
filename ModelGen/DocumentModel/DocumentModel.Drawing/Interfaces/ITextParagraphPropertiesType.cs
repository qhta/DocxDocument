namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public interface ITextParagraphPropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Left Margin
  /// </summary>
  public Int32? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public Int32? RightMargin { get ; set; }
  
  /// <summary>
  /// Level
  /// </summary>
  public Int32? Level { get ; set; }
  
  /// <summary>
  /// Indent
  /// </summary>
  public Int32? Indent { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public TextAlignmentTypeValues? Alignment { get ; set; }
  
  /// <summary>
  /// Default Tab Size
  /// </summary>
  public Int32? DefaultTabSize { get ; set; }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  public Boolean? EastAsianLineBreak { get ; set; }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  public TextFontAlignmentValues? FontAlignment { get ; set; }
  
  /// <summary>
  /// Latin Line Break
  /// </summary>
  public Boolean? LatinLineBreak { get ; set; }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  public Boolean? Height { get ; set; }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  public ILineSpacing? LineSpacing { get ; set; }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  public ISpaceBefore? SpaceBefore { get ; set; }
  
  /// <summary>
  /// Space After.
  /// </summary>
  public ISpaceAfter? SpaceAfter { get ; set; }
  
}
