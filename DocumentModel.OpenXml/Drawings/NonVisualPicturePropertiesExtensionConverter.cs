using DocumentModel.Drawings;
using NonVisualPicturePropertiesExtension = DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(NonVisualPicturePropertiesExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(NonVisualPicturePropertiesExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static CameraTool? GetCameraTool(NonVisualPicturePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CameraTool>();
    if (itemElement != null)
      return CameraToolConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCameraTool(NonVisualPicturePropertiesExtension? openXmlElement, CameraTool? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CameraTool>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CameraToolConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.CameraTool>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SignatureLine? GetSignatureLine(NonVisualPicturePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine>();
    if (itemElement != null)
      return SignatureLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSignatureLine(NonVisualPicturePropertiesExtension? openXmlElement, SignatureLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SignatureLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ObjectProperties? GetObjectProperties(NonVisualPicturePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties>();
    if (itemElement != null)
      return ObjectPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetObjectProperties(NonVisualPicturePropertiesExtension? openXmlElement, ObjectProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LiveFeedProperties? GetLiveFeedProperties(NonVisualPicturePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>();
    if (itemElement != null)
      return LiveFeedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLiveFeedProperties(NonVisualPicturePropertiesExtension? openXmlElement, LiveFeedProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LiveFeedPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.NonVisualPicturePropertiesExtension? CreateModelElement(NonVisualPicturePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualPicturePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.CameraTool = GetCameraTool(openXmlElement);
      value.SignatureLine = GetSignatureLine(openXmlElement);
      value.ObjectProperties = GetObjectProperties(openXmlElement);
      value.LiveFeedProperties = GetLiveFeedProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualPicturePropertiesExtension? value)
    where OpenXmlElementType : NonVisualPicturePropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetCameraTool(openXmlElement, value?.CameraTool);
      SetSignatureLine(openXmlElement, value?.SignatureLine);
      SetObjectProperties(openXmlElement, value?.ObjectProperties);
      SetLiveFeedProperties(openXmlElement, value?.LiveFeedProperties);
      return openXmlElement;
    }
    return default;
  }
}