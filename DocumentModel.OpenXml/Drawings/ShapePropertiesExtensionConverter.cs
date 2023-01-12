namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public static class ShapePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.HiddenFillProperties? GetHiddenFillProperties(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenFillProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HiddenFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHiddenFillProperties(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement, DocumentModel.Drawings.HiddenFillProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HiddenFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenFillProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HiddenLineProperties? GetHiddenLineProperties(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HiddenLinePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHiddenLineProperties(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement, DocumentModel.Drawings.HiddenLineProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HiddenLinePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HiddenEffectsProperties? GetHiddenEffectsProperties(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HiddenEffectsPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHiddenEffectsProperties(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement, DocumentModel.Drawings.HiddenEffectsProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HiddenEffectsPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HiddenScene3D? GetHiddenScene3D(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HiddenScene3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHiddenScene3D(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement, DocumentModel.Drawings.HiddenScene3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HiddenScene3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HiddenShape3D? GetHiddenShape3D(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HiddenShape3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHiddenShape3D(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement, DocumentModel.Drawings.HiddenShape3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HiddenShape3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShadowObscured(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ShadowObscured>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShadowObscured(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ShadowObscured>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.ShadowObscured();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ShapePropertiesExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.HiddenFillProperties = GetHiddenFillProperties(openXmlElement);
      value.HiddenLineProperties = GetHiddenLineProperties(openXmlElement);
      value.HiddenEffectsProperties = GetHiddenEffectsProperties(openXmlElement);
      value.HiddenScene3D = GetHiddenScene3D(openXmlElement);
      value.HiddenShape3D = GetHiddenShape3D(openXmlElement);
      value.ShadowObscured = GetShadowObscured(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapePropertiesExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension, new()
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
