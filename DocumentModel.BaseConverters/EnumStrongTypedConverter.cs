namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Open XML EnumValue types.
/// </summary>
public static partial class EnumTypeConverter
{

  #region Strongly-typed conversion

  /// <summary>
  /// Retrieves an EnumValue from the specified OpenXmlElement Ithat has a "Val" property of OpenXml EnumValue type.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="ModelEnumType">The model enum type.</typeparam>
  /// <param name="openXmlElement">The OpenXmlElement to retrieve the value from.</param>
  /// <returns>The converted enum value, or null if retrieval or conversion fails.</returns>
  public static ModelEnumType? GetEnumValue<OpenXmlEnumType, ModelEnumType>(this DX.OpenXmlLeafElement openXmlElement)
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, Enum
  {

    var result = GetEnumValue(openXmlElement, typeof(ModelEnumType));
    return (ModelEnumType)result!;
  }

  /// <summary>
  /// Retrieves an EnumValue from the specified OpenXml EnumValue object.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="ModelEnumType">The model enum type.</typeparam>
  /// <param name="element">The OpenXml EnumValue object.</param>
  /// <returns>The converted enum value, or null if the input is null.</returns>
  public static ModelEnumType? GetEnumValue<OpenXmlEnumType, ModelEnumType>(this DX.EnumValue<OpenXmlEnumType> element)
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, IConvertible
  {
    if (element?.Value == null)
      return null;

    var result = element.EnumValueToEnumType<ModelEnumType, OpenXmlEnumType>();
    return result;
  }

  /// <summary>
  /// Converts a generic enum value to a model enum type.
  /// </summary>
  /// <typeparam name="OpenXmlEnumValue">The source enum type.</typeparam>
  /// <typeparam name="ModelEnumType">The target model enum type.</typeparam>
  /// <param name="value">The value to convert.</param>
  /// <returns>The converted enum value, or null if the input is null.</returns>
  public static ModelEnumType? ConvertFrom<ModelEnumType, OpenXmlEnumValue>(OpenXmlEnumValue? value)
    where OpenXmlEnumValue : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumValue>
    where ModelEnumType : struct, IConvertible
  {
    if (value == null)
      return null;

    var enumValue = new DX.EnumValue<OpenXmlEnumValue>(value.Value);
    var converted = enumValue.EnumValueToEnumType<ModelEnumType, OpenXmlEnumValue>();
    if (converted.HasValue)
      return converted.Value;

    throw new InvalidOperationException(
      $"Cannot convert value '{value}' of type {typeof(OpenXmlEnumValue)} to {typeof(ModelEnumType)}.");
  }

  /// <summary>
  /// Creates an OpenXml element and sets its "Val" property based on a model enum value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXml element to create.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type expected by the element.</typeparam>
  /// <typeparam name="ModelEnumType">The source model enum type.</typeparam>
  /// <param name="value">The model enum value.</param>
  /// <returns>A new instance of the OpenXml element with the "Val" property set.</returns>
  public static OpenXmlElementType ConvertTo<OpenXmlElementType, OpenXmlEnumType, ModelEnumType>
    (ModelEnumType value) where OpenXmlElementType : DX.OpenXmlLeafElement, new()
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, Enum
  {
    var element = new OpenXmlElementType();
    var result = ConvertTo(value, typeof(OpenXmlElementType));
    return (OpenXmlElementType)result!;
  }

  /// <summary>
  /// Strongly-typed conversion of a model enum value to an OpenXml enum type.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="ModelEnumType">The model enum type.</typeparam>
  /// <param name="value">The model enum value.</param>
  /// <returns>The converted OpenXml enum value.</returns>
  public static OpenXmlEnumType ConvertTo<OpenXmlEnumType, ModelEnumType>(ModelEnumType value) 
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, Enum
  {
    var result = ConvertToEnumValue(value, typeof(OpenXmlEnumType));
    return (OpenXmlEnumType)result!;
  }
  #endregion

  #region EnumType get/set methods

