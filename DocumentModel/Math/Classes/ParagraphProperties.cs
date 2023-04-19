namespace DocumentModel.Math;

/// <summary>
///   This element specifies properties of the math paragraph oMathPara, including justification jc.
/// </summary>
public class ParagraphProperties: ModelElement
{
  /// <summary>
  ///   Justification.
  /// </summary>
  public JustificationKind? Justification { get; set; }
}