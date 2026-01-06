using DocumentModel.Wordprocessing;
namespace DocumentModel.Math;
/// <summary>
///   This element specifies a run of mathematical text.
/// </summary>
public interface Run: IElementCollection<RunContent>, BidirectionalContent, 
  MathArgumentContent, OfficeMathContent, MathParagraphContent
{
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public RunProperties? MathRunProperties { get; set; }
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public Wordprocessing.RunProperties? RunProperties { get; set; }
}