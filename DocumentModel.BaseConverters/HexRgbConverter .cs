﻿namespace DocumentModel.OpenXml;

public static class HexRgbConverter
{
  public static HexRgb? GetValue(DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;
    return null;
  }

  public static HexRgb? GetValue(DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

    public static HexRgb? GetValue(DX.OpenXmlLeafElement? openXmlElement)
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

  public static DX.HexBinaryValue? CreateHexBinaryValue(HexRgb? value)
  {
    if (value is not null) return new DX.HexBinaryValue(value);
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(HexRgb? value)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(HexRgb? value)
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