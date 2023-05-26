namespace DocumentModel.OpenXml.Drawings.Office.OEmbed;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
public static class OEmbedSharedConverter
{
  /// <summary>
  /// srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetSrcUrl(DXODY21OE.OEmbedShared openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SrcUrl);
  }
  
  private static bool CmpSrcUrl(DXODY21OE.OEmbedShared openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SrcUrl, value, diffs, objName, "SrcUrl");
  }
  
  private static void SetSrcUrl(DXODY21OE.OEmbedShared openXmlElement, String? value)
  {
    openXmlElement.SrcUrl = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetType(DXODY21OE.OEmbedShared openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXODY21OE.OEmbedShared openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXODY21OE.OEmbedShared openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDOOE.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODY21OE.OEmbedShared openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODY21OE.OfficeArtExtensionList>();
    if (element != null)
      return DMXDOOEmb.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXODY21OE.OEmbedShared openXmlElement, DMDOOE.OfficeArtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDOOEmb.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODY21OE.OfficeArtExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetOfficeArtExtensionList(DXODY21OE.OEmbedShared openXmlElement, DMDOOE.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODY21OE.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDOOEmb.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXODY21OE.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.OEmbed.OEmbedShared? CreateModelElement(DXODY21OE.OEmbedShared? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.OEmbed.OEmbedShared();
      value.SrcUrl = GetSrcUrl(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODY21OE.OEmbedShared? openXmlElement, DMDOOE.OEmbedShared? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSrcUrl(openXmlElement, value.SrcUrl, diffs, objName, propName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDOOE.OEmbedShared value)
    where OpenXmlElementType: DXODY21OE.OEmbedShared, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODY21OE.OEmbedShared openXmlElement, DMDOOE.OEmbedShared value)
  {
    SetSrcUrl(openXmlElement, value?.SrcUrl);
    SetType(openXmlElement, value?.Type);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
