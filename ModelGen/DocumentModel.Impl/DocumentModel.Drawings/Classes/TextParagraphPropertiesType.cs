namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public partial class TextParagraphPropertiesTypeImpl: ModelElementImpl, TextParagraphPropertiesType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TextParagraphPropertiesTypeImpl(): base() {}
  
  public TextParagraphPropertiesTypeImpl(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Left Margin
  /// </summary>
  public Int32? LeftMargin
  {
    get => (System.Int32?)OpenXmlElement?.LeftMargin?.Value;
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
    get => (System.Int32?)OpenXmlElement?.RightMargin?.Value;
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
    get => (System.Int32?)OpenXmlElement?.Level?.Value;
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
    get => (System.Int32?)OpenXmlElement?.Indent?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Indent = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public DocumentModel.Drawings.TextAlignmentKind? Alignment
  {
    get => (DocumentModel.Drawings.TextAlignmentKind?)OpenXmlElement?.Alignment?.Value;
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
    get => (System.Int32?)OpenXmlElement?.DefaultTabSize?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.RightToLeft?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.EastAsianLineBreak?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EastAsianLineBreak = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  public DocumentModel.Drawings.TextFontAlignmentKind? FontAlignment
  {
    get => (DocumentModel.Drawings.TextFontAlignmentKind?)OpenXmlElement?.FontAlignment?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.LatinLineBreak?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  public virtual DocumentModel.Drawings.LineSpacing? LineSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
        if (item != null)
          return new DocumentModel.Drawings.LineSpacingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.LineSpacingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  public virtual DocumentModel.Drawings.SpaceBefore? SpaceBefore
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
        if (item != null)
          return new DocumentModel.Drawings.SpaceBeforeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SpaceBeforeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Space After.
  /// </summary>
  public virtual DocumentModel.Drawings.SpaceAfter? SpaceAfter
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
        if (item != null)
          return new DocumentModel.Drawings.SpaceAfterImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SpaceAfterImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
