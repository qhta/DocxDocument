namespace DocumentModel.OpenXml;

/// <summary>
/// Single conversion method information.
/// </summary>
/// <param name="TargetType"></param>
/// <param name="ConvertFromMethod"></param>
/// <param name="ConvertToMethod"></param>
public record ConversionMethodInfo(Type TargetType, string ConvertFromMethod, string ConvertToMethod);

/// <summary>
/// Represents a collection of conversion functions that map a source type to a target type, enabling dynamic type
/// conversions at runtime.
/// </summary>
/// <remarks>This class extends the generic IDictionary, using a tuple of source and target types as the key and a
/// delegate that performs the conversion as the value. It is useful for scenarios where type conversions need to be
/// registered and resolved dynamically, such as in serialization frameworks or custom mapping utilities. The Append
/// method allows merging conversion mappings from another ConversionToMap instance, facilitating
/// extensibility.</remarks>
public class ConversionToMap : Dictionary<(Type ISource, Type Target), Func<object, Type, object?>>
{
  /// <summary>
  /// Appends map from other source.
  /// </summary>
  /// <param name="source"></param>
  public void Append(ConversionToMap source)
  {
    foreach (var item in source)
    {
      this[(item.Key.ISource, item.Key.Target)] = item.Value;
    }
  }
}

/// <summary>
/// Represents a collection of type conversion functions that map source types to target types, enabling dynamic
/// conversion between types at runtime.
/// </summary>
/// <remarks>This class extends the generic IDictionary, using a tuple of source and target types as the key and a
/// conversion function as the value. It is useful for scenarios where type conversions need to be registered and
/// retrieved dynamically, such as in serialization frameworks or custom type mappers. The Append method allows merging
/// conversion mappings from another ConversionFromMap instance, overwriting existing mappings for the same type
/// pairs.</remarks>
public class ConversionFromMap : Dictionary<(Type ISource, Type Target), Func<object, Type, object?>>
{
  /// <summary>
  /// Appends map from other source.
  /// </summary>
  /// <param name="source"></param>
  public void Append(ConversionFromMap source)
  {
    foreach (var item in source)
    {
      this[(item.Key.ISource, item.Key.Target)] = item.Value;
    }
  }
}

/// <summary>
/// Represents base functionality for specific converters.
/// </summary>
public static class ConverterBase
{

  /// <summary>
  /// Retrieves the public instance property named "Val" from the specified type, or returns the single declared public
  /// instance property if only one exists.
  /// </summary>
  /// <remarks>If the specified type does not declare a property named "Val", and declares exactly one public
  /// instance property, that property is returned. If there are no public instance properties or more than one (other
  /// than "Val"), the method returns <see langword="null"/>.</remarks>
  /// <param name="type">The type to search for a public instance property named "Val" or a single declared public instance property.</param>
  /// <returns>A <see cref="PropertyInfo"/> representing the "Val" property, or the single declared public instance property if
  /// only one exists; otherwise, <see langword="null"/>.</returns>
  public static PropertyInfo? GetValProperty(this Type type)
  {
    var allProps = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
    if (allProps.Length == 1)
      return allProps[0];
    if (type == typeof(DX.OpenXmlElement))
      return null;
    var baseType = type.BaseType;
    if (baseType != null)
      return baseType.GetValProperty();
    return null;
  }

  private static readonly object syncObject = new object();
  /// <summary>
  /// Registers conversion methods for the specified model type using the provided converter type and supported
  /// conversions.
  /// </summary>
  /// <remarks>This method locates and registers static conversion methods defined on the specified converter
  /// type, updating the provided conversion maps to enable type conversions for the model type. If a specified
  /// conversion method is not found, it is skipped. If a conversion method throws an exception, the original exception
  /// is propagated.</remarks>
  /// <param name="converterType">The type that contains the static conversion methods to be registered.</param>
  /// <param name="modelType">The model type for which conversion methods are being registered.</param>
  /// <param name="supportedConversions">An array of supported conversion method information, specifying the target types and corresponding method names.</param>
  /// <param name="conversionToMap">A dictionary that maps a pair of source and target types to a delegate used for converting from the model type to
  /// the target type. This dictionary will be updated with the registered conversion methods.</param>
  /// <param name="conversionFromMap">A dictionary that maps a pair of target and source types to a delegate used for converting from the target type to
  /// the model type. This dictionary will be updated with the registered conversion methods.</param>
  public static void RegisterConversionMethods
  (Type converterType, Type modelType, ConversionMethodInfo[] supportedConversions, ConversionToMap conversionToMap,
    ConversionFromMap conversionFromMap)
  {
    lock (syncObject)
    {
      foreach (var item in supportedConversions)
      {
        var fromMethod = converterType.GetMethod(item.ConvertFromMethod,
          BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        var toMethod = converterType.GetMethod(item.ConvertToMethod,
          BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        try
        {
          if (fromMethod != null)
          {
            conversionFromMap[(item.TargetType, modelType)] = (value, targetType) =>
            {
              var parameters = fromMethod.GetParameters();
              if (parameters.Length == 1)
                return fromMethod.Invoke(null, [value])!;

              Debug.Assert(parameters.Length == 2);
              return fromMethod.Invoke(null, [value, targetType])!;
            };
          }
          if (toMethod != null)
          {
            conversionToMap[(modelType, item.TargetType)] = (value, targetType) =>
            {
              var parameters = toMethod.GetParameters();
              if (parameters.Length == 1)
                return toMethod.Invoke(null, [value])!;

              Debug.Assert(parameters.Length == 2);
              return toMethod.Invoke(null, [value, targetType])!;
            };
          }
        }
        catch (TargetInvocationException ex)
        {
          if (ex.InnerException != null)
            throw ex.InnerException;

          throw;
        }
      }
    }
  }

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="conversionToMap">Conversion map for forward conversions.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Thrown when the conversion is not supported.</exception>
  public static object? ConvertTo(object? value, Type targetType, ConversionToMap conversionToMap)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (TryConvertTo(value, targetType, conversionToMap, out var result))
      return result;

    throw new NotSupportedException(
      $"Conversion from {sourceType.FullName} to {targetType.FullName} is not supported.");
  }

  /// <summary>
  /// Attempts to convert the specified value to the given target type using the provided conversion map.
  /// </summary>
  /// <remarks>If the value is null, the method returns true and sets the result to null. The method first
  /// attempts to use the provided conversion map for custom conversions, then falls back to implicit conversions or
  /// specific handling for OpenXml types. If no suitable conversion is found, the method returns false and the result
  /// is undefined.</remarks>
  /// <param name="value">The value to convert. Can be null.</param>
  /// <param name="targetType">The type to which the value should be converted. Cannot be null.</param>
  /// <param name="conversionToMap">A map of source and target type pairs to conversion functions used to perform custom conversions.</param>
  /// <param name="result">When this method returns, contains the converted value if the conversion succeeded, or the original value if it
  /// was null or no conversion was necessary. This parameter is passed uninitialized.</param>
  /// <returns>true if the value was successfully converted to the target type or was already of the target type; otherwise, false.</returns>
  public static bool TryConvertTo(object? value, Type targetType, ConversionToMap conversionToMap, out object? result)
  {
    result = value;
    if (value == null) return true;

    var sourceType = value.GetType();
    if (sourceType == targetType)
      return true;

    var sourceSearchType = sourceType;
    if (sourceType.IsEnum)
      sourceSearchType = typeof(Enum);

    var targetSubType = Nullable.GetUnderlyingType(targetType) ?? targetType;
    if (targetSubType.Name.StartsWith("EnumValue`"))
    {
      targetSubType = typeof(DX.EnumValue<>);
    }
    while (targetSubType != null)
    {
      if (conversionToMap.TryGetValue((sourceSearchType, targetSubType), out var conversionFunc) ||
          (sourceSearchType != sourceType) &&
          conversionToMap.TryGetValue((sourceType, targetSubType), out conversionFunc))
      {
        result = conversionFunc(value, targetType);
        return true;
      }
      targetSubType = targetSubType.BaseType;
    }
    if (TryImplicitConvertTo(value, targetType, out result))
      return true;

    if (targetType.IsSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
    {
      var targetInstance = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
      targetInstance.Text = value.ToString()!;
      result = targetInstance;
      return true;
    }
    if (targetType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProp = targetType.GetValProperty();
      if (valProp != null)
        if (TryConvertTo(value, valProp.PropertyType, conversionToMap, out object? valValue))
        {
          var targetInstance = Activator.CreateInstance(targetType);
          valProp.SetValue(targetInstance, valValue);
          result = targetInstance;
          return true;
        }
    }
    if (targetType.IsEqualOrSubclassOf(typeof(DX.StringValue)))
    {
      var targetInstance = (DX.StringValue)Activator.CreateInstance(targetType)!;
      targetInstance.Value = value.ToString()!;
      result = targetInstance;
      return true;
    }
    if (TryUseIConvertibleInterface(value, targetType, out result))
      return true;

    return false;
  }

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="conversionFromMap">Conversion map for reverse conversions.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if a required conversion is not supported or if a necessary property for conversion cannot be found on the
  /// source type.</exception>
  public static object? ConvertFrom(object? value, Type targetType, ConversionFromMap conversionFromMap)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (TryConvertFrom(value, targetType, conversionFromMap, out var result))
      return result;

    if (TryConvertFrom(value, targetType, conversionFromMap, out result))
      return result;

    throw new NotSupportedException(
      $"Conversion from {sourceType.FullName} to {targetType.FullName} is not supported.");
  }

  /// <summary>
  /// Attempts to convert the specified value to the given target type using the provided conversion map.
  /// </summary>
  /// <remarks>If the value is null or already of the target type, no conversion is performed. The method uses
  /// the provided conversion map and built-in conversion logic to attempt the conversion. If the conversion cannot be
  /// performed, a NotSupportedException is thrown.</remarks>
  /// <param name="value">The value to convert. May be null.</param>
  /// <param name="targetType">The type to which the value should be converted. Cannot be null.</param>
  /// <param name="conversionFromMap">A map that defines custom conversion functions from source types to target types. Cannot be null.</param>
  /// <param name="result">When this method returns, contains the converted value if the conversion succeeded, or the original value if no
  /// conversion was necessary. This parameter is passed uninitialized.</param>
  /// <returns>true if the conversion was successful or not required; otherwise, false.</returns>
  public static bool TryConvertFrom
    (object? value, Type targetType, ConversionFromMap conversionFromMap, out object? result)
  {
    result = value;
    if (value == null) return true;

    targetType = targetType.GetNotNullableType();
    var sourceType = value.GetType();
    sourceType = sourceType.GetNotNullableType();
    if (sourceType == targetType)
      return true;

    var targetSearchType = targetType;
    if (targetType.IsEnum)
      targetSearchType = typeof(Enum);
    var sourceSubType = Nullable.GetUnderlyingType(sourceType) ?? sourceType;
    if (sourceSubType.Name.StartsWith("EnumValue`"))
    {
      sourceSubType = typeof(DX.EnumValue<>);
    }
    while (sourceSubType != null)
    {
      if (conversionFromMap.TryGetValue((sourceSubType, targetSearchType), out var conversionFunc) ||
          (targetSearchType != targetType) &&
          conversionFromMap.TryGetValue((sourceSubType, targetType), out conversionFunc))
      {
        try
        {
          result = conversionFunc(value, targetType);
          return true;
        }
        catch
        {
          break;
        }


      }
      sourceSubType = sourceSubType.BaseType;
    }
    if (TryImplicitConvertFrom(value, targetType, out result))
      return true;

    if (value is DX.OpenXmlLeafTextElement textElement)
    {
      var valValue = textElement.Text;
      if (TryConvertFrom(valValue, targetType, conversionFromMap, out result))
        return true;
    }
    if (sourceType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProp = sourceType.GetValProperty();
      if (valProp != null)
      {
        var valValue = valProp.GetValue(value);
        if (valValue != null && TryConvertFrom(valValue, targetType, conversionFromMap, out result))
          return true;
      }
    }
    if (sourceType.IsEqualOrSubclassOf(typeof(DX.StringValue)))
    {
      var valProp = sourceType.GetValProperty();
      if (valProp == null)
        throw new NotSupportedException($"Val property in {sourceType.FullName} not found.");

      var valValue = valProp.GetValue(value);
      if (TryConvertFrom(valValue, targetType, conversionFromMap, out result))
        return true;
    }
    if (TryUseIConvertibleInterface(value, targetType, out result))
      return true;

    return false;
  }

  /// <summary>
  /// Attempts to convert a value to the specified target type using an implicit conversion operator, if available.
  /// </summary>
  /// <param name="source">The source value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="result">The converted value if the conversion succeeds; otherwise, null.</param>
  /// <returns>True if an implicit conversion was performed; otherwise, false.</returns>
  public static bool TryImplicitConvertTo(object? source, Type targetType, out object? result)
  {
    result = null;
    if (source == null) return true;

    var sourceType = source.GetType();
    if (targetType == sourceType)
    {
      result = source;
      return true;
    }
    var methods = sourceType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Concat(targetType.GetMethods(BindingFlags.Public | BindingFlags.Static)).ToArray();
    var op = methods.FirstOrDefault(m =>
    {
      var parameters = m.GetParameters();
      return m.Name == "op_Implicit" && m.ReturnType == targetType && parameters.Length == 1 &&
             parameters[0].ParameterType.IsAssignableFrom(sourceType);
    });
    if (op != null)
    {
      result = op.Invoke(null, [source]);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Attempts to convert a value from the specified target type using an implicit conversion operator, if available.
  /// </summary>
  /// <param name="source">The source value to convert.</param>
  /// <param name="targetType">The type to convert the value From.</param>
  /// <param name="result">The converted value if the conversion succeeds; otherwise, null.</param>
  /// <returns>True if an implicit conversion was performed; otherwise, false.</returns>
  public static bool TryImplicitConvertFrom(object? source, Type targetType, out object? result)
  {
    result = null;
    if (source == null) return true;

    var sourceType = source.GetType();
    if (targetType == sourceType)
    {
      result = source;
      return true;
    }
    var methods = sourceType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Concat(targetType.GetMethods(BindingFlags.Public | BindingFlags.Static)).ToArray();
    var op = methods.FirstOrDefault(m =>
    {
      var parameters = m.GetParameters();
      return m.Name == "op_Implicit" && m.ReturnType == targetType && parameters.Length == 1 &&
             parameters[0].ParameterType.IsAssignableFrom(sourceType);
    });
    if (op != null)
    {
      result = op.Invoke(null, [source]);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Attempts to use IConvertible to convert the source object to the target type.
  /// </summary>
  /// <param name="source">ISource object to convert.</param>
  /// <param name="targetType">Target type to convert.</param>
  /// <param name="result">Converted result.</param>
  /// <returns></returns>
  public static bool TryUseIConvertibleInterface(object? source, Type targetType, out object? result)
  {
    if (source is IConvertible convertible && targetType.GetInterface("IConvertible") != null)
    {
      try
      {
        result = convertible.ToType(targetType, null);
        return true;
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex);
      }
    }
    result = null;
    return false;
  }
}
