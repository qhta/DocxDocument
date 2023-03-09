namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public static class SdtBlockConverter
{
  /// <summary>
  /// Block-Level Structured Document Tag Content.
  /// </summary>
  private static DMW.SdtContentBlock? GetSdtContentBlock(DXW.SdtBlock openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtContentBlock>();
    if (element != null)
      return DMXW.SdtContentBlockConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtContentBlock(DXW.SdtBlock openXmlElement, DMW.SdtContentBlock? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentBlockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentBlock>(), value, diffs, objName);
  }
  
  private static void SetSdtContentBlock(DXW.SdtBlock openXmlElement, DMW.SdtContentBlock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentBlock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentBlockConverter.CreateOpenXmlElement<DXW.SdtContentBlock>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtProperties? GetSdtProperties(DXW.SdtBlock openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtProperties>();
    if (element != null)
      return DMXW.SdtPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtProperties(DXW.SdtBlock openXmlElement, DMW.SdtProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtProperties>(), value, diffs, objName);
  }
  
  private static void SetSdtProperties(DXW.SdtBlock openXmlElement, DMW.SdtProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtPropertiesConverter.CreateOpenXmlElement<DXW.SdtProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtEndCharProperties? GetSdtEndCharProperties(DXW.SdtBlock openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtEndCharProperties>();
    if (element != null)
      return DMXW.SdtEndCharPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtEndCharProperties(DXW.SdtBlock openXmlElement, DMW.SdtEndCharProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtEndCharPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>(), value, diffs, objName);
  }
  
  private static void SetSdtEndCharProperties(DXW.SdtBlock openXmlElement, DMW.SdtEndCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtEndCharPropertiesConverter.CreateOpenXmlElement<DXW.SdtEndCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  #region StdBlock conversion
  public static DMW.SdtBlock? CreateModelElement(DXW.SdtBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtBlock();
      value.SdtProperties = GetSdtProperties(openXmlElement);
      value.SdtContentBlock = GetSdtContentBlock(openXmlElement);
      value.SdtEndCharProperties = GetSdtEndCharProperties(openXmlElement);

      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtBlock? openXmlElement, DMW.SdtBlock? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSdtContentBlock(openXmlElement, value.SdtContentBlock, diffs, objName))
        ok = false;
      if (!CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName))
        ok = false;
      if (!CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.SdtBlock CreateOpenXmlElement(DMW.SdtBlock value)
  {
    var openXmlElement = new DXW.SdtBlock();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtBlock openXmlElement, DMW.SdtBlock value)
  {
    SetSdtContentBlock(openXmlElement, value?.SdtContentBlock);
    SetSdtProperties(openXmlElement, value?.SdtProperties);
    SetSdtEndCharProperties(openXmlElement, value?.SdtEndCharProperties);
  }
  #endregion
}
