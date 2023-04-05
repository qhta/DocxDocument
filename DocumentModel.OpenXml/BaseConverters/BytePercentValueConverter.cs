namespace DocumentModel.OpenXml;

public static class BytePercentValueConverter
{
  public static Percent? GetValue(DX.StringValue? element)
  {
    if (element?.Value != null)
      return Percent.FromHexString(element.Value);
    return null;
  }

  public static bool CmpValue(DX.StringValue? element, Percent? value, DiffList? diffs, string? objName, string? propName)
  {
    var valProperty = element?.GetType().GetProperty("Value");
    if (valProperty != null && value is not null)
    {
      var valStr = (string?)valProperty.GetValue(element);
      var valueStr = ((Percent)value).ToHexString();
      if (valStr == valueStr) return true;
      diffs?.Add(objName, element?.GetType().ToString(), valStr, valueStr);
      return false;
    }
    if (valProperty == null && value is null) return true;
    diffs?.Add(objName, propName ?? element?.GetType().ToString(), element, value);
    return false;
  }

  public static DX.StringValue? CreateStringValue(Percent? value)
  {
    if (value is not null) return new DX.StringValue(((Percent)value).ToHexString());
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Percent? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value is not null)
    {
      var newValue = new DX.StringValue(((Percent)value).ToHexString());
      var element = new OpenXmlElementType();
      var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
      if (valProperty != null)
        valProperty.SetValue(element, newValue);
      return element;
    }
    return null;
  }
}