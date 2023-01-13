namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.CameraTool? GetCameraTool(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CameraTool>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CameraToolConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCameraTool(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement, DocumentModel.Drawings.CameraTool? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CameraTool>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.CameraToolConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.CameraTool>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.SignatureLine? GetSignatureLine(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SignatureLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSignatureLine(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement, DocumentModel.Drawings.SignatureLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SignatureLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ObjectProperties? GetObjectProperties(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ObjectPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetObjectProperties(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement, DocumentModel.Drawings.ObjectProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ObjectPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.LiveFeedProperties? GetLiveFeedProperties(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LiveFeedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLiveFeedProperties(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement, DocumentModel.Drawings.LiveFeedProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LiveFeedPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.NonVisualPicturePropertiesExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension, new()
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
