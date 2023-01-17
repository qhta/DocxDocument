namespace DocumentModel.OpenXml.Drawings.Office.ScriptLink;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public static class ScriptLinkConverter
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetVal(DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Office.ScriptLink.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ScriptLink.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink openXmlElement, DocumentModel.Drawings.Office.ScriptLink.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Office.ScriptLink.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.ScriptLink.ScriptLink? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.ScriptLink.ScriptLink();
      value.Val = GetVal(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.ScriptLink.ScriptLink? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
