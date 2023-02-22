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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.ArgumentSize>()?.Val);
  }
  
  private static bool CmpArgumentSize(DXMath.ArgumentProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.ArgumentSize>()?.Val, value, diffs, objName, "ArgumentSize");
  }
  
  private static void SetArgumentSize(DXMath.ArgumentProperties openXmlElement, Int64? value)
  {
    SimpleValueConverter.SetValue<DXMath.ArgumentSize,System.Int64>(openXmlElement, value);
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.ArgumentProperties value)
    where OpenXmlElementType: DXMath.ArgumentProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.ArgumentProperties openXmlElement, DMMath.ArgumentProperties value)
  {
    SetArgumentSize(openXmlElement, value?.ArgumentSize);
    }
  }
