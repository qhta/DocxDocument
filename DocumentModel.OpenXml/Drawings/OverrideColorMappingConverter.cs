namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Override Color Mapping.
/// </summary>
public static class OverrideColorMappingConverter
{
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.OverrideColorMapping openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.OverrideColorMapping openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.OverrideColorMapping? CreateModelElement(DXDraw.OverrideColorMapping? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.OverrideColorMapping();
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.OverrideColorMapping? value)
    where OpenXmlElementType: DXDraw.OverrideColorMapping, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
