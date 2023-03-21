using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.VariantTypes;

namespace DocumentModel.OpenXml;

public static class HexBinaryConverter
{
  public static HexBinary? GetValue(DX.TypedOpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperty("Normal");
    if (valProperty != null)
    {
      var valPropertyValue = valProperty.GetValue(openXmlElement);
      if (valPropertyValue is string valStr)
        return Convert.FromHexString(valStr);
      if (valPropertyValue is HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        return Convert.FromHexString(hexBinaryValue.Value);
    }
    return null;
  }

  public static bool CmpValue(DX.TypedOpenXmlLeafElement? openXmlElement, HexBinary? value, DiffList? diffs, string? objName)
  {
    var valProperty = openXmlElement?.GetType().GetProperty("Normal");
    if (valProperty != null && value != null)
    {
      var valPropertyValue = valProperty.GetValue(openXmlElement);
      string? origStr = null;
      if (valPropertyValue is string valStr)
        origStr = valStr;
      if (valPropertyValue is HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        origStr = hexBinaryValue.Value;
      var valueStr = value.ToString();
      if (origStr!=null && origStr.Equals(valueStr)) return true;
      diffs?.Add(objName, openXmlElement?.GetType().ToString(), origStr, valueStr);
      return false;
    }
    if (valProperty == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }

  public static HexBinary? GetValue(string? value)
  {
    if (value != null)
      return Convert.FromHexString(value);
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(HexBinary? value)
    where HexBinaryType : DX.HexBinaryValue, new()
  {
    if (value != null)
    {
      var element = new HexBinaryType();
      element.Value = Convert.ToHexString(value);
      return element;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(HexBinary? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      if (((HexBinary)value).Length > 0)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Normal");
        if (valProperty != null)
          valProperty.SetValue(element, CreateValue<DX.HexBinaryValue>(value));
      }
      return element;
    }
    return null;
  }
}