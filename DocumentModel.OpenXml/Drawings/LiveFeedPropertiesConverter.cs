using DocumentModel.Drawings;
using LiveFeedProperties = DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the LiveFeedProperties Class.
/// </summary>
public static class LiveFeedPropertiesConverter
{
  /// <summary>
  ///   LiveFeedBackgroundProperties.
  /// </summary>
  public static LiveFeedBackgroundProperties? GetLiveFeedBackgroundProperties(LiveFeedProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>();
    if (itemElement != null)
      return LiveFeedBackgroundPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLiveFeedBackgroundProperties(LiveFeedProperties? openXmlElement, LiveFeedBackgroundProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LiveFeedBackgroundPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.OfficeArtExtensionList? GetOfficeArtExtensionList(LiveFeedProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(LiveFeedProperties? openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList? value)
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

  public static DocumentModel.Drawings.LiveFeedProperties? CreateModelElement(LiveFeedProperties? openXmlElement)
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
    where OpenXmlElementType : LiveFeedProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLiveFeedBackgroundProperties(openXmlElement, value?.LiveFeedBackgroundProperties);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}