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
    get => (Int32?)OpenXmlElement?.LeftMargin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LeftMargin = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public Int32? RightMargin
  {
    get => (Int32?)OpenXmlElement?.RightMargin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RightMargin = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Level
  /// </summary>
  public Int32? Level
  {
    get => (Int32?)OpenXmlElement?.Level?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Level = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Indent
  /// </summary>
  public Int32? Indent
  {
    get => (Int32?)OpenXmlElement?.Indent?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Indent = (System.Int32?)value;
    }
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
    get => (Int32?)OpenXmlElement?.DefaultTabSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultTabSize = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public Boolean? RightToLeft
  {
    get => (Boolean?)OpenXmlElement?.RightToLeft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RightToLeft = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  public Boolean? EastAsianLineBreak
  {
    get => (Boolean?)OpenXmlElement?.EastAsianLineBreak?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EastAsianLineBreak = (System.Boolean?)value;
    }
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
    get => (Boolean?)OpenXmlElement?.LatinLineBreak?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LatinLineBreak = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  public Boolean? Height
  {
    get => (Boolean?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  public virtual LineSpacing? LineSpacing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  public virtual SpaceBefore? SpaceBefore
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Space After.
  /// </summary>
  public virtual SpaceAfter? SpaceAfter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
