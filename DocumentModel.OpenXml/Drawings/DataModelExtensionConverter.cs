namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public static class DataModelExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.DataModelExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.DataModelExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsO.DataModelExtensionBlock? GetDataModelExtensionBlock(DXDraw.DataModelExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.DataModelExtensionBlock>();
    if (itemElement != null)
      return DMXDrawsO.DataModelExtensionBlockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataModelExtensionBlock(DXDraw.DataModelExtension openXmlElement, DMDrawsO.DataModelExtensionBlock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.DataModelExtensionBlock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.DataModelExtensionBlockConverter.CreateOpenXmlElement<DXODraw.DataModelExtensionBlock>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetRecolorImages(DXDraw.DataModelExtension openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawDgm.RecolorImages>();
    return itemElement != null;
  }
  
  private static void SetRecolorImages(DXDraw.DataModelExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawDgm.RecolorImages>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawDgm.RecolorImages();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.DataModelExtension? CreateModelElement(DXDraw.DataModelExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.DataModelExtension();
      value.Uri = GetUri(openXmlElement);
      value.DataModelExtensionBlock = GetDataModelExtensionBlock(openXmlElement);
      value.RecolorImages = GetRecolorImages(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.DataModelExtension? value)
    where OpenXmlElementType: DXDraw.DataModelExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetDataModelExtensionBlock(openXmlElement, value?.DataModelExtensionBlock);
      SetRecolorImages(openXmlElement, value?.RecolorImages);
      return openXmlElement;
    }
    return default;
  }
}
