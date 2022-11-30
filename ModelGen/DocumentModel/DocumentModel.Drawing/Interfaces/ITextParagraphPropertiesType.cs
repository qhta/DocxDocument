namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public interface ITextParagraphPropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Left Margin
  /// </summary>
  public System.Int32? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public System.Int32? RightMargin { get ; set; }
  
  /// <summary>
  /// Level
  /// </summary>
  public System.Int32? Level { get ; set; }
  
  /// <summary>
  /// Indent
  /// </summary>
  public System.Int32? Indent { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public DocumentModel.Drawing.TextAlignmentKind? Alignment { get ; set; }
  
  /// <summary>
  /// Default Tab Size
  /// </summary>
  public System.Int32? DefaultTabSize { get ; set; }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public System.Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  public System.Boolean? EastAsianLineBreak { get ; set; }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  public DocumentModel.Drawing.TextFontAlignmentKind? FontAlignment { get ; set; }
  
  /// <summary>
  /// Latin Line Break
  /// </summary>
  public System.Boolean? LatinLineBreak { get ; set; }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  public System.Boolean? Height { get ; set; }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  public DocumentModel.Drawing.ILineSpacing? LineSpacing { get ; set; }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  public DocumentModel.Drawing.ISpaceBefore? SpaceBefore { get ; set; }
  
  /// <summary>
  /// Space After.
  /// </summary>
  public DocumentModel.Drawing.ISpaceAfter? SpaceAfter { get ; set; }
  
}
