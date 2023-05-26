namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Break"/> class from/to OpenXml converter.
/// </summary>
public static class BreakConverter
{
  #region Index of Operator to Align To conversion.
  private static Int32? GetAlignAt(DXM.Break openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.AlignAt?.Value);
  }
  
  private static bool CmpAlignAt(DXM.Break openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AlignAt?.Value == value) return true;
    diffs?.Add(objName, "AlignAt", openXmlElement?.AlignAt?.Value, value);
    return false;
  }
  
  private static void SetAlignAt(DXM.Break openXmlElement, Int32? value)
  {
    openXmlElement.AlignAt = Int32ValueConverter.CreateIntegerValue(value);
  }
  #endregion

  #region Break model conversion.
  public static DMM.Break? CreateModelElement(DXM.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMM.Break();
      value.AlignAt = GetAlignAt(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Break? openXmlElement, DMM.Break? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlignAt(openXmlElement, value.AlignAt, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.Break value)
    where OpenXmlElementType: DXM.Break, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.Break openXmlElement, DMM.Break value)
  {
    SetAlignAt(openXmlElement, value?.AlignAt);
  }
  #endregion
}
