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
  
  private static bool CmpUri(DXDraw.DataModelExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
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
    return DMXDrawsO.DataModelExtensionBlockConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.DataModelExtensionBlock>());
  }
  
  private static bool CmpDataModelExtensionBlock(DXDraw.DataModelExtension openXmlElement, DMDrawsO.DataModelExtensionBlock? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.DataModelExtensionBlockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.DataModelExtensionBlock>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXO2010DrawDgm.RecolorImages>() != null;
  }
  
  private static bool CmpRecolorImages(DXDraw.DataModelExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawDgm.RecolorImages>() != null == value;
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
  
  public static bool CompareModelElement(DXDraw.DataModelExtension? openXmlElement, DMDraws.DataModelExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpDataModelExtensionBlock(openXmlElement, value.DataModelExtensionBlock, diffs, objName))
        ok = false;
      if (!CmpRecolorImages(openXmlElement, value.RecolorImages, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
