namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public static class RunConverter
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  private static DMD.RunProperties? GetRunProperties(DXD.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RunProperties>();
    if (element != null)
      return DMXD.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXD.Run openXmlElement, DMD.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RunProperties>(), value, diffs, objName);
  }
  
  private static void SetRunProperties(DXD.Run openXmlElement, DMD.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RunPropertiesConverter.CreateOpenXmlElement<DXD.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text String.
  /// </summary>
  private static String? GetText(DXD.Run openXmlElement)
  {
    return openXmlElement?.Text?.Text;
  }
  
  private static bool CmpText(DXD.Run openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Text?.Text == value) return true;
    diffs?.Add(objName, "Text", openXmlElement?.Text?.Text, value);
    return false;
  }
  
  private static void SetText(DXD.Run openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Text = new DXD.Text(value);
    else
      openXmlElement.Text = null;
  }
  
  public static DocumentModel.Drawings.Run? CreateModelElement(DXD.Run? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.Run? openXmlElement, DMD.Run? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Run value)
    where OpenXmlElementType: DXD.Run, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Run openXmlElement, DMD.Run value)
  {
    SetRunProperties(openXmlElement, value?.RunProperties);
    SetText(openXmlElement, value?.Text);
  }
}
