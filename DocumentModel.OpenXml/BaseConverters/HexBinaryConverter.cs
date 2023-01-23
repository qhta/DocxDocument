using DocumentFormat.OpenXml.VariantTypes;

namespace DocumentModel.OpenXml;

public static class HexBinaryConverter
{
  public static byte[]? GetValue(DX.TypedOpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperty("Val");
    if (valProperty != null)
    {
      var valStr = (string?)valProperty.GetValue(openXmlElement);
      if (valStr != null)
        return Convert.FromHexString(valStr);
    }
    return null;
  }

  public static bool CmpValue(DX.TypedOpenXmlLeafElement? element, byte[]? value, DiffList? diffs, string? objName)
  {
    var valProperty = element?.GetType().GetProperty("Val");
    if (valProperty != null && value != null)
    {
      var valStr = (string?)valProperty.GetValue(element);
      var valueStr = Convert.ToHexString(value);
      if (valStr == valueStr) return true;
      diffs?.Add(objName, element?.GetType().ToString(), valStr, valueStr);
      return false;
    }
    if (valProperty == null && value == null) return true;
    diffs?.Add(objName, element?.GetType().ToString(), element, value);
    return false;
  }

  public static byte[]? GetValue(string? value)
  {
    if (value != null)
      return Convert.FromHexString(value);
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(byte[]? value)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(byte[]? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      if (value.Length > 0)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
        if (valProperty != null)
          valProperty.SetValue(element, CreateValue<DX.HexBinaryValue>(value));
      }
      return element;
    }
    return null;
  }
}