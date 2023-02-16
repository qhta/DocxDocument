namespace DocumentModel.OpenXml;

public static class HexIntConverter
{
  public static HexInt? GetValue(DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;
    return null;
  }

  public static HexInt? GetValue(DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

    public static HexInt? GetValue(DX.TypedOpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperty("Val");
    if (valProperty != null)
    {
      var value = valProperty.GetValue(openXmlElement);
      if (value is string valStr)
        return valStr;
      if (value is HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        return hexBinaryValue.Value;
    }
    return null;
  }

    public static bool CmpValue(DX.TypedOpenXmlLeafElement? element, HexInt? value, DiffList? diffs, string? objName)
  {
    var valProperty = element?.GetType().GetProperty("Val");
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

  public static DX.HexBinaryValue? CreateHexBinaryValue(HexInt? value)
  {
    if (value != null) return new DX.HexBinaryValue(value.ToString());
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(HexInt? value)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(HexInt? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var newValue = new DX.HexBinaryValue(value.ToString());
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }
}