namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public class ScriptLinkImpl: ModelElementImpl, ScriptLink
{
  public DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScriptLinkImpl(): base() {}
  
  public ScriptLinkImpl(DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Val
  {
    get => (String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
