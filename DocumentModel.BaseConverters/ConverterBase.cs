namespace DocumentModel.OpenXml;

public record ConversionMethodInfo(Type TargetType, string ConvertFromMethod, string ConvertToMethod);

public class ConversionToMap: Dictionary<(Type Source, Type Target), Func<object, Type, object?>>;

public class ConversionFromMap: Dictionary<(Type Source, Type Target), Func<object, object?>>;

public static class ConverterBase
{
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
        if (ex.InnerException!=null)
          throw ex.InnerException;

        throw;
      }

    }

  }
}