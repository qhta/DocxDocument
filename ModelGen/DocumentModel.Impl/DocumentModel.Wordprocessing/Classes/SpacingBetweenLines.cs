namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SpacingBetweenLines Class.
/// </summary>
public partial class SpacingBetweenLinesImpl: ModelElementImpl, SpacingBetweenLines
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SpacingBetweenLinesImpl(): base() {}
  
  public SpacingBetweenLinesImpl(DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Spacing Above Paragraph
  /// </summary>
  public String? Before
  {
    get => (System.String?)OpenXmlElement?.Before?.Value;
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
    get => (System.Int32?)OpenXmlElement?.BeforeLines?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.BeforeAutoSpacing?.Value;
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
    get => (System.String?)OpenXmlElement?.After?.Value;
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
    get => (System.Int32?)OpenXmlElement?.AfterLines?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AfterAutoSpacing?.Value;
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
    get => (System.String?)OpenXmlElement?.Line?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Line = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Type of Spacing Between Lines
  /// </summary>
  public DocumentModel.Wordprocessing.LineSpacingRuleKind? LineRule
  {
    get => (DocumentModel.Wordprocessing.LineSpacingRuleKind?)OpenXmlElement?.LineRule?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LineRule = (DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues?)value;
    }
  }
  
}
