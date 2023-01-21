namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Relative Offset Effect.
/// </summary>
public static class RelativeOffsetConverter
{
  /// <summary>
  /// Offset X
  /// </summary>
  private static Int32? GetOffsetX(DXDraw.RelativeOffset openXmlElement)
  {
    return openXmlElement.OffsetX?.Value;
  }
  
  private static void SetOffsetX(DXDraw.RelativeOffset openXmlElement, Int32? value)
  {
    openXmlElement.OffsetX = value;
  }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  private static Int32? GetOffsetY(DXDraw.RelativeOffset openXmlElement)
  {
    return openXmlElement.OffsetY?.Value;
  }
  
  private static void SetOffsetY(DXDraw.RelativeOffset openXmlElement, Int32? value)
  {
    openXmlElement.OffsetY = value;
  }
  
  public static DMDraws.RelativeOffset? CreateModelElement(DXDraw.RelativeOffset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.RelativeOffset();
      value.OffsetX = GetOffsetX(openXmlElement);
      value.OffsetY = GetOffsetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.RelativeOffset? value)
    where OpenXmlElementType: DXDraw.RelativeOffset, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOffsetX(openXmlElement, value?.OffsetX);
      SetOffsetY(openXmlElement, value?.OffsetY);
      return openXmlElement;
    }
    return default;
  }
}
