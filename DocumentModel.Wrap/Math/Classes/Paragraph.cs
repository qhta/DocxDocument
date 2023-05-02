using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   This element specifies a math paragraph, or display math zone, 
///   that contains one or more oMath elements that are in display mode. 
///   The oMath containers of a display math zone are not themselves considered inline math zones.
/// </summary>
public class Paragraph: ElementCollection<IMathParagraphContent>, ICommonMathContent
{
  /// <summary>
  ///   Office Math Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }
}