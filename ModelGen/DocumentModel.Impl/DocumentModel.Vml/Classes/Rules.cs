namespace DocumentModel.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public class RulesImpl: ModelElementImpl, Rules
{
  public DocumentFormat.OpenXml.Vml.Office.Rules? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Rules?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  public Collection<Rule>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
