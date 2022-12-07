namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public class TextParagraphPropertiesTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType>, TextParagraphPropertiesType
{
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