  /// <summary>
  /// Retrieves an OpenXml enum value from the "Val" property of a specific child element within a composite element.
  /// </summary>
  /// <typeparam name="EnumType">The expected enum type.</typeparam>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <returns>The enum value, or null if not found or conversion fails.</returns>
  public static EnumType? GetEnumVal<EnumType, OpenXmlElementType>
    (this DX.OpenXmlCompositeElement? openXmlElement) where EnumType : struct, Enum
    where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty!.GetValue(_element);
        if (val != null)
        {
          var valType = val.GetType();
          Debug.Assert(valType.Name.StartsWith("EnumValue`1"),
            $"\"Val\" property in {typeof(OpenXmlElementType)} must be EnumValue<>");
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty!.GetValue(val);
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
                var property = openXmlEnumType.GetProperties(BindingFlags.Static | BindingFlags.Public)
                  .FirstOrDefault(prop => value.Equals(prop.GetValue(null)));
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
  public static void SetEnumVal<EnumType, OpenXmlEnumType, ElementType>
    (this DX.OpenXmlCompositeElement openXmlElement, EnumType? value) where EnumType : struct
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where ElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(ElementType).GetConstructor(Type.EmptyTypes);
        Debug.Assert(constructor != null, $"Type {typeof(ElementType)} must have constructor with no parameters");
        _element = (ElementType)constructor!.Invoke(Array.Empty<object>());
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(ElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
      var valType = valProperty!.PropertyType;
      Debug.Assert(valType.Name.StartsWith("EnumValue`1"),
        $"\"Val\" property in {typeof(ElementType)} must be EnumValue<>");
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
  public static OpenXmlEnumType? GetValue<OpenXmlEnumType>
    (this DX.EnumValue<OpenXmlEnumType>? element)
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
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
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
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
  public static DX.EnumValue<OpenXmlEnumType>? CreateOpenXmlEnumValue<OpenXmlEnumType, EnumType>(EnumType? value)
    where EnumType : Enum
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
  {
    if (value == null)
      return null;

    var result = CreateOpenXmlEnumValue(value, typeof(DX.EnumValue<OpenXmlEnumType>))!;

    return (DX.EnumValue<OpenXmlEnumType>)result;
  }

  #endregion

  #region Generic EnumValue conversion

  /// <summary>
  /// Creates an Open XML enum value object corresponding to the specified model enum value and target Open XML enum
  /// type.
  /// </summary>
  /// <param name="enumVal">The model enum value to convert. If null, the method returns null.</param>
  /// <param name="openXmlType">The target Open XML enum type to create. Must be a generic EnumValue&lt;T&gt; type compatible with the provided enum
  /// value.</param>
  /// <returns>An instance of the specified Open XML enum value type representing the provided enum value, or null if <paramref
  /// name="enumVal"/> is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the specified enum value does not correspond to a value in the target Open XML enum type, or if the type
  /// is not a supported EnumValue&lt;T&gt; type.</exception>
  public static object? CreateOpenXmlEnumValue(Enum? enumVal, Type openXmlType)
  {
    if (enumVal == null) return null;

    if (openXmlType.Name.StartsWith("EnumValue`"))
    {
      var paramType = openXmlType.GetGenericArguments()[0];
      var valueName = Enum.GetName(enumVal.GetType(), enumVal)!;
      var targetProp =
        paramType.GetProperty(valueName, BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase);
      if (targetProp == null)
        throw new InvalidOperationException($"Cannot find enum value {valueName} in type {paramType}");

      var targetValue = targetProp.GetValue(null, []);
      var enumValueType = typeof(DX.EnumValue<>).MakeGenericType(paramType);
      var enumValueInstance = Activator.CreateInstance(enumValueType, targetValue);
      return enumValueInstance;
    }
    throw new InvalidOperationException($"Cannot create Open XML element for {enumVal} of type {enumVal.GetType()}");
  }

  /// <summary>
  /// Converts an Open XML EnumValue to its corresponding value in the specified model enum type.
  /// </summary>
  /// <param name="openXmlEnumValue">The Open XML element representing the enum value. This should be an object whose type name starts with
  /// "EnumValue`" and contains a "Value" property. Can be null.</param>
  /// <param name="modelType">The target enum type to which the value should be converted. Must be a valid enum type.</param>
  /// <returns>An object representing the equivalent value in the specified model enum type, or null if <paramref
  /// name="openXmlEnumValue"/> is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if <paramref name="openXmlEnumValue"/> is not a supported Open XML enum value or does not contain a
  /// convertible value.</exception>
  public static Enum? GetEnumValue(object? openXmlEnumValue, Type modelType)
  {
    if (openXmlEnumValue == null) return null;

    var openXmlType = openXmlEnumValue.GetType();
    if (openXmlType.Name.StartsWith("EnumValue`"))
    {
      var enumValueProperty = openXmlType.GetProperty("Value");
      if (enumValueProperty == null)
        throw new InvalidOperationException($"{openXmlEnumValue} has no Value property");

      var enumValue = enumValueProperty.GetValue(openXmlEnumValue);
      if (enumValue == null)
        throw new InvalidOperationException($"{openXmlEnumValue} has no Value");

      var enumValueType = enumValue.GetType();
      var enumValueTypeProperties = enumValueType.GetProperties(BindingFlags.Public | BindingFlags.Static);
      var enumValues = enumValueTypeProperties.Select(prop => prop.GetValue(null)).ToArray();
      for (var i = 0; i < enumValues.Length; i++)
      {
        var ev = enumValues[i];
        if (ev != null && ev.Equals(enumValue))
        {
          var enumName = enumValueTypeProperties[i].Name;
          try
          {
            var result = Enum.Parse(modelType, enumName, true);
            return (Enum?)result;
          }
          catch (ArgumentException)
          {
            throw new InvalidOperationException($"Cannot parse enum name {enumName} to type {modelType}");
          }
        }
      }
      throw new InvalidOperationException($"Cannot find matching enum value for {enumValue} in {modelType}");
    }
    throw new InvalidOperationException(
      $"Cannot get enum openXmlEnumValue from {openXmlEnumValue} of type {openXmlEnumValue.GetType()}");
  }

  #endregion

  #region Generic OpenXmlLeafElement conversion

  /// <summary>
  /// Creates an Open XML element instance corresponding to the specified enumeration value and target type.
  /// </summary>
  /// <remarks>The method expects the OpenXmlElement to have a property named 'Value' or 'Val' Ithat holds the
  /// underlying enumeration value. If neither property is found, or if the value is missing, an exception is
  /// thrown.</remarks>
  /// <param name="enumVal">The enumeration value to convert to an Open XML element. May be null.</param>
  /// <param name="openXmlType">The target type of the Open XML element to create. Must be a subclass of DX.OpenXmlElement.</param>
  /// <returns>An object representing the Open XML element corresponding to the specified enumeration value and target type, or
  /// null if <paramref name="enumVal"/> is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the target type does not have a suitable property (Val, Value, or Type), if the value cannot be
  /// retrieved from the enumeration, or if the target type is not a subclass of DX.OpenXmlElement.</exception>
  public static DX.OpenXmlLeafElement? ConvertTo(Enum? enumVal, Type openXmlType)
  {
    if (enumVal == null) return null;

    if (openXmlType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProperty = openXmlType.GetProperty("Val") ?? openXmlType.GetProperty("Value");
      if (valProperty == null)
        throw new InvalidOperationException($"Cannot find Val/Value/Type property in {openXmlType}");

      var valPropertyType = valProperty.PropertyType!;
      if (!valPropertyType.Name.StartsWith("EnumValue`"))
        throw new InvalidOperationException(
          $"Cannot create Open XML element for {enumVal} of type {enumVal.GetType()}");

      var targetValue = CreateOpenXmlEnumValue(enumVal, valPropertyType);
      if (targetValue == null)
        throw new InvalidOperationException($"Cannot create EnumValue from {enumVal} for property {valProperty.Name}");

      var openXmlElement = (DX.OpenXmlLeafElement)Activator.CreateInstance(openXmlType)!;
      valProperty.SetValue(openXmlElement, targetValue);
      return openXmlElement;
    }
    throw new InvalidOperationException($"Cannot create Open XML element for {enumVal} of type {enumVal.GetType()}");
  }

  /// <summary>
  /// Gets the model enum value from the specified OpenXmlElement based on the provided model type.
  /// </summary>
  /// <remarks>The method expects the OpenXmlElement to have a property named 'Value' or 'Val' Ithat holds the
  /// underlying enumeration value. If neither property is found, or if the value is missing, an exception is
  /// thrown.</remarks>
  /// <param name="openXmlElement">The OpenXmlElement instance from which to extract the enumeration value. Can be null.</param>
  /// <param name="modelType">The target enumeration type to which the value should be converted. Must be a valid enum type.</param>
  /// <returns>An Enum value corresponding to the value of the OpenXmlElement, or null if openXmlElement is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the OpenXmlElement does not contain a 'Value' or 'Val' property, or if the property value is null.</exception>
  public static Enum? GetEnumValue(DX.OpenXmlElement? openXmlElement, Type modelType)
  {
    if (openXmlElement == null) return null;

    var openXmlType = openXmlElement.GetType();
    var enumValueProperty = openXmlType.GetProperty("Value") ?? openXmlType.GetProperty("Val");
    if (enumValueProperty == null)
      throw new InvalidOperationException($"Cannot find Val/Value/Type property in {openXmlType}");

    var enumValue = enumValueProperty.GetValue(openXmlElement);
    if (enumValue == null)
      throw new InvalidOperationException($"{openXmlElement} has no Value");

    return GetEnumValue(enumValue, modelType);
  }

  #endregion

  #region Generic OpenXml conversion

  /// <summary>
  /// Converts a generic enum value to an Open XML type.
  /// </summary>
  /// <param name="enumVal">The enum value to convert.</param>
  /// <param name="openXmlType">The target Open XML type.</param>
  /// <returns>The converted Open XML type or value, or null if the conversion failed.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the conversion is not supported.</exception>
  public static object? ConvertToOpenXml(Enum? enumVal, Type openXmlType)
  {

    if (openXmlType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
      return ConvertTo(enumVal, openXmlType);

    if (openXmlType.Name.StartsWith("EnumValue`"))
      return CreateOpenXmlEnumValue(enumVal, openXmlType);

    throw new InvalidOperationException($"Cannot convert {enumVal} of type {enumVal?.GetType()} to Open XML type {openXmlType}");
  }

  /// <summary>
  /// Converts an Open XML value to its corresponding enumeration value of the specified model type.
  /// </summary>
  /// <remarks>This method supports conversion from common Open XML enum representation to model enum type. The
  /// caller should ensure Ithat the model type is an enumeration and Ithat the Open XML value is compatible with the
  /// expected type.</remarks>
  /// <param name="openXmlValue">The Open XML value to convert. This can be an OpenXmlLeafElement, an EnumValue, or another supported Open XML
  /// representation. Can be null.</param>
  /// <param name="modelType">The target enumeration type to convert to. Must be a valid enum type.</param>
  /// <returns>An enumeration value of the specified model type Ithat corresponds to the provided Open XML value, or null if the
  /// input value is null.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the provided value cannot be converted to the specified model type.</exception>
  public static Enum? ConvertFromOpenXml(object? openXmlValue, Type modelType)
  {
    if (openXmlValue == null) return null;

    var openXmlType = openXmlValue.GetType();

    if (openXmlType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
      return EnumTypeConverter.GetEnumValue((DX.OpenXmlLeafElement)openXmlValue, modelType);

    if (openXmlType.Name.StartsWith("EnumValue`"))
      return EnumTypeConverter.GetEnumValue(openXmlValue, modelType);


    throw new InvalidOperationException($"Cannot convert {openXmlValue} of type {openXmlType} to model type {modelType.FullName}");
  }

  #endregion
}
