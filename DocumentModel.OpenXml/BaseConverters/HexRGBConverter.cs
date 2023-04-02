namespace DocumentModel.OpenXml;

public static class HexRGBConverter
{
  public static RGB? GetValue(DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return uint.Parse(element.Value, NumberStyles.HexNumber);
    return null;
  }

  public static RGB? GetValue(DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return uint.Parse(element.Val.Value, NumberStyles.HexNumber);;
    return null;
  }

    public static RGB? GetValue(DX.TypedOpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = valProperty.GetValue(openXmlElement);
      if (value is string valStr)
        return uint.Parse(valStr, NumberStyles.HexNumber);
      if (value is HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        return uint.Parse(hexBinaryValue.Value, NumberStyles.HexNumber);
    }
    return null;
  }

    public static bool CmpValue(DX.TypedOpenXmlLeafElement? element, RGB? value, DiffList? diffs, string? objName)
  {
    var valProperty = element?.GetType().GetProperty("Value");
    if (valProperty != null && value != null)
    {
      var valStr = (string?)valProperty.GetValue(element);
      var valueStr = value.ToString();
      if (valStr == valueStr) return true;
      diffs?.Add(objName, element?.GetType().ToString(), valStr, valueStr);
      return false;
    }
    if (valProperty == null && value == null) return true;
    diffs?.Add(objName, element?.GetType().ToString(), element, value);
    return false;
  }

  public static DX.HexBinaryValue? CreateHexBinaryValue(RGB? value)
  {
    if (value != null) return new DX.HexBinaryValue(value.ToString());
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(RGB? value)
    where HexBinaryType : DXW.LongHexNumberType, new()
  {
    if (value != null)
    {
      var element = new HexBinaryType();
      element.Val = new DX.HexBinaryValue(value.ToString());
      return element;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(RGB? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var newValue = new DX.HexBinaryValue(value.ToString());
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }
}