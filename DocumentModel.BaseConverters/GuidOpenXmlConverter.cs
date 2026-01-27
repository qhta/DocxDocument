namespace DocumentModel.OpenXml;

/// <summary>
///   Defines a Guid converter from OpenXml. 
/// </summary>
public static class GuidOpenXmlConverter
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.StringValue)
  ];


  #region Guid get/set methods

  /// <summary>
  /// Retrieves a Guid value from a child element within an OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <returns>The Guid value, or null if not found.</returns>
  public static Guid? GetValue<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty.GetValue(_element);
        if (val != null)
        {
          var valType = val.GetType();
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value is string str)
          {
            return new Guid(str);
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a Guid value on a child element within an OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The Guid value to set. If null, the child element is removed.</param>
  /// <exception cref="InvalidOperationException">Thrown if the child element's "Val" property is not of type StringValue.</exception>
  public static void SetGuidVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, Guid? value) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        _element = (OpenXmlElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(DX.StringValue))
        valProperty.SetValue(_element, new DX.StringValue(value.ToString()));
      else
        throw new InvalidOperationException($"\"Value\" property of type {valType} unsupported");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts the specified string value to an Open XML object of the given target type.
  /// </summary>
  /// <remarks>Supported target types include subclasses of StringValue, DXW.StringType, DXW.String255Type,
  /// DXW.String253Type, OpenXmlLeafTextElement, and OpenXmlLeafElement. The method returns null if the input value is
  /// null.</remarks>
  /// <param name="value">The string value to convert. If null, the method returns null.</param>
  /// <param name="targetType">The target Open XML type to convert the value to. Must be a subclass of a supported Open XML type.</param>
  /// <returns>An object representing the converted Open XML value, or null if the input value is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if the specified target type is not supported for conversion.</exception>
  public static object? ConvertToOpenXml(Guid? value, Type targetType)
  {
    if (value == null) return null;

    var val = (Guid)value;
    if (targetType == typeof(DX.StringValue))
      return new DX.StringValue(val.ToString("B"));

    throw new NotSupportedException($"Conversion from Guid to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an Open XML value to its string representation, if supported.
  /// </summary>
  /// <param name="value">The Open XML value to convert. This can be an instance of StringValue, DXW.StringType, DXW.String255Type,
  /// DXW.String253Type, OpenXmlLeafTextElement, or OpenXmlLeafElement. May be null.</param>
  /// <returns>A string representation of the specified Open XML value, or null if <paramref name="value"/> is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if <paramref name="value"/> is not a supported Open XML type.</exception>
  public static Guid? ConvertFromOpenXml(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();

    if (value is DX.StringValue stringValue)
    {
      if (Guid.TryParse(stringValue.Value, out var result))
        return result;
      return null;
    }

    throw new NotSupportedException($"Conversion from type {sourceType} to Guid is not supported.");
  }

  #endregion
}