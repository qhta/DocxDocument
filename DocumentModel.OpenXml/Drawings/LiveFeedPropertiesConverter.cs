namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public static class LiveFeedPropertiesConverter
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public static DocumentModel.Drawings.LiveFeedBackgroundProperties? GetLiveFeedBackgroundProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LiveFeedBackgroundPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLiveFeedBackgroundProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties? openXmlElement, DocumentModel.Drawings.LiveFeedBackgroundProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LiveFeedBackgroundPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties? openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.LiveFeedProperties? CreateModelElement(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LiveFeedProperties();
      value.LiveFeedBackgroundProperties = GetLiveFeedBackgroundProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LiveFeedProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
