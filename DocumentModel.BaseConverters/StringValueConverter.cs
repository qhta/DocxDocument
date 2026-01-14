namespace DocumentModel.OpenXml;

/// <summary>
/// Provides helper methods for converting string values to and from OpenXml elements.
/// </summary>
public static class StringValueConverter
{
  #region StringValue conversion methods
  /// <summary>
  /// Retrieves the value of a StringValue as a nullable string.
  /// </summary>
  /// <param name="element">The StringValue to convert.</param>
  /// <returns>The string value or null if the element is null.</returns>
  public static string? GetValue(StringValue? element)
  {
    return element?.Value;
  }

  /// <summary>
  /// Creates a StringValue from a nullable string.
  /// </summary>
  /// <param name="value">The string value.</param>
  /// <returns>A new StringValue containing the string, or null if the input string is null.</returns>
  public static StringValue? CreateStringValue(String? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value };
  }
  #endregion

  #region StringType conversion methods
  /// <summary>
  /// Retrieves the string value from a StringType element.
  /// </summary>
  /// <param name="element">The StringType element.</param>
  /// <returns>The string value, or an empty string if result cannot be determined.</returns>
  public static string? GetValue(DXWP.StringType? element)
  {
    if (element == null)
      return null;
    return element?.Val?.Value ?? string.Empty;
  }

  #endregion

  #region String255Type conversion methods
  /// <summary>
  /// Retrieves the string value from a String255Type element.
  /// </summary>
  /// <param name="element">The String255Type element.</param>
  /// <returns>The string value, or an empty string if the value is null.</returns>
  public static string GetValue(DXWP.String255Type element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  #endregion

  #region TextElement conversion methods
  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafTextElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement.</param>
  /// <returns>The text content of the element.</returns>
  public static string GetValue(DX.OpenXmlLeafTextElement element)
  {
    return element.Text;
  }

  /// <summary>
  /// Creates a generic OpenXml element and sets its value or text property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">Type of the OpenXml element to create.</typeparam>
  /// <param name="value">The string value to set.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
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
  /// <summary>
  /// Retrieves a string value from a specific child element of a composite element.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="propName">The name of the property to retrieve the value from (default is "Val").</param>
  /// <returns>The string value of the property, or null if not found.</returns>
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

  /// <summary>
  /// Sets a string value on a specific child element of a composite element.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The string value to set. If null, the child element is removed.</param>
  /// <param name="propName">The name of the property to set the value on (default is "Val").</param>
  public static void SetStringVal<OpenXmlElementType>(this OpenXmlCompositeElement openXmlElement, String? value,
    string? propName = null) 
    where OpenXmlElementType : OpenXmlLeafElement, new()
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