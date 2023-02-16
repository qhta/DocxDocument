namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Argument Properties.
/// </summary>
public static class ArgumentPropertiesConverter
{
  /// <summary>
  /// Argument Size.
  /// </summary>
  private static Int64? GetArgumentSize(DXMath.ArgumentProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.ArgumentSize>()?.Val?.Value;
  }
  
  private static bool CmpArgumentSize(DXMath.ArgumentProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ArgumentSize>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.ArgumentSize", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetArgumentSize(DXMath.ArgumentProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ArgumentSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.ArgumentSize{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.ArgumentProperties? CreateModelElement(DXMath.ArgumentProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.ArgumentProperties();
      value.ArgumentSize = GetArgumentSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.ArgumentProperties? openXmlElement, DMMath.ArgumentProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpArgumentSize(openXmlElement, value.ArgumentSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.ArgumentProperties? value)
    where OpenXmlElementType: DXMath.ArgumentProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetArgumentSize(openXmlElement, value?.ArgumentSize);
      return openXmlElement;
    }
    return default;
  }
}
