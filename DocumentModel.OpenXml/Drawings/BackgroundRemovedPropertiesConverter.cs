namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundRemovedProperties Class.
/// </summary>
public static class BackgroundRemovedPropertiesConverter
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.BackgroundRemovedProperties? CreateModelElement(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundRemovedProperties();
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BackgroundRemovedProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
