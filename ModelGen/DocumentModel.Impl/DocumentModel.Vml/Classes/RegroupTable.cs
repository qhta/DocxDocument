namespace DocumentModel.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public class RegroupTableImpl: ModelElementImpl, RegroupTable
{
  public DocumentFormat.OpenXml.Vml.Office.RegroupTable? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.RegroupTable?)_OpenXmlElement;
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
  
  public Collection<Entry>? Entries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
