using DocumentModel.Drawings;
using LiveFeedBackgroundProperties = DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public static class LiveFeedBackgroundPropertiesConverter
{
  public static BackgroundNormalProperties? GetBackgroundNormalProperties(LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties>();
    if (itemElement != null)
      return BackgroundNormalPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackgroundNormalProperties(LiveFeedBackgroundProperties? openXmlElement, BackgroundNormalProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundNormalPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackgroundRemovedProperties? GetBackgroundRemovedProperties(LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties>();
    if (itemElement != null)
      return BackgroundRemovedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackgroundRemovedProperties(LiveFeedBackgroundProperties? openXmlElement, BackgroundRemovedProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundRemovedPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackgroundBlurProperties? GetBackgroundBlurProperties(LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties>();
    if (itemElement != null)
      return BackgroundBlurPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackgroundBlurProperties(LiveFeedBackgroundProperties? openXmlElement, BackgroundBlurProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundBlurPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackgroundCustomProperties? GetBackgroundCustomProperties(LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties>();
    if (itemElement != null)
      return BackgroundCustomPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackgroundCustomProperties(LiveFeedBackgroundProperties? openXmlElement, BackgroundCustomProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundCustomPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.OfficeArtExtensionList? GetOfficeArtExtensionList(LiveFeedBackgroundProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(LiveFeedBackgroundProperties? openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.LiveFeedBackgroundProperties? CreateModelElement(LiveFeedBackgroundProperties? openXmlElement)
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
    where OpenXmlElementType : LiveFeedBackgroundProperties, new()
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