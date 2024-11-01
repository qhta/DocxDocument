﻿namespace DocumentModel.OpenXml;

public static class HexIntConverter
{
  #region HexBinaryValue
  public static HexInt? GetValue(DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;
    return null;
  }

  public static bool CmpValue(DX.HexBinaryValue? element, HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (element?.Value != null)
    {
      var val = HexIntConverter.GetValue(element.Value);
      if (val == value) return true;
    }
    if (element?.Value == null && value == null) return true;
    diffs?.Add(objName, propName, element?.Value, value);
    return false;
  }

  public static void SetValue<ElementType>(OpenXmlCompositeElement openXmlElement, HexInt? value)
    where ElementType : OpenXmlElement, new()
  {
    var valProperty = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    Debug.Assert(valProperty!=null);
    var itemElement = openXmlElement.GetFirstChild<ElementType>();
    if (itemElement != null)
    {
      if (value!=null)
        valProperty.SetValue(itemElement, HexIntConverter.CreateHexBinaryValue(value));
      else
        itemElement.Remove();
    }
    else
    if (value != null)
    {
      itemElement = new ElementType();
      valProperty.SetValue(itemElement, new HexBinaryValue(value.ToString()));
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  public static HexInt? GetValue(DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

    public static HexInt? GetValue(DX.TypedOpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(HexBinaryValue));
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

    public static bool CmpValue(DX.TypedOpenXmlLeafElement? element, HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var valProperty = element?.GetType().GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(HexBinaryValue));
    if (valProperty != null && value != null)
    {
      var valStr = (string?)valProperty.GetValue(element);
      var valueStr = value.ToString();
      if (valStr == valueStr) return true;
      diffs?.Add(objName, propName ?? element?.GetType().ToString(), valStr, valueStr);
      return false;
    }
    if (valProperty == null && value == null) return true;
    diffs?.Add(objName, propName ?? element?.GetType().ToString(), element, value);
    return false;
  }

  public static DX.HexBinaryValue? CreateHexBinaryValue(HexInt? value)
  {
    if (value != null) return new DX.HexBinaryValue(value.ToString());
    return null;
  }

  public static StringValue? CreateStringValue(HexInt? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value.ToString() };
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
    var valProperty = typeof(OpenXmlElementType).GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(HexBinaryValue));
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }

}