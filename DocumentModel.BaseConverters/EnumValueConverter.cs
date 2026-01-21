namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Open XML EnumValue types.
/// </summary>
public static class EnumValueConverter
{
  /// <summary>
  /// Retrieves an EnumValue from the specified OpenXmlElement that has a "Val" property of OpenXml EnumValue type.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="ModelEnumType">The model enum type.</typeparam>
  /// <param name="openXmlElement">The OpenXmlElement to retrieve the value from.</param>
  /// <returns>The converted enum value, or null if retrieval or conversion fails.</returns>
  public static ModelEnumType? GetEnumValue<OpenXmlEnumType, ModelEnumType>(this DX.OpenXmlElement openXmlElement)
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, IConvertible
  {
    DX.EnumValue<OpenXmlEnumType>? element = openXmlElement as DX.EnumValue<OpenXmlEnumType>;
    if (element == null)
    {
      var valProp = openXmlElement.GetType().GetProperty("Val");
      element = valProp?.PropertyType as DX.EnumValue<OpenXmlEnumType>;

    }
    if (element?.Value != null)
    {
      var n = (int)System.Convert.ChangeType(element.Value, typeof(int));
      var result = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return result;
    }
    return null;
  }

  /// <summary>
  /// Retrieves an EnumValue from the specified OpenXml EnumValue object.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="ModelEnumType">The model enum type.</typeparam>
  /// <param name="element">The OpenXml EnumValue object.</param>
  /// <returns>The converted enum value, or null if the input is null.</returns>
  public static ModelEnumType? GetEnumValue<OpenXmlEnumType, ModelEnumType>(this DX.EnumValue<OpenXmlEnumType> element)
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, IConvertible
  {
    if (element?.Value != null)
    {
      var n = (int)System.Convert.ChangeType(element.Value, typeof(int));
      var result = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return result;
    }
    return null;
  }

