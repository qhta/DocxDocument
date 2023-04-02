namespace DocumentModel.OpenXml;

public static class HexCharConverter
{
  public static HexChar? GetValue(DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;
    return null;
  }

  public static HexChar? GetValue(DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

    public static HexChar? GetValue(DX.TypedOpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperty("Value");
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

    public static bool CmpValue(DX.TypedOpenXmlLeafElement? element, HexChar? value, DiffList? diffs, string? objName)
  {
    var valProperty = element?.GetType().GetProperty("Value");
    if (valProperty != null && value is not null)
    {
      var valStr = (string?)valProperty.GetValue(element);
      var valueStr = value.ToString();
      if (valStr == valueStr) return true;
      diffs?.Add(objName, element?.GetType().ToString(), valStr, valueStr);
      return false;
    }
    if (valProperty == null && value is null) return true;
    diffs?.Add(objName, element?.GetType().ToString(), element, value);
    return false;
  }

  public static DX.HexBinaryValue? CreateHexBinaryValue(HexChar? value)
  {
    if (value is not null) return new DX.HexBinaryValue(value);
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(HexChar? value)
    where HexBinaryType : DXW.LongHexNumberType, new()
  {
    if (value is not null)
    {
      var element = new HexBinaryType();
      element.Val = new DX.HexBinaryValue(value);
      return element;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(HexChar? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var newValue = new DX.HexBinaryValue(value);
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }
}