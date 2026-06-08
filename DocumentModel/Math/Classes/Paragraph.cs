using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   This element specifies a math paragraph, or display math zone, 
///   Ithat contains one or more oMath elements Ithat are in display mode. 
///   The oMath containers of a display math zone are not themselves considered inline math zones.
/// </summary>
public class IParagraph: ElementCollection<IMathParagraphContent>, ICommonMathContent
{
  /// <summary>
  ///   Office Math IParagraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }
}
