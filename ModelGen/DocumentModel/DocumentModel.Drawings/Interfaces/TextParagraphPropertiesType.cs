namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public interface TextParagraphPropertiesType
{
  /// <summary>
  /// Alignment
  /// </summary>
  public TextAlignmentKind? Alignment { get ; set; }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  public TextFontAlignmentKind? FontAlignment { get ; set; }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  public LineSpacing? LineSpacing { get ; set; }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  public SpaceBefore? SpaceBefore { get ; set; }
  
  /// <summary>
  /// Space After.
  /// </summary>
  public SpaceAfter? SpaceAfter { get ; set; }
  
}
