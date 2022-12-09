namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SpacingBetweenLines Class.
/// </summary>
public class SpacingBetweenLinesImpl: ModelElementImpl, SpacingBetweenLines
{
  public DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Spacing Above Paragraph
  /// </summary>
  public String? Before
  {
    get => (String?)OpenXmlElement?.Before?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Before = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Spacing Above Paragraph IN Line Units
  /// </summary>
  public Int32? BeforeLines
  {
    get => (Int32?)OpenXmlElement?.BeforeLines?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BeforeLines = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Automatically Determine Spacing Above Paragraph
  /// </summary>
  public Boolean? BeforeAutoSpacing
  {
    get => (Boolean?)OpenXmlElement?.BeforeAutoSpacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BeforeAutoSpacing = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Spacing Below Paragraph
  /// </summary>
  public String? After
  {
    get => (String?)OpenXmlElement?.After?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.After = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Spacing Below Paragraph in Line Units
  /// </summary>
  public Int32? AfterLines
  {
    get => (Int32?)OpenXmlElement?.AfterLines?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AfterLines = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Automatically Determine Spacing Below Paragraph
  /// </summary>
  public Boolean? AfterAutoSpacing
  {
    get => (Boolean?)OpenXmlElement?.AfterAutoSpacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AfterAutoSpacing = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Spacing Between Lines in Paragraph
  /// </summary>
  public String? Line
  {
    get => (String?)OpenXmlElement?.Line?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Line = (System.String?)value;
    }
  }
  
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
