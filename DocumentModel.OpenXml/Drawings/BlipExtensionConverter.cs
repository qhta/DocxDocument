namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public static class BlipExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.ImageProperties? GetImageProperties(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ImagePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetImageProperties(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement, DocumentModel.Drawings.ImageProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ImagePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetUseLocalDpi(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.UseLocalDpi>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetUseLocalDpi(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.UseLocalDpi>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.UseLocalDpi();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WebVideoProperty? GetWebVideoProperty(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WebVideoPropertyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWebVideoProperty(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement, DocumentModel.Drawings.Wordprocessing.WebVideoProperty? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.WebVideoPropertyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.SVG.SVGBlip? GetSVGBlip(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SVG.SVGBlipConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSVGBlip(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement, DocumentModel.Drawings.SVG.SVGBlip? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SVG.SVGBlipConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PictureAttributionSourceURL? GetPictureAttributionSourceURL(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PictureAttributionSourceURLConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPictureAttributionSourceURL(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement, DocumentModel.Drawings.PictureAttributionSourceURL? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.PictureAttributionSourceURLConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.OEmbed.OEmbed? GetOEmbed(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.OEmbed.OEmbedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOEmbed(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement, DocumentModel.Wordprocessing.OEmbed.OEmbed? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.OEmbed.OEmbedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Office.OEmbed.OEmbedShared? GetOEmbedShared(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.OEmbed.OEmbedSharedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOEmbedShared(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement, DocumentModel.Drawings.Office.OEmbed.OEmbedShared? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.OEmbed.OEmbedSharedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.BlipExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.BlipExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BlipExtension();
      value.Uri = GetUri(openXmlElement);
      value.ImageProperties = GetImageProperties(openXmlElement);
      value.UseLocalDpi = GetUseLocalDpi(openXmlElement);
      value.WebVideoProperty = GetWebVideoProperty(openXmlElement);
      value.SVGBlip = GetSVGBlip(openXmlElement);
      value.PictureAttributionSourceURL = GetPictureAttributionSourceURL(openXmlElement);
      value.OEmbed = GetOEmbed(openXmlElement);
      value.OEmbedShared = GetOEmbedShared(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BlipExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.BlipExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
