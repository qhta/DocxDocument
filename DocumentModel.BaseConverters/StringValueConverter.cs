using System.Diagnostics;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentModel.OpenXml;

public static class StringValueConverter
{
  #region StringValue conversion methods
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

  #region StringType conversion methods
  public static string? GetValue(DXW.StringType? element)
  {
    if (element == null)
      return null;
    return element?.Val?.Value ?? string.Empty;
  }

  #endregion

  #region String255Type conversion methods
  public static string GetValue(DXW.String255Type element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  #endregion

  #region TextElement conversion methods
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

  #region OpenXmlLeafElement with Val property conversion methods
  public static string? GetStringVal<OpenXmlElementType> (this DX.OpenXmlCompositeElement? openXmlElement, 
    string? propName = null) 
    where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element != null)
      {
        if (propName==null) propName = "Val";
        var valProperty = typeof(OpenXmlElementType).GetProperty(propName);
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty.GetValue(element);
        if (val != null)
        {
          var valType = val.GetType();
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value is not null)
          {
            if (value is string str)
              return str;
            return value.ToString();
          }
        }
      }
    }
    return null;
  }

  public static void SetStringVal<OpenXmlElementType>(this OpenXmlCompositeElement openXmlElement, String? value,
    string? propName = null) 
    where OpenXmlElementType : TypedOpenXmlLeafElement, new()
  {
    if (propName==null)
      propName = "Val";
    var valProperty = typeof(OpenXmlElementType).GetProperty(propName);
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
    if (itemElement != null)
    {
      if (value != null)
        valProperty.SetValue(itemElement, new StringValue(value));
      else
        itemElement.Remove();
    }
    else
    if (value != null)
    {
      itemElement = new OpenXmlElementType();
      valProperty.SetValue(itemElement, new StringValue(value));
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion
}