namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SpacingBetweenLines Class.
/// </summary>
public class SpacingBetweenLinesImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>, SpacingBetweenLines
{
  /// <summary>
  /// Type of Spacing Between Lines
  /// </summary>
  public LineSpacingRuleKind? LineRule
  {
    get => (LineSpacingRuleKind?)OpenXmlElement?.LineRule?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LineRule = (DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues?)value;
    }
  }
  
}
