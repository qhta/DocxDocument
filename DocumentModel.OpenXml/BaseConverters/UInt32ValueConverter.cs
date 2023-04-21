namespace DocumentModel.OpenXml;

public static class UInt32ValueConverter
{
  public static UInt32? GetValue(DXDC.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXDC.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static UInt32? GetValue(DXO16DC.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXO16DC.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static UInt32? GetValue(DXO16DCD.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXO16DCD.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static UInt32? GetValue(DXW.LongHexNumberType element)
  {
    if (element.Val?.Value != null)
      return UInt32.Parse(element.Val.Value, NumberStyles.HexNumber);
    return null;
  }

  public static bool CmpValue(DXW.LongHexNumberType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == null && value == null) return true;
    if (element.Val?.Value !=null && UInt32.Parse(element.Val.Value, NumberStyles.HexNumber) == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(UInt32 value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }
}