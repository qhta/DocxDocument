using DocumentFormat.OpenXml.Office2021.Drawing.Livefeed;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the BackgroundBlurProperties Class.
/// </summary>
public static class BackgroundBlurPropertiesConverter
{
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.OfficeArtExtensionList? GetOfficeArtExtensionList(BackgroundBlurProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(BackgroundBlurProperties? openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList? value)
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

  public static DocumentModel.Drawings.BackgroundBlurProperties? CreateModelElement(BackgroundBlurProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundBlurProperties();
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BackgroundBlurProperties? value)
    where OpenXmlElementType : BackgroundBlurProperties, new()
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