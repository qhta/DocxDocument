using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml;

public static class StringValueConverter
{
  public static string GetValue(DX.StringValue element)
  {
    return element.Value ?? string.Empty;
  }

  public static bool CmpValue(DX.StringValue element, string? value, DiffList? diffs, string? objName)
  {
    if (element.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Value, value);
    return false;
  }

  public static string GetValue(DXW.StringType element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  public static bool CmpValue(DXW.StringType element, string? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static string GetValue(DXW.String255Type element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  public static bool CmpValue(DXW.String255Type element, string? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static string GetValue(DX.TypedOpenXmlLeafTextElement element)
  {
    return element.Text;
  }

  public static bool CmpValue(DX.TypedOpenXmlLeafTextElement element, string? value, DiffList? diffs, string? objName)
  {
    if (element.Text == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Text, value);
    return false;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(string value) where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val") ??
                      typeof(OpenXmlElementType).GetProperty("Text");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }
}