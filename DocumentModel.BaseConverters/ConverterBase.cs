namespace DocumentModel.OpenXml;

/// <summary>
/// Single conversion method information.
/// </summary>
/// <param name="TargetType"></param>
/// <param name="ConvertFromMethod"></param>
/// <param name="ConvertToMethod"></param>
public record ConversionMethodInfo(Type TargetType, string ConvertFromMethod, string ConvertToMethod);

public class ConversionToMap : Dictionary<(Type Source, Type Target), Func<object, Type, object?>>
{
  public void Append(ConversionToMap source)
  {
    foreach (var item in source)
    {
      this[(item.Key.Source, item.Key.Target)] = item.Value;
    }
  }
}

public class ConversionFromMap : Dictionary<(Type Source, Type Target), Func<object, object?>>
{
  public void Append(ConversionFromMap source)
  {
    foreach (var item in source)
    {
      this[(item.Key.Source, item.Key.Target)] = item.Value;
    }
  }
}

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
    var valProp = type.GetProperty("Val");
    if (valProp == null)
    {
      var allProps = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
      if (allProps.Length == 1)
        valProp = allProps[0];
      else
        return null;
    }
    return valProp;
  }

  /// <summary>
  /// Determines whether the specified type is supported, either directly or through inheritance, based on the provided
  /// list of supported types.
  /// </summary>
  /// <remarks>This method checks if the given type is a subclass of OpenXmlLeafTextElement or
  /// OpenXmlLeafElement, or if it matches any of the types in the supportedTypes array. For types derived from
  /// OpenXmlLeafElement, the method inspects the 'Val' property or, if absent, the only declared property to determine
  /// support based on its type.</remarks>
  /// <param name="type">The type to evaluate for support. Cannot be null.</param>
  /// <param name="supportedTypes">An array of types that are considered supported. Cannot be null or empty.</param>
  /// <returns>true if the specified type or its relevant property type is supported; otherwise, false.</returns>
  public static bool SupportsType(Type type, Type[] supportedTypes)
  {
    if (type.IsSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
      return true;
    if (type.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProp = type.GetProperty("Val");
      if (valProp == null)
      {
        var allProps = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        if (allProps.Length == 1)
          valProp = allProps[0];
        else
          return false;

      }
      if (SupportsType(valProp.PropertyType, supportedTypes))
        return true;

      return false;
    }

    return supportedTypes.Contains(type);
  }

  public static void RegisterConversionMethods(Type converterType, Type modelType, ConversionMethodInfo[] supportedTypes,
    ConversionToMap conversionToMap, ConversionFromMap conversionFromMap)
  {
    foreach (var item in supportedTypes)
    {
      var fromMethod = converterType.GetMethod(item.ConvertFromMethod, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      var toMethod = converterType.GetMethod(item.ConvertToMethod, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      try
      {
        if (fromMethod != null)
        {
          conversionFromMap[(item.TargetType, modelType)] = value => fromMethod.Invoke(null, [value])!;
        }
        if (toMethod != null)
        {
          conversionToMap[(modelType, item.TargetType)] = (value, targetType) =>
          {
            var parameters = toMethod.GetParameters();
            if (parameters.Length == 1)
              return toMethod.Invoke(null, [value])!;

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

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="conversionToMap">Conversion map for forward conversions.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertTo(object? value, Type targetType, ConversionToMap conversionToMap)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    Debug.WriteLine($"Start converting from {sourceType.FullName} to {targetType.FullName}");

    var targetSubType = Nullable.GetUnderlyingType(targetType) ?? targetType;
    while (targetSubType != null)
    {
      Debug.WriteLine($"Search for conversion from {sourceType.FullName} to {targetSubType.FullName}");

      if (conversionToMap.TryGetValue((sourceType, targetSubType), out var conversionFunc))
      {
        Debug.WriteLine($"Converting from {sourceType.FullName} to {targetSubType.FullName}");
        return conversionFunc(value, targetType);
      }

      targetSubType = targetSubType.BaseType;
    }
    if (TryImplicitConvert(value, targetType, out var result))
      return result;

    if (targetType.IsSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
    {
      var targetInstance = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
      targetInstance.Text = value.ToString()!;
      return targetInstance;
    }
    else
    if (targetType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProp = targetType.GetValProperty();
      if (valProp == null)
        throw new NotSupportedException($"Val property in {targetType.FullName} not found.");
      var valValue = ConvertTo(value, valProp.PropertyType, conversionToMap);
      var targetInstance = Activator.CreateInstance(targetType);
      valProp.SetValue(targetInstance, valValue);
      return targetInstance;
    }
    if (targetType.IsEqualOrSubclassOf(typeof(DX.StringValue)))
    {
      var targetInstance = (DX.StringValue)Activator.CreateInstance(targetType)!;
      targetInstance.Value = value.ToString()!;
      return targetInstance;
    }
    throw new NotSupportedException($"Conversion from {sourceType.FullName} to {targetType.FullName} is not supported.");
  }

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="conversionFromMap">Conversion map for reverse conversions.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertFrom(object? value, Type targetType, ConversionFromMap conversionFromMap)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (sourceType == targetType)
      return value;

    Debug.WriteLine($"Start converting from {sourceType.FullName} to {targetType.FullName}");

    var sourceSubType = Nullable.GetUnderlyingType(sourceType) ?? sourceType;
    while (sourceSubType != null)
    {
      Debug.WriteLine($"Search for conversion from {sourceSubType.FullName} to {targetType.FullName}");

      if (conversionFromMap.TryGetValue((sourceSubType, targetType), out var conversionFunc))
      {
        Debug.WriteLine($"Converting from {sourceType.FullName} to {sourceSubType.FullName}");
        return conversionFunc(value);
      }

      sourceSubType = sourceSubType.BaseType;
    }

    if (TryImplicitConvert(value, targetType, out var result))
      return result;

    if (value is DX.OpenXmlLeafTextElement textElement)
    {
      var valValue = textElement.Text;
      return ConvertFrom(valValue, targetType, conversionFromMap);
    }

    if (sourceType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProp = sourceType.GetValProperty();
      if (valProp == null)
        throw new NotSupportedException($"Val property in {sourceType.FullName} not found.");
      var valValue = valProp.GetValue(value);
      return ConvertFrom(valValue, targetType, conversionFromMap);
    }
    if (sourceType.IsEqualOrSubclassOf(typeof(DX.StringValue)))
    {
      var valProp = sourceType.GetValProperty();
      if (valProp == null)
        throw new NotSupportedException($"Val property in {sourceType.FullName} not found.");
      var valValue = valProp.GetValue(value);
      return ConvertFrom(valValue, targetType, conversionFromMap);
    }
    throw new NotSupportedException($"Conversion from {sourceType.FullName} to {targetType.FullName} is not supported.");
  }

  /// <summary>
  /// Attempts to convert a value to the specified target type using an implicit conversion operator, if available.
  /// </summary>
  /// <param name="source">The source value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="result">The converted value if the conversion succeeds; otherwise, null.</param>
  /// <returns>True if an implicit conversion was performed; otherwise, false.</returns>
  public static bool TryImplicitConvert(object? source, Type targetType, out object? result)
  {
    result = null;
    if (source == null) return true;

    var sourceType = source.GetType();
    var methods = sourceType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Concat(targetType.GetMethods(BindingFlags.Public | BindingFlags.Static)).ToArray();
    var op = methods.FirstOrDefault(m => m.Name == "op_Implicit"
           && m.ReturnType == targetType && m.GetParameters() is [{ ParameterType: var p }] && p.IsAssignableFrom(sourceType));
    if (op == null) return false;

    result = op.Invoke(null, [source]);
    return true;
  }

}