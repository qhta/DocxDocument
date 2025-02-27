namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public static class DataModelExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.DataModelExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.DataModelExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.DataModelExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDO.DataModelExtensionBlock? GetDataModelExtensionBlock(DXD.DataModelExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.DataModelExtensionBlock>();
    if (element != null)
      return DMXDO.DataModelExtensionBlockConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataModelExtensionBlock(DXD.DataModelExtension openXmlElement, DMDO.DataModelExtensionBlock? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.DataModelExtensionBlockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.DataModelExtensionBlock>(), value, diffs, objName, propName);
  }
  
  private static void SetDataModelExtensionBlock(DXD.DataModelExtension openXmlElement, DMDO.DataModelExtensionBlock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.DataModelExtensionBlock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.DataModelExtensionBlockConverter.CreateOpenXmlElement<DXOD.DataModelExtensionBlock>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetRecolorImages(DXD.DataModelExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10DD.RecolorImages>() != null;
  }
  
  private static bool CmpRecolorImages(DXD.DataModelExtension openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO10DD.RecolorImages>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10DD.RecolorImages", val, value);
    return false;
  }
  
  private static void SetRecolorImages(DXD.DataModelExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10DD.RecolorImages>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10DD.RecolorImages();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.DataModelExtension? CreateModelElement(DXD.DataModelExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.DataModelExtension();
      value.Uri = GetUri(openXmlElement);
      value.DataModelExtensionBlock = GetDataModelExtensionBlock(openXmlElement);
      value.RecolorImages = GetRecolorImages(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.DataModelExtension? openXmlElement, DMD.DataModelExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpDataModelExtensionBlock(openXmlElement, value.DataModelExtensionBlock, diffs, objName, propName))
        ok = false;
      if (!CmpRecolorImages(openXmlElement, value.RecolorImages, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.DataModelExtension value)
    where OpenXmlElementType: DXD.DataModelExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.DataModelExtension openXmlElement, DMD.DataModelExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetDataModelExtensionBlock(openXmlElement, value?.DataModelExtensionBlock);
    SetRecolorImages(openXmlElement, value?.RecolorImages);
  }
}
