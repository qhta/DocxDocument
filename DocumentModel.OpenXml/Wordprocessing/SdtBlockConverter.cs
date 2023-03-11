namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public static class SdtBlockConverter
{
  #region SdtContentBlock conversion
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
      itemElement = DMXW.SdtContentBlockConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region StdBlock conversion
  public static DMW.SdtBlock? CreateModelElement(DXW.SdtBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtBlock();
      value.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      value.SdtContentBlock = GetSdtContentBlock(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtBlock? openXmlElement, DMW.SdtBlock? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!CmpSdtContentBlock(openXmlElement, value.SdtContentBlock, diffs, objName))
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
    SdtElementConverter.SetSdtProperties(openXmlElement, value?.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, value?.SdtEndCharProperties);
    SetSdtContentBlock(openXmlElement, value?.SdtContentBlock);
  }
  #endregion
}