  /// <summary>
  /// Converts a generic enum value to a model enum type.
  /// </summary>
  /// <typeparam name="OpenXmlEnumValue">The source enum type.</typeparam>
  /// <typeparam name="ModelEnumType">The target model enum type.</typeparam>
  /// <param name="value">The value to convert.</param>
  /// <returns>The converted enum value, or null if the input is null.</returns>
  public static ModelEnumType? Convert<ModelEnumType, OpenXmlEnumValue>(OpenXmlEnumValue? value)
    where OpenXmlEnumValue : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      var result = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return result;
    }
    return null;
  }

  /// <summary>
  /// Creates a model enum value from a nullable UInt16.
  /// </summary>
  /// <typeparam name="ModelEnumType">The target model enum type.</typeparam>
  /// <param name="value">The UInt16 value.</param>
  /// <returns>The converted enum value, or null if the input is null.</returns>
  public static ModelEnumType? CreateEnum<ModelEnumType>(this UInt16? value)
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      var val = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return val;
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXml EnumValue from a model enum value.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The target OpenXml enum type.</typeparam>
  /// <typeparam name="ModelEnumType">The source model enum type.</typeparam>
  /// <param name="value">The model enum value.</param>
  /// <returns>A new OpenXml EnumValue object, or null if the input is null.</returns>
  public static DX.EnumValue<OpenXmlEnumType>? CreateEnumValue<OpenXmlEnumType, ModelEnumType>(this ModelEnumType? value)
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var element = new DX.EnumValue<OpenXmlEnumType>();
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
      element.Value = val;
      return element;
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXml element and sets its "Val" property based on a model enum value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXml element to create.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type expected by the element.</typeparam>
  /// <typeparam name="ModelEnumType">The source model enum type.</typeparam>
  /// <param name="value">The model enum value.</param>
  /// <returns>A new instance of the OpenXml element with the "Val" property set.</returns>
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType, OpenXmlEnumType, ModelEnumType>(this ModelEnumType value)
  where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  where ModelEnumType : struct, IConvertible
  {
    var element = new OpenXmlElementType();
    UpdateOpenXmlElement<OpenXmlEnumType, ModelEnumType>(element, value);
    return element;
  }

  /// <summary>
  /// Updates an existing OpenXml element's "Val" property based on a model enum value.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type expected by the element.</typeparam>
  /// <typeparam name="ModelEnumType">The source model enum type.</typeparam>
  /// <param name="element">The OpenXml element to update.</param>
  /// <param name="value">The model enum value.</param>
  /// <exception cref="InvalidOperationException">Thrown if the element does not have a suitable "Val", "Value", or "Type" property.</exception>
  public static void UpdateOpenXmlElement<OpenXmlEnumType, ModelEnumType>(this DX.OpenXmlLeafElement element, ModelEnumType value)
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  where ModelEnumType : struct, IConvertible
  {
    var n = (int)System.Convert.ChangeType(value, typeof(int));
    var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
    var valueProperty = element.GetType().GetProperty("Type") ??
      element.GetType().GetProperty("Value") ?? element.GetType().GetProperty("Val");
    //if (valueProperty == null)
    //  valueProperty = element.GetType().GetProperties().FirstOrDefault(item => item.PropertyType == typeof(OpenXmlEnumType));
    if (valueProperty == null /*|| valueProperty.PropertyType != typeof(OpenXmlEnumType)*/)
      throw new InvalidOperationException($"Type \"{element.GetType()}\" does not have a property of \"{typeof(OpenXmlEnumType)}\" type");
    valueProperty.SetValue(element, new DocumentFormat.OpenXml.EnumValue<OpenXmlEnumType>(val));
  }

  #region EnumType get/set methods
  /// <summary>
  /// Retrieves an OpenXml enum value from the "Val" property of a specific child element within a composite element.
  /// </summary>
  /// <typeparam name="EnumType">The expected enum type.</typeparam>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <returns>The enum value, or null if not found or conversion fails.</returns>
  public static EnumType? GetEnumVal<EnumType, OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where EnumType : struct
  where OpenXmlElementType : DX.OpenXmlLeafElement
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
          Debug.Assert(valType.Name.StartsWith("EnumValue`1"), $"\"Val\" property in {typeof(OpenXmlElementType)} must be EnumValue<>");
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value != null)
          {
            var openXmlEnumType = value.GetType();
            if (openXmlEnumType != typeof(EnumType))
            {
              if (value is IConvertible)
              {
                var n = (int)System.Convert.ChangeType(value, typeof(int));
                value = Enum.ToObject(typeof(EnumType), n);
              }
              else
              {
                var property = openXmlEnumType.GetProperties(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(prop => value.Equals(prop.GetValue(null)));
                if (property != null)
                {
                  var s = property.Name;
                  var k = s.IndexOf(' ');
                  if (k > 0)
                    s = s.Substring(0, k);
                  var newValue = Enum.Parse(typeof(EnumType), s, true);
                  return (EnumType)newValue;
                }
              }
            }
            return (EnumType)value;
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets an OpenXml enum value on the "Val" property of a specific child element within a composite element.
  /// </summary>
  /// <typeparam name="EnumType">The type of the enum value to set.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The underlying OpenXml enum type.</typeparam>
  /// <typeparam name="ElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The enum value to set. If null, the child element is removed.</param>
  public static void SetEnumVal<EnumType, OpenXmlEnumType, ElementType>(this DX.OpenXmlCompositeElement openXmlElement, EnumType? value) where EnumType : struct
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
    where ElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(ElementType).GetConstructor(Type.EmptyTypes);
        Debug.Assert(constructor != null, $"Type {typeof(ElementType)} must have constructor with no parameters");
        _element = (ElementType)constructor.Invoke(Array.Empty<object>());
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(ElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
      var valType = valProperty.PropertyType;
      Debug.Assert(valType.Name.StartsWith("EnumValue`1"), $"\"Val\" property in {typeof(ElementType)} must be EnumValue<>");
      var valueType = valType.GetGenericArguments()[0];
      var newValue = EnumValueUtils.EnumTypeToEnumValue<EnumType, OpenXmlEnumType>(value.Value);
      valProperty.SetValue(_element, newValue);
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  /// <summary>
  /// Retrieves an OpenXmlEnumType value from the specified OpenXml EnumValue object.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The type of the enum value to retrieve.</typeparam>
  /// <param name="element">The OpenXml EnumValue object.</param>
  /// <returns>The enum value, or null if the element is null.</returns>
  public static OpenXmlEnumType? GetValue<OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType>? element)
 where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    if (element == null) return null;
    object value = element.Value;
    return (OpenXmlEnumType?)value;
  }

  /// <summary>
  /// Retrieves an enum type value from the specified OpenXml EnumValue object, performing conversion if necessary.
  /// </summary>
  /// <typeparam name="EnumType">The target enum type.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The source OpenXml enum type.</typeparam>
  /// <param name="element">The OpenXml EnumValue object.</param>
  /// <returns>The converted enum value, or null if the element is null.</returns>
  public static EnumType? GetValue<EnumType, OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType>? element)
    where EnumType : struct
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    if (element == null) return null;
    object value = element.Value;
    if (typeof(OpenXmlEnumType) != typeof(EnumType))
    {
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      value = Enum.ToObject(typeof(EnumType), n);
    }
    return (EnumType)value;
  }

  /// <summary>
  /// Creates an OpenXml EnumValue instance from a generic enum value.
  /// </summary>
  /// <typeparam name="EnumType">The source enum type.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The target OpenXml enum type.</typeparam>
  /// <param name="value">The enum value to convert.</param>
  /// <returns>A new DX.EnumValue containing the converted value, or null if the input is null.</returns>
  public static DX.EnumValue<OpenXmlEnumType>? SetValue<EnumType, OpenXmlEnumType>(this EnumType? value) where EnumType : struct
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    if (value == null)
      return null;
    object? newValue;
    if (typeof(OpenXmlEnumType) != typeof(EnumType))
    {
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      newValue = Enum.ToObject(typeof(OpenXmlEnumType), n);
    }
    else
      newValue = value;
    return new DX.EnumValue<OpenXmlEnumType>((OpenXmlEnumType)newValue);
  }

  #endregion

  /// <summary>
  /// Creates an OpenXmlElement based on the provided enumVal and conversion type.
  /// </summary>
  /// <param name="enumVal">The enumVal to convert. It should be an enum enumVal.</param>
  /// <param name="conversionType">The target Open XML element type.</param>
  /// <returns>The created Open XML element, or null if the enumVal is null.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  public static object? CreateOpenXmlElement(object? enumVal, Type conversionType)
  {
    //DXW.CaptionPositionValues
    //DX.EnumValue<DXW.CaptionPositionValues> enumValue = null;
    if (enumVal == null) return null;

    if (conversionType.Name.StartsWith("EnumValue`"))
    {
      var paramType = conversionType.GetGenericArguments()[0];
      var valueName = Enum.GetName(enumVal.GetType(), enumVal)!;
      var targetProp = paramType.GetProperty(valueName, BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase);
      if (targetProp != null)
      {
        var targetValue = targetProp.GetValue(null, []);
        var enumValueType = typeof(DX.EnumValue<>).MakeGenericType(paramType);
        var enumValueInstance = Activator.CreateInstance(enumValueType, targetValue);
        return enumValueInstance;

      }
    }

    throw new InvalidOperationException($"Cannot create Open XML element for {enumVal} of type {enumVal.GetType()}");
  }

  /// <summary>
  /// Converts an Open XML enum value to its corresponding value in the specified model enum type.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element representing the enum value. This should be an object whose type name starts with
  /// "EnumValue`" and contains a "Value" property. Can be null.</param>
  /// <param name="modelType">The target enum type to which the value should be converted. Must be a valid enum type.</param>
  /// <returns>An object representing the equivalent value in the specified model enum type, or null if <paramref
  /// name="openXmlElement"/> is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if <paramref name="openXmlElement"/> is not a supported Open XML enum value or does not contain a
  /// convertible value.</exception>
  public static object? GetEnumValue(object? openXmlElement, Type modelType)
  {
    //DX.EnumValue
    if (openXmlElement == null) return null;
    var openXmlType = openXmlElement.GetType();
    if (openXmlType.Name.StartsWith("EnumValue`"))
    {
      var enumValueProperty = openXmlType.GetProperty("Value");
      if (enumValueProperty != null)
      {
        var enumValue = enumValueProperty.GetValue(openXmlElement);
        if (enumValue == null)
          throw new InvalidOperationException($"{openXmlElement} has no Value");
        var enumValueType = enumValue.GetType();

        var enumValueTypeProperties = enumValueType.GetProperties(BindingFlags.Public | BindingFlags.Static);
        var enumValues = enumValueTypeProperties
          .Select(prop => prop.GetValue(null))
          .ToArray();
        for (var i=0; i< enumValues.Length; i++)
        {
          var ev = enumValues[i];
          if (ev != null && ev.Equals(enumValue))
          {
            var enumName = enumValueTypeProperties[i].Name;
            var result = Enum.Parse(modelType, enumName, true);
            return result;
          }
        }

      }
    }
    throw new InvalidOperationException($"Cannot get enum openXmlElement from {openXmlElement} of type {openXmlElement.GetType()}");
  }

}