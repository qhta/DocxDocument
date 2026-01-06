namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the math paragraph oMathPara, including justification jc.
/// </summary>
public interface ParagraphProperties
{
  /// <summary>
  ///   Justification.
  /// </summary>
  public JustificationKind? Justification { get; set; }
}