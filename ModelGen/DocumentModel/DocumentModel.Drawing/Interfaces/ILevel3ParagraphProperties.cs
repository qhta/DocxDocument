namespace DocumentModel.Drawing;

/// <summary>
/// List Level 3 Text Style.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBulletColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAutoNumberedBullet))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPictureBullet))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBulletColorText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBulletSizeText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBulletSizePercentage))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBulletSizePoints))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBulletFontText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IDefaultRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICharacterBullet))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBulletFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoBullet))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineSpacing))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISpaceBefore))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISpaceAfter))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITabStopList))]
public interface ILevel3ParagraphProperties // : DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType
{
  /// <summary>
  /// Left Margin
  /// </summary>
  public int? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public int? RightMargin { get ; set; }
  
  /// <summary>
  /// Level
  /// </summary>
  public int? Level { get ; set; }
  
  /// <summary>
  /// Indent
  /// </summary>
  public int? Indent { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public TextAlignmentTypeValues? Alignment { get ; set; }
  
  /// <summary>
  /// Default Tab Size
  /// </summary>
  public int? DefaultTabSize { get ; set; }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public bool? RightToLeft { get ; set; }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  public bool? EastAsianLineBreak { get ; set; }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  public TextFontAlignmentValues? FontAlignment { get ; set; }
  
  /// <summary>
  /// Latin Line Break
  /// </summary>
  public bool? LatinLineBreak { get ; set; }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  public bool? Height { get ; set; }
  
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
