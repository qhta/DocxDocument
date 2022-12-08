namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public class TextParagraphPropertiesTypeImpl: ModelElementImpl, TextParagraphPropertiesType
{
  public DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Left Margin
  /// </summary>
  public Int32? LeftMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public Int32? RightMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Level
  /// </summary>
  public Int32? Level
  {
    get;
    set;
  }
  
  /// <summary>
  /// Indent
  /// </summary>
  public Int32? Indent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public TextAlignmentKind? Alignment
  {
    get => (TextAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues?)value;
    }
  }
  
  /// <summary>
  /// Default Tab Size
  /// </summary>
  public Int32? DefaultTabSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public Boolean? RightToLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  public Boolean? EastAsianLineBreak
  {
    get;
    set;
  }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  public TextFontAlignmentKind? FontAlignment
  {
    get => (TextFontAlignmentKind?)OpenXmlElement?.FontAlignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FontAlignment = (DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Latin Line Break
  /// </summary>
  public Boolean? LatinLineBreak
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  public Boolean? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  public virtual LineSpacing? LineSpacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  public virtual SpaceBefore? SpaceBefore
  {
    get;
    set;
  }
  
  /// <summary>
  /// Space After.
  /// </summary>
  public virtual SpaceAfter? SpaceAfter
  {
    get;
    set;
  }
  
}
