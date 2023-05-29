namespace DocumentModel.OpenXml.Drawings.Office.OEmbed;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
public static class OEmbedSharedConverter
{
  /// <summary>
  /// srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetSrcUrl(DXODrawY2021OEmb.OEmbedShared openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SrcUrl);
  }
  
  private static bool CmpSrcUrl(DXODrawY2021OEmb.OEmbedShared openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SrcUrl, value, diffs, objName, "SrcUrl");
  }
  
  private static void SetSrcUrl(DXODrawY2021OEmb.OEmbedShared openXmlElement, String? value)
  {
    openXmlElement.SrcUrl = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetType(DXODrawY2021OEmb.OEmbedShared openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXODrawY2021OEmb.OEmbedShared openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXODrawY2021OEmb.OEmbedShared openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDrawsOOEmb.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODrawY2021OEmb.OEmbedShared openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODrawY2021OEmb.OfficeArtExtensionList>();
    if (element != null)
      return DMXDrawsOOEmb.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXODrawY2021OEmb.OEmbedShared openXmlElement, DMDrawsOOEmb.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsOOEmb.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODrawY2021OEmb.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXODrawY2021OEmb.OEmbedShared openXmlElement, DMDrawsOOEmb.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODrawY2021OEmb.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsOOEmb.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXODrawY2021OEmb.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.OEmbed.OEmbedShared? CreateModelElement(DXODrawY2021OEmb.OEmbedShared? openXmlElement)
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
  
  public static bool CompareModelElement(DXODrawY2021OEmb.OEmbedShared? openXmlElement, DMDrawsOOEmb.OEmbedShared? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSrcUrl(openXmlElement, value.SrcUrl, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsOOEmb.OEmbedShared value)
    where OpenXmlElementType: DXODrawY2021OEmb.OEmbedShared, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODrawY2021OEmb.OEmbedShared openXmlElement, DMDrawsOOEmb.OEmbedShared value)
  {
    SetSrcUrl(openXmlElement, value?.SrcUrl);
    SetType(openXmlElement, value?.Type);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
