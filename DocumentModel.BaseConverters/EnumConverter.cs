namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Enum value to/from Open XML.
/// </summary>
public static class EnumConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.EnumValue<>), nameof(ConvertFromEnumValue), nameof(ConvertToEnumValue)),
    new(typeof(ValueType), nameof(ConvertFromIEnumValue), nameof(ConvertToIEnumValue)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="EnumConverter"/>.
  /// </summary>
  static EnumConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(EnumConverter), typeof(Enum), supportedConversions, ConversionToMap,
      ConversionFromMap);
  }

  /// <summary>
  /// Maps enum types to their name-value bidirectional dictionaries.
  /// The key is the model enum Type, and the value is a BiDiDictionary mapping model enum values to openXmlEnumValues objects.
  /// </summary>
  private static readonly Dictionary<Type, BiDiDictionary<object, object>> mappingEnumValues = new();

  /// <summary>
  /// Creates a mapping between model enum values and OpenXml enum values.
  /// </summary>
  /// <param name="modelEnumType">The model enum type.</param>
  /// <param name="openXmlEnumValuesType">The OpenXml enum values type.</param>
  /// <returns>Mapping between model enum values and OpenXml enum values.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  private static BiDiDictionary<object, object> GetEnumValuesMap(Type modelEnumType, Type openXmlEnumValuesType)
  {
    var openXmlEnumProperties = openXmlEnumValuesType.GetProperties(BindingFlags.Public | BindingFlags.Static)
      .ToDictionary(prop => prop.Name, prop => prop);
    if (openXmlEnumProperties.Count == 0)
      throw new InvalidOperationException($"Public static properties of type {openXmlEnumValuesType} not found.");

    var modelEnumFields = modelEnumType.GetFields(BindingFlags.Public | BindingFlags.Static);
    if (modelEnumFields.Length == 0)
      throw new InvalidOperationException($"Public static fields of type {modelEnumType} not found.");

    if (!mappingEnumValues.TryGetValue(modelEnumType, out var enumValuesMap))
    {
      enumValuesMap = new BiDiDictionary<object, object>();
      foreach (var modelEnumField in modelEnumFields)
      {
        string mappedName = modelEnumField.GetCustomAttribute<OpenXmlEnumValueAttribute>()?.EnumValueName ??
                            modelEnumField.GetCustomAttribute<OpenXmlPropertyAttribute>()?.PropertyName ??
                            modelEnumField.Name;
        if (!openXmlEnumProperties.TryGetValue(mappedName, out var openXmlProperty))
          throw new InvalidOperationException(
            $"Enum value '{mappedName}' not found in Enum type '{openXmlEnumValuesType.Name}'.");

        var modelEnumValue = modelEnumField.GetValue(null)!;
        var openXmlEnumValue = openXmlProperty.GetValue(null)!;
        enumValuesMap.Add(modelEnumValue, openXmlEnumValue);
      }
      mappingEnumValues[modelEnumType] = enumValuesMap;
    }
    return enumValuesMap;
  }

  #region EnumValue<> conversion.

  /// <summary>
  /// Converts an OpenXml EnumValue to Enum.
  /// </summary>
  /// <param name="openXmlEnumValue">The openXmlEnumValue to convert.</param>
  /// <param name="modelEnumType">The target model type for the conversion. It must be an enum type</param>
  /// <returns>The Enum value, or null if the element has no content.</returns>
  private static Enum? ConvertFromEnumValue(DX.OpenXmlSimpleType? openXmlEnumValue, Type modelEnumType)
  {
    if (openXmlEnumValue == null) return null;

    if (!modelEnumType.IsEnum)
      throw new InvalidOperationException($"Target model type {modelEnumType.Name} is not an enum.");

    var openXmlType = openXmlEnumValue.GetType();
    if (!openXmlType.Name.StartsWith("EnumValue`"))
      throw new InvalidOperationException($"{openXmlType.Name} is not OpenXml EnumValue<> type .");

    var valProp = openXmlType.GetProperty("Value");
    if (valProp == null)
      throw new InvalidOperationException($"EnumValue of type {openXmlType} does not have a Value property");

    var valObject = valProp.GetValue(openXmlEnumValue)!;
    var openXmlEnumValuesObject = valProp.GetValue(openXmlEnumValue);
    if (openXmlEnumValuesObject == null)
      return null;

    var openXmlEnumValuesType = openXmlEnumValuesObject.GetType();
    var enumValuesMap = GetEnumValuesMap(modelEnumType, openXmlEnumValuesType);
    var enumValue = enumValuesMap.GetValue1(valObject);
    return (Enum)enumValue;
  }

  /// <summary>
  /// Creates an OpenXml EnumValue from an Enum value.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type for the created EnumValue instance. Must be of OpenXml EnumValue type.</param>
  /// <returns>A new EnumValue, or null if the input is null.</returns>
  private static DX.OpenXmlSimpleType? ConvertToEnumValue(Enum? value, Type openXmlType)
  {
    if (value == null) return null;

    if (!openXmlType.Name.StartsWith("EnumValue`"))
      throw new InvalidOperationException($"Invalid EnumValue type {openXmlType.Name}.");

    var openXmlEnumValuesType = openXmlType.GenericTypeArguments.FirstOrDefault();
    if (openXmlEnumValuesType == null)
      throw new InvalidOperationException($"EnumValue type {openXmlType.Name} does not have a generic argument.");

    var modelEnumType = value.GetType()!;
    var enumValuesMap = GetEnumValuesMap(modelEnumType, openXmlEnumValuesType);
    var openXmlEnumValuesObject = enumValuesMap.GetValue2(value);
    var result = (DX.OpenXmlSimpleType)Activator.CreateInstance(openXmlType)!;
    var valProp = openXmlType.GetProperty("Value");
    if (valProp == null)
      throw new InvalidOperationException($"EnumValue of type {openXmlType} does not have a Value property");

    valProp.SetValue(result, openXmlEnumValuesObject);
    return result;
  }

  #endregion

  #region IEnumValue conversion.

  /// <summary>
  /// Converts an OpenXml IEnumValue to Enum.
  /// </summary>
  /// <param name="openXmlValue">The openXmlValue to convert.</param>
  /// <param name="modelEnumType">The target model type for the conversion. It must be an enum type</param>
  /// <returns>The Enum value, or null if the element has no content.</returns>
  private static Enum? ConvertFromIEnumValue(DX.IEnumValue? openXmlValue, Type modelEnumType)
  {
    if (openXmlValue == null) return null;

    if (!modelEnumType.IsEnum)
      throw new InvalidOperationException($"Target model type {modelEnumType.Name} is not an enum.");

    var openXmlType = openXmlValue.GetType();

    var IEnumValuesMap = GetEnumValuesMap(modelEnumType, openXmlType);
    var IEnumValue = IEnumValuesMap.GetValue1(openXmlValue);
    return (Enum)IEnumValue;
  }

  /// <summary>
  /// Creates an OpenXml IEnumValue from an Enum value.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type for the created IEnumValue instance. Must be of OpenXml IEnumValue type.</param>
  /// <returns>A new IEnumValue, or null if the input is null.</returns>
  private static DX.IEnumValue? ConvertToIEnumValue(Enum? value, Type openXmlType)
  {
    if (value == null) return null;

    if (openXmlType.GetInterface("IEnumValue") == null)
      throw new InvalidOperationException($"Invalid IEnumValue type {openXmlType.Name}.");

    var modelEnumType = value.GetType()!;
    var IEnumValuesMap = GetEnumValuesMap(modelEnumType, openXmlType);
    var result = (DX.IEnumValue)IEnumValuesMap.GetValue2(value);
    return result;
  }

  #endregion

  #region String conversion.

  /// <summary>
  /// Converts an OpenXml String to Enum.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="modelEnumType">The target model type for the conversion. It must be an enum type</param>
  /// <returns>The Enum value, or null if the element has no content.</returns>
  private static Enum? ConvertFromString(String? value, Type modelEnumType)
  {
    if (value == null) return null;

    if (!modelEnumType.IsEnum)
      throw new InvalidOperationException($"Target model type {modelEnumType.Name} is not an enum.");

    if (int.TryParse(value, out var intValue))
    {
      var enumValue = Enum.ToObject(modelEnumType, intValue);
      return (Enum)enumValue;
    }

    return (Enum?)Enum.Parse(modelEnumType, value)!;
  }

  /// <summary>
  /// Creates an OpenXml String from an Enum value.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type for the created String instance. Must be of OpenXml String type.</param>
  /// <returns>A new String, or null if the input is null.</returns>
  private static String? ConvertToString(Enum? value, Type openXmlType)
  {
    if (value == null) return null;

    if (openXmlType.GetInterface("String") == null)
      throw new InvalidOperationException($"Invalid String type {openXmlType.Name}.");

    var modelEnumType = value.GetType()!;
    var StringsMap = GetEnumValuesMap(modelEnumType, openXmlType);
    var result = (String)StringsMap.GetValue2(value);
    return result;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to Enum.
  /// </summary>
  /// <param name="openXmlValue">The openXmlValue to convert.</param>
  /// <param name="modelEnumType">The target model type for the conversion. It must be an enum type</param>
  /// <returns>The Enum value, or null if the element has no content.</returns>
  private static Enum? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? openXmlValue, Type modelEnumType)
  {
    if (openXmlValue == null) return null;

    if (!modelEnumType.IsEnum)
      throw new InvalidOperationException($"Target model type {modelEnumType.Name} is not an enum.");

    var valText = openXmlValue.Text;
    if (string.IsNullOrEmpty(valText))
      return null;
    var intVal = Convert.ToInt32(valText);
    var enumValue = Enum.ToObject(modelEnumType, intVal);
    return (Enum)enumValue;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement from an Enum value.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type for the created EnumValue instance. Must be of OpenXml EnumValue type.</param>
  /// <returns>A new EnumValue, or null if the input is null.</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(Enum? value, Type openXmlType)
  {
    if (value == null) return null;

    var result = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(openXmlType)!;
    var intValue = Convert.ToInt32(value);
    result.Text = intValue.ToString();
    return result;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement to Enum.
  /// </summary>
  /// <param name="openXmlValue">The openXmlValue to convert.</param>
  /// <param name="modelEnumType">The target model type for the conversion. It must be an enum type</param>
  /// <returns>The Enum value, or null if the element has no content.</returns>
  private static Enum? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? openXmlValue, Type modelEnumType)
  {
    if (openXmlValue == null) return null;

    if (!modelEnumType.IsEnum)
      throw new InvalidOperationException($"Target model type {modelEnumType.Name} is not an enum.");

    var openXmlType = openXmlValue.GetType();
    var valProp = openXmlType.GetProperty("Value") ?? openXmlType.GetProperty("Val");
    if (valProp == null)
      throw new InvalidOperationException($"EnumValue of type {openXmlType} does not have a Value property");

    var valObject = valProp.GetValue(openXmlValue);
    if (valObject == null)
      return null;

    openXmlType = valObject.GetType()!;
    valProp = openXmlType.GetProperty("Value");
    if (valProp == null)
      throw new InvalidOperationException($"EnumValue of type {openXmlType} does not have a Value property");

    valObject = valProp.GetValue(valObject);
    if (valObject == null)
      return null;

    return ConvertFrom(valObject, modelEnumType);
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement from an Enum value.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type for the created EnumValue instance. Must be of OpenXml EnumValue type.</param>
  /// <returns>A new EnumValue, or null if the input is null.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Enum? value, Type openXmlType)
  {
    if (value == null) return null;

    var result = (DX.OpenXmlLeafElement)Activator.CreateInstance(openXmlType)!;
    var valProp = openXmlType.GetProperty("Value") ?? openXmlType.GetProperty("Val");
    if (valProp == null)
      throw new InvalidOperationException($"EnumValue of type {openXmlType} does not have a Value property");

    var openXmlValType = valProp.PropertyType;
    var targetInstance = Activator.CreateInstance(openXmlValType)!;
    var targetInstanceType = targetInstance.GetType();
    var valueProp = targetInstanceType.GetProperty("Value") ?? targetInstanceType.GetProperty("Val");
    if (valueProp == null)
      throw new InvalidOperationException($"EnumValue of type {targetInstanceType} does not have a Value property");

    if (valueProp.PropertyType.Name == "CharacterSpacingValues") Debug.Assert(true);
    var targetValue = (valueProp.PropertyType.GetInterface("IEnumValue") != null)?
      EnumConverter.ConvertToIEnumValue(value, valueProp.PropertyType) : 
      Int32Converter.ConvertTo(Convert.ToInt32(value), valueProp.PropertyType);
    valueProp.SetValue(targetInstance, targetValue);
    valProp.SetValue(result, targetInstance);
    return result;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an Enum value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(Enum? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value to a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value to convert to an <see cref="Enum"/>. Can be <see langword="null"/>.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> to <see cref="Enum"/> is not supported.</exception>
  public static Enum? ConvertFrom(object? value, Type targetType)
  {
    return (Enum?)ConverterBase.ConvertFrom(value, targetType, ConversionFromMap);
  }

  #endregion
}