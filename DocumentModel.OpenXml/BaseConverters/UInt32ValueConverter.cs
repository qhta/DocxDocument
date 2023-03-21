namespace DocumentModel.OpenXml;

public static class UInt32ValueConverter
{
  public static UInt32? GetValue(DXDrawCharts.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXDrawCharts.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static UInt32? GetValue(DXO2016DrawCharts.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXO2016DrawCharts.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static UInt32? GetValue(DXO2016DrawChartDraw.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXO2016DrawChartDraw.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
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
    var valProperty = typeof(OpenXmlElementType).GetProperty("Normal");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }
}