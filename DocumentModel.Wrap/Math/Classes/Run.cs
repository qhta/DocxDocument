using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   This element specifies a run of mathematical text.
/// </summary>
public class Run: ElementCollection<IRunContent>, IBidirectionalContent, 
  IMathArgumentContent, IOfficeMathContent, IMathParagraphContent
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