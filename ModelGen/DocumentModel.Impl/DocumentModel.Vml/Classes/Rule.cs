namespace DocumentModel.Vml;

/// <summary>
/// Rule.
/// </summary>
public class RuleImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.Rule>, Rule
{
  /// <summary>
  /// Rule Type
  /// </summary>
  public RuleKind? Type
  {
    get => (RuleKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.RuleValues?)value;
    }
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public AlignmentKind? How
  {
    get => (AlignmentKind?)OpenXmlElement?.How?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.How = (DocumentFormat.OpenXml.Vml.Office.AlignmentValues?)value;
    }
  }
  
}
