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
    var element = openXmlElement?.GetFirstChild<DXDraw.RunProperties>();
    if (element != null)
      return DMXDraws.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXDraw.Run openXmlElement, DMDraws.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpText(DXDraw.Run openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Text?.Text == value) return true;
    diffs?.Add(objName, "Text", openXmlElement?.Text?.Text, value);
    return false;
  }
  
  private static void SetText(DXDraw.Run openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Text = new DXDraw.Text(value);
    else
      openXmlElement.Text = null;
  }
  
  public static DocumentModel.Drawings.Run? CreateModelElement(DXDraw.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Run();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.Text = GetText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Run? openXmlElement, DMDraws.Run? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName))
        ok = false;
      if (!CmpText(openXmlElement, value.Text, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Run value)
    where OpenXmlElementType: DXDraw.Run, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Run openXmlElement, DMDraws.Run value)
  {
    SetRunProperties(openXmlElement, value?.RunProperties);
    SetText(openXmlElement, value?.Text);
  }
}
