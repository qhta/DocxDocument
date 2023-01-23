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
    return openXmlElement?.SrcUrl?.Value;
  }
  
  private static bool CmpSrcUrl(DXODrawY2021OEmb.OEmbedShared openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SrcUrl?.Value == value;
  }
  
  private static void SetSrcUrl(DXODrawY2021OEmb.OEmbedShared openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SrcUrl = new StringValue { Value = value };
    else
      openXmlElement.SrcUrl = null;
  }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetType(DXODrawY2021OEmb.OEmbedShared openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static bool CmpType(DXODrawY2021OEmb.OEmbedShared openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Type?.Value == value;
  }
  
  private static void SetType(DXODrawY2021OEmb.OEmbedShared openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDrawsOOEmb.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODrawY2021OEmb.OEmbedShared openXmlElement)
  {
    return DMXDrawsOOEmb.OfficeArtExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODrawY2021OEmb.OfficeArtExtensionList>());
  }
  
  private static bool CmpOfficeArtExtensionList(DXODrawY2021OEmb.OEmbedShared openXmlElement, DMDrawsOOEmb.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsOOEmb.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXODrawY2021OEmb.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsOOEmb.OEmbedShared? CreateModelElement(DXODrawY2021OEmb.OEmbedShared? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsOOEmb.OEmbedShared();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsOOEmb.OEmbedShared? value)
    where OpenXmlElementType: DXODrawY2021OEmb.OEmbedShared, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSrcUrl(openXmlElement, value?.SrcUrl);
      SetType(openXmlElement, value?.Type);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
