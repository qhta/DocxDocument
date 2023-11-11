using System.Diagnostics;

using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml;

public static class StringValueConverter
{
  #region StringValue
  public static string? GetValue(StringValue? element)
  {
    return element?.Value;
  }

  public static StringValue? CreateStringValue(String? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value };
  }
  #endregion

  #region StringType
  public static string? GetValue(DXW.StringType? element)
  {
    if (element == null)
      return null;
    return element?.Val?.Value ?? string.Empty;
  }

  #endregion

  #region String255Type
  public static string GetValue(DXW.String255Type element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  #endregion

  #region TextElement
  public static string GetValue(DX.TypedOpenXmlLeafTextElement element)
  {
    return element.Text;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(string value) where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val") ?? typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, new StringValue(value));
    else
    {
      var textProperty = typeof(OpenXmlElementType).GetProperty("Text");
      if (textProperty != null)
        textProperty.SetValue(element, value);
    }
    return element;
  }
  #endregion

  #region TypeOpenXmlLeafElement with Val property
  //public static string? GetValue(TypedOpenXmlLeafElement? openXmlElement)
  //{
  //  if (openXmlElement == null) return null;
  //  var valProperty = openXmlElement.GetType().GetProperty("Val");
  //  if (valProperty != null)
  //    return openXmlElement?.Val?.Value;
  //}

  //public static StringValue? CreateStringValue(String? value)
  //{
  //  if (value == null) return null;
  //  return new StringValue { Value = value };
  //}

  public static void SetValue<ElementType>(OpenXmlCompositeElement openXmlElement, String? value)
    where ElementType : TypedOpenXmlLeafElement, new()
  {
    var valProperty = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<ElementType>();
    if (itemElement != null)
    {
      if (value != null)
        valProperty.SetValue(itemElement, value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
    {
      itemElement = new ElementType();
      valProperty.SetValue(itemElement, new StringValue(value));
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion
}