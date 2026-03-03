namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Enum value to/from Open XML.
/// </summary>
public static partial class EnumConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(ValueType), nameof(ConvertFromValueType), nameof(ConvertToValueType)),
    new(typeof(DX.EnumValue<>), nameof(ConvertFromEnumValue), nameof(ConvertToEnumValue)),
    new(typeof(DX.IEnumValue), nameof(ConvertFromIEnumValue), nameof(ConvertToIEnumValue)),
    new(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
  ];

  private static readonly ConversionMethodInfo[] stringConversions =
  [
    new(typeof(DX.EnumValue<>), nameof(ConvertFromOpenXmlEnumValueToString), nameof(ConvertToOpenXmlEnumValueFromString)),
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
    ConverterBase.RegisterConversionMethods(typeof(EnumConverter), typeof(String), stringConversions, ConversionToMap,
      ConversionFromMap);
  }

  /// <summary>
  /// Maps enum types to their name-value bidirectional dictionaries.
  /// The key is the model enum Type, and the value is a BiDiDictionary mapping model enum values to openXmlEnumValues objects.
  /// </summary>
  private static readonly Dictionary<Type, BiDiDictionary<object, object>> mappingEnumValues = new();


  /// <summary>
  /// Creates a mapping between model enum values and target type values.
  /// Target type can be either OpenXml EnumValues type, OpenXml EnumValue&lt;&gt; type, or String type,
  /// and the mapping is created based on the attributes on the model enum fields and the structure of the target type.
  /// </summary>
  /// <param name="modelEnumType">The model enum type.</param>
  /// <param name="targetType">The target type.</param>
  /// <returns>Mapping between model enum values and OpenXml enum values.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  private static BiDiDictionary<object, object> GetEnumValuesMap(Type modelEnumType, Type targetType)
  {
    if (modelEnumType == typeof(string))
      return GetOpenXmlEnumValuesMapToString(targetType);
    if (targetType == typeof(String))
      return GetEnumValuesMapToStringType(modelEnumType);
    if (targetType.Name.StartsWith("EnumValue`"))
      return GetEnumValuesMapToEnumValuesType(modelEnumType, targetType);
    if (targetType.GetInterface("IEnumValue") != null)
      return GetEnumValuesMapToEnumValuesType(modelEnumType, targetType);
    throw new InvalidOperationException($"Unsupported target type {targetType.Name} for enum mapping.");
  }


  /// <summary>
  /// Creates a mapping between model enum values and OpenXml enum values.
  /// </summary>
  /// <param name="modelEnumType">The model enum type.</param>
  /// <returns>Mapping between model enum values and OpenXml enum values.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  private static BiDiDictionary<object, object> GetEnumValuesMapToStringType(Type modelEnumType)
  {

    var modelEnumFields = modelEnumType.GetFields(BindingFlags.Public | BindingFlags.Static);
    if (modelEnumFields.Length == 0)
      throw new InvalidOperationException($"Public static fields of type {modelEnumType} not found.");

    if (!mappingEnumValues.TryGetValue(modelEnumType, out var enumValuesMap))
    {
      enumValuesMap = new BiDiDictionary<object, object>();
      foreach (var modelEnumField in modelEnumFields)
      {
        var modelEnumValue = modelEnumField.GetValue(null)!;
        string mappedName = modelEnumField.GetCustomAttribute<OpenXmlEnumValueAttribute>()?.EnumValueName ??
                            modelEnumField.Name;
        enumValuesMap.Add(modelEnumValue, mappedName);
      }
      if (modelEnumType.GetCustomAttribute<FlagsAttribute>() != null)
      {
        var existingValues = new HashSet<long>(modelEnumFields
          .Select(value => Convert.ToInt64(value.GetValue(null))));
        var flagValues = modelEnumFields
          .Select(value => Convert.ToInt64(value.GetValue(null)))
          .Where(value => value != 0)
          .Distinct()
          .ToArray();

        if (flagValues.Length < 63)
        {
          var combinationCount = 1L << flagValues.Length;
          for (var mask = 1L; mask < combinationCount; mask++)
          {
            long combinedValue = 0;
            for (var index = 0; index < flagValues.Length; index++)
            {
              if ((mask & (1L << index)) != 0)
                combinedValue |= flagValues[index];
            }

            if (combinedValue == 0 || !existingValues.Add(combinedValue))
              continue;

            var combinedEnum = Enum.ToObject(modelEnumType, combinedValue);
            enumValuesMap.Add(combinedEnum, combinedEnum.ToString()!);
          }
        }
        else
        {
          long combinedValue = 0;
          foreach (var value in flagValues)
            combinedValue |= value;

          if (combinedValue != 0 && existingValues.Add(combinedValue))
          {
            var combinedEnum = Enum.ToObject(modelEnumType, combinedValue);
            enumValuesMap.Add(combinedEnum, combinedEnum.ToString()!);
          }
        }
      }
      mappingEnumValues[modelEnumType] = enumValuesMap;
    }

    return enumValuesMap;
  }


  /// <summary>
  /// Creates a mapping between OpenXml enum values and strings .
  /// </summary>
  /// <param name="openXmlEnumValuesType">The OpenXml enum values type.</param>
  /// <returns>Mapping between OpenXml enum values and strings.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  private static BiDiDictionary<object, object> GetOpenXmlEnumValuesMapToString(Type openXmlEnumValuesType)
  {

    var openXmlEnumValuesProps = openXmlEnumValuesType.GetProperties(BindingFlags.Public | BindingFlags.Static);
    if (openXmlEnumValuesProps.Length == 0)
      throw new InvalidOperationException($"Public static properties of type {openXmlEnumValuesType} not found.");

    if (!mappingEnumValues.TryGetValue(openXmlEnumValuesType, out var enumValuesMap))
    {
      enumValuesMap = new BiDiDictionary<object, object>();
      foreach (var openXmlEnumValuesProp in openXmlEnumValuesProps)
      {
        var openXmlEnumValue = openXmlEnumValuesProp.GetValue(null)!;
        string mappedName = openXmlEnumValuesProp.Name;
        enumValuesMap.Add(openXmlEnumValue, mappedName);
      }
      mappingEnumValues[openXmlEnumValuesType] = enumValuesMap;
    }
    return enumValuesMap;
  }

  /// <summary>
  /// Creates a mapping between model enum values and OpenXml enum values.
  /// </summary>
  /// <param name="modelEnumType">The model enum type.</param>
  /// <param name="openXmlEnumValuesType">The OpenXml enum values type.</param>
  /// <returns>Mapping between model enum values and OpenXml enum values.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  private static BiDiDictionary<object, object> GetEnumValuesMapToEnumValuesType(Type modelEnumType, Type openXmlEnumValuesType)
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

    var enumValuesMap = GetEnumValuesMap(modelEnumType, openXmlType);
    var enumValue = enumValuesMap.GetValue1(openXmlValue);
    return (Enum)enumValue;
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
    var enumValuesMap = GetEnumValuesMap(modelEnumType, openXmlType);
    var result = (DX.IEnumValue)enumValuesMap.GetValue2(value);
    return result;
  }

  #endregion


  #region ValueType conversion.

  /// <summary>
  /// Converts ValueType value to Enum.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="modelEnumType">The target model type for the conversion. It must be an enum type</param>
  /// <returns>The Enum value, or null if the element has no content.</returns>
  public static Enum? ConvertFromValueType(ValueType? value, Type modelEnumType)
  {
    if (value == null) return null;

    if (value is DX.IEnumValue iEnumValue)
      return ConvertFromIEnumValue(iEnumValue, modelEnumType);

    var enumValue = Enum.ToObject(modelEnumType, value);
    return (Enum)enumValue;

  }

  /// <summary>
  /// Creates a ValueType value from an Enum value.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="valueType">The target ValueType for the conversion.</param>
  /// <returns>A new ValueType, or null if the input is null.</returns>
  public static ValueType? ConvertToValueType(Enum? value, Type valueType)
  {
    if (value == null) return null;

    if (valueType.GetInterface("IEnumValue") != null)
      return (ValueType?)ConvertToIEnumValue(value, valueType);

    var result = Enum.ToObject(valueType, value);
    return (ValueType)result;
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

    var enumValuesMap = GetEnumValuesMap(modelEnumType, typeof(string));
    if (enumValuesMap.TryGetValue1(enumValuesMap, out var result))
      return (Enum)result;

    return (Enum?)Enum.Parse(modelEnumType, value, true)!;
  }

  /// <summary>
  /// Creates an OpenXml String from an Enum value.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <returns>A new String, or null if the input is null.</returns>
  private static String? ConvertToString(Enum? value)
  {
    if (value == null) return null;

    var modelEnumType = value.GetType()!;
    if (modelEnumType.GetCustomAttribute<OpenXmlEnumTypeAttribute>()?.TargetType == typeof(Int32))
    {
      var intValue = Convert.ToInt32(value);
      return intValue.ToString();
    }

    var result = value.ToString();
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
    var textValue = EnumConverter.ConvertToString(value) ?? "";
    result.Text = textValue;
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

    return (Enum?)ConvertFrom(valObject, modelEnumType);
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

    object? targetValue = null;
    if (valueProp.PropertyType.GetInterface("IEnumValue") != null)
      targetValue = EnumConverter.ConvertToIEnumValue(value, valueProp.PropertyType);
    else if (valueProp.PropertyType == typeof(string))
      targetValue = EnumConverter.ConvertToString(value)?.ToLowerInvariant();
    else
      targetValue = Int32Converter.ConvertTo(Convert.ToInt32(value), valueProp.PropertyType);
    valueProp.SetValue(targetInstance, targetValue);
    valProp.SetValue(result, targetInstance);
    return result;
  }

  #endregion


  #region EnumValue<> conversion.

  /// <summary>
  /// Converts an OpenXml EnumValue to Enum.
  /// </summary>
  /// <param name="openXmlEnumValue">The openXmlEnumValue to convert.</param>
  /// <returns>The Enum value, or null if the element has no content.</returns>
  public static string? ConvertFromOpenXmlEnumValueToString(DX.OpenXmlSimpleType? openXmlEnumValue)
  {
    if (openXmlEnumValue == null) return null;
    
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
    var enumValuesMap = GetEnumValuesMap(typeof(string), openXmlEnumValuesType);
    var str = enumValuesMap.GetValue2(valObject);
    return (string)str;
  }

  /// <summary>
  /// Creates an OpenXml EnumValue from an Enum value.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type for the created EnumValue instance. Must be of OpenXml EnumValue type.</param>
  /// <returns>A new EnumValue, or null if the input is null.</returns>
  public static DX.OpenXmlSimpleType? ConvertToOpenXmlEnumValueFromString(string? value, Type openXmlType)
  {
    if (value == null) return null;

    if (!openXmlType.Name.StartsWith("EnumValue`"))
      throw new InvalidOperationException($"Invalid EnumValue type {openXmlType.Name}.");

    var openXmlEnumValuesType = openXmlType.GenericTypeArguments.FirstOrDefault();
    if (openXmlEnumValuesType == null)
      throw new InvalidOperationException($"EnumValue type {openXmlType.Name} does not have a generic argument.");

    var modelEnumType = value.GetType()!;
    var enumValuesMap = GetEnumValuesMap(modelEnumType, openXmlEnumValuesType);
    var openXmlEnumValuesObject = enumValuesMap.GetValue1(value);
    var result = (DX.OpenXmlSimpleType)Activator.CreateInstance(openXmlType)!;
    var valProp = openXmlType.GetProperty("Value");
    if (valProp == null)
      throw new InvalidOperationException($"EnumValue of type {openXmlType} does not have a Value property");

    valProp.SetValue(result, openXmlEnumValuesObject);
    return result;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Attempts to convert an Enum value to the specified target type using standard type conversion, returning a boolean to indicate success or failure.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <param name="result">The converted value, or null if the conversion failed.</param>
  /// <returns>True if the conversion was successful; otherwise, false.</returns>
  public static bool TryConvertTo(object? value, Type targetType, out object? result)
  {
    return ConverterBase.TryConvertTo(value, targetType, ConversionToMap, out result);
  }

  /// <summary>
  /// Attempts to convert the specified value to the specified target type.
  /// </summary>
  /// <remarks>This method utilizes a predefined conversion map to determine how to convert the value to the
  /// target type. It is important to ensure that the target type is compatible with the provided value to avoid
  /// conversion failures.</remarks>
  /// <param name="value">The object to convert. This can be null, in which case the conversion will not be performed.</param>
  /// <param name="targetType">The type to which the value should be converted. This must be a valid type that the conversion supports.</param>
  /// <param name="result">When this method returns, contains the converted value if the conversion was successful; otherwise, it will be
  /// null.</param>
  /// <returns>true if the conversion was successful; otherwise, false.</returns>
  public static bool TryConvertFrom(object? value, Type targetType, out object? result)
  {
    try
    {
      return ConverterBase.TryConvertFrom(value, targetType, ConversionFromMap, out result);
    }
    catch
    {
      result = null;
      return false;
    }
  }

  /// <summary>
  /// Converts an Enum value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The Enum value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(object? value, Type targetType)
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
  public static object? ConvertFrom(object? value, Type targetType)
  {
    return ConverterBase.ConvertFrom(value, targetType, ConversionFromMap);
  }

  #endregion
}