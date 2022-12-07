namespace DocumentModel.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public class GroupImpl: ModelElement<DocumentFormat.OpenXml.Vml.Group>, Group
{
  /// <summary>
  /// hralign
  /// </summary>
  public HorizontalRuleAlignmentKind? HorizontalAlignment
  {
    get => (HorizontalRuleAlignmentKind?)OpenXmlElement?.HorizontalAlignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalAlignment = (DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public InsetMarginKind? InsetMode
  {
    get => (InsetMarginKind?)OpenXmlElement?.InsetMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsetMode = (DocumentFormat.OpenXml.Vml.Office.InsetMarginValues?)value;
    }
  }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  public EditAsKind? EditAs
  {
    get => (EditAsKind?)OpenXmlElement?.EditAs?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EditAs = (DocumentFormat.OpenXml.Vml.EditAsValues?)value;
    }
  }
  
}
