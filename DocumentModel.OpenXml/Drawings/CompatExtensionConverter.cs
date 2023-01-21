namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public static class CompatExtensionConverter
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetShapeId(DXO2010Draw.CompatExtension openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static void SetShapeId(DXO2010Draw.CompatExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  public static DMDraws.CompatExtension? CreateModelElement(DXO2010Draw.CompatExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CompatExtension();
      value.ShapeId = GetShapeId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CompatExtension? value)
    where OpenXmlElementType: DXO2010Draw.CompatExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeId(openXmlElement, value?.ShapeId);
      return openXmlElement;
    }
    return default;
  }
}
