namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public class TextParagraphPropertiesType
{
  /// <summary>
  /// Alignment
  /// </summary>
  public TextAlignmentKind? Alignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  public TextFontAlignmentKind? FontAlignment
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
