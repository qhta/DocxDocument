namespace DocumentModel.Vml;

/// <summary>
/// Digital Signature Line.
/// </summary>
public class SignatureLineImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.SignatureLine>, SignatureLine
{
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
  
}
