namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public static class LiveFeedBackgroundPropertiesConverter
{
  public static DocumentModel.Drawings.BackgroundNormalProperties? GetBackgroundNormalProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundNormalPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackgroundNormalProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement, DocumentModel.Drawings.BackgroundNormalProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BackgroundNormalPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.BackgroundRemovedProperties? GetBackgroundRemovedProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundRemovedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackgroundRemovedProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement, DocumentModel.Drawings.BackgroundRemovedProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BackgroundRemovedPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.BackgroundBlurProperties? GetBackgroundBlurProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundBlurPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackgroundBlurProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement, DocumentModel.Drawings.BackgroundBlurProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BackgroundBlurPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.BackgroundCustomProperties? GetBackgroundCustomProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundCustomPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackgroundCustomProperties(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement, DocumentModel.Drawings.BackgroundCustomProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BackgroundCustomPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.Drawings.LiveFeedBackgroundProperties? CreateModelElement(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LiveFeedBackgroundProperties();
      value.BackgroundNormalProperties = GetBackgroundNormalProperties(openXmlElement);
      value.BackgroundRemovedProperties = GetBackgroundRemovedProperties(openXmlElement);
      value.BackgroundBlurProperties = GetBackgroundBlurProperties(openXmlElement);
      value.BackgroundCustomProperties = GetBackgroundCustomProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LiveFeedBackgroundProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBackgroundNormalProperties(openXmlElement, value?.BackgroundNormalProperties);
      SetBackgroundRemovedProperties(openXmlElement, value?.BackgroundRemovedProperties);
      SetBackgroundBlurProperties(openXmlElement, value?.BackgroundBlurProperties);
      SetBackgroundCustomProperties(openXmlElement, value?.BackgroundCustomProperties);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
