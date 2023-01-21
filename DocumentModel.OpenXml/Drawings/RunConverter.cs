namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public static class RunConverter
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  private static DMDraws.RunProperties? GetRunProperties(DXDraw.Run openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RunProperties>();
    if (itemElement != null)
      return DMXDraws.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DXDraw.Run openXmlElement, DMDraws.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RunPropertiesConverter.CreateOpenXmlElement<DXDraw.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text String.
  /// </summary>
  private static String? GetText(DXDraw.Run openXmlElement)
  {
    return openXmlElement?.Text?.Text;
  }
  
  private static void SetText(DXDraw.Run openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Text = new DXDraw.Text(value);
    else
      openXmlElement.Text = null;
  }
  
  public static DMDraws.Run? CreateModelElement(DXDraw.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Run();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.Text = GetText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Run? value)
    where OpenXmlElementType: DXDraw.Run, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetText(openXmlElement, value?.Text);
      return openXmlElement;
    }
    return default;
  }
}
