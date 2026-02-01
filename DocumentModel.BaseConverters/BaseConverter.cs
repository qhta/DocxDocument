namespace DocumentModel.OpenXml;

/// <summary>
/// Provides a base class for converting between Open XML element types and a specified model type.
/// </summary>
/// <remarks>Implement this class to define custom conversion logic between Open XML elements and your
/// application's data models. Derived classes specify which Open XML element types are supported and provide the
/// necessary conversion methods.</remarks>
/// <typeparam name="ModelType">The type of the model to which Open XML elements are converted.</typeparam>
public abstract class BaseConverter<ModelType>
{

  /// <summary>
  /// Initializes a new instance of the BaseConverter class. Registers conversion methods for the specified model type.
  /// </summary>
  protected BaseConverter()
  {
    RegisterConversionMethods(typeof(ModelType));
  }

  /// <summary>
  /// Gets the collection of data types supported by this instance.
  /// </summary>
  /// <remarks>Use this property to determine which types can be processed or handled by the current
  /// implementation. The returned array may be empty if no types are supported.</remarks>
  public Type[] supportedConversions
  {
    get
    {
      var converterType = this.GetType();
      var field = converterType.GetField("_ConversionToMap", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      if (field != null)
      {
        if (field.GetValue(null) is ConversionToMap map)
          return map.Select(item => item.Key.Source).ToArray();
      }
      return Array.Empty<Type>();
    }
  }

  /// <summary>
  /// Gets the collection of conversion methods associated with the current converter type.
  /// </summary>
  /// <remarks>The returned array is determined by the presence of a static field named "_ConversionMethods" on
  /// the converter type. If the field is not found or does not contain any methods, an empty array is
  /// returned.</remarks>
  public ConversionMethodInfo[] ConversionMethods
  {
    get
    {
      if (_conversionMethods == null)
      {
        var converterType = this.GetType();
        var field = converterType.GetField("_ConversionMethods", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        if (field != null && field.GetValue(null) is ConversionMethodInfo[] methods)
          _conversionMethods = methods;
        else
          _conversionMethods = Array.Empty<ConversionMethodInfo>();
      }
      return _conversionMethods!;
    }
  }
  private ConversionMethodInfo[]? _conversionMethods;

  /// <summary>
  /// Collection of conversion functions to convert from model types to Open XML types.
  /// </summary>
  public ConversionToMap ConversionToMap
  {
    get
    {
      if (_conversionToMap == null)
      {
        var converterType = this.GetType();
        var field = converterType.GetField("_ConversionToMap", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        if (field != null && field.GetValue(null) is ConversionToMap map)
          _conversionToMap = map;
        else
          _conversionToMap = new ConversionToMap();
      }
      return _conversionToMap!;
    }
    set => _conversionToMap = value;
  }
  private ConversionToMap? _conversionToMap;

  /// <summary>
  /// Collection of conversion functions to convert from Open XML types to model types.
  /// </summary>
  public ConversionFromMap ConversionFromMap
  {
    get
    {
      if (_conversionFromMap == null)
      {
        var converterType = this.GetType();
        var field = converterType.GetField("_ConversionFromMap", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        if (field != null && field.GetValue(null) is ConversionFromMap map)
          _conversionFromMap = map;
        else
          _conversionFromMap = new ConversionFromMap();
      }
      return _conversionFromMap!;
    }
    set => _conversionFromMap = value;
  }
  private ConversionFromMap? _conversionFromMap;

  /// <summary>
  /// Determines whether the specified type is supported, either directly or through inheritance, based on the provided
  /// list of supported types.
  /// </summary>
  /// <remarks>This method checks if the given type is a subclass of OpenXmlLeafTextElement or
  /// OpenXmlLeafElement, or if it matches any of the types in the supportedConversions array. For types derived from
  /// OpenXmlLeafElement, the method inspects the 'Val' property or, if absent, the only declared property to determine
  /// support based on its type.</remarks>
  /// <param name="type">The type to evaluate for support. Cannot be null.</param>
  /// <returns>true if the specified type or its relevant property type is supported; otherwise, false.</returns>
  public bool SupportsType(Type type)
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
      if (SupportsType(valProp.PropertyType))
        return true;

      return false;
    }

    return supportedConversions.Contains(type);
  }

  /// <summary>
  /// Determines whether the specified type is supported, either directly or through inheritance, based on the provided
  /// list of supported types.
  /// </summary>
  /// <remarks>This method checks if the given type is a subclass of OpenXmlLeafTextElement or
  /// OpenXmlLeafElement, or if it matches any of the types in the supportedConversions array. For types derived from
  /// OpenXmlLeafElement, the method inspects the 'Val' property or, if absent, the only declared property to determine
  /// support based on its type.</remarks>
  /// <param name="type">The type to evaluate for support. Cannot be null.</param>
  /// <param name="supportedConversions">An array of types that are considered supported. Cannot be null or empty.</param>
  /// <returns>true if the specified type or its relevant property type is supported; otherwise, false.</returns>
  public static bool SupportsType(Type type, Type[] supportedConversions)
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
      if (SupportsType(valProp.PropertyType, supportedConversions))
        return true;

      return false;
    }

    return supportedConversions.Contains(type);
  }


  /// <summary>
  /// Registers conversion methods for the specified model type, enabling type conversions between the model and
  /// supported target types.
  /// </summary>
  /// <remarks>This method associates conversion delegates for the given model type based on the configured
  /// conversion methods. After registration, conversions to and from the specified model type can be performed using
  /// the registered delegates. This method is typically called during initialization to set up type conversion
  /// infrastructure.</remarks>
  /// <param name="modelType">The type representing the model for which conversion methods should be registered.</param>
  public void RegisterConversionMethods(Type modelType)
  {
    var converterType = this.GetType();
    foreach (var item in ConversionMethods)
    {
      var fromMethod = converterType.GetMethod(item.ConvertFromMethod, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      var toMethod = converterType.GetMethod(item.ConvertToMethod, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      try
      {
        if (fromMethod != null)
        {
          ConversionFromMap[(item.TargetType, modelType)] = value => fromMethod.Invoke(null, [value])!;
        }
        if (toMethod != null)
        {
          ConversionToMap[(modelType, item.TargetType)] = (value, targetType) =>
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
  /// <returns>The converted value, or null if the input is null.</returns>
  public object? ConvertTo(object? value, Type targetType)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    //Debug.WriteLine($"Start converting from {sourceType.FullName} to {targetType.FullName}");

    var targetSubType = Nullable.GetUnderlyingType(targetType) ?? targetType;
    while (targetSubType != null)
    {
      //Debug.WriteLine($"Search for conversion from {sourceType.FullName} to {targetSubType.FullName}");

      if (ConversionToMap.TryGetValue((sourceType, targetSubType), out var conversionFunc))
      {
        //Debug.WriteLine($"Converting from {sourceType.FullName} to {targetSubType.FullName}");
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
      var valProp = GetValProperty(targetType);
      if (valProp == null)
        throw new NotSupportedException($"Val property in {targetType.FullName} not found.");
      var valValue = ConvertTo(value, valProp.PropertyType);
      var targetInstance = Activator.CreateInstance(targetType);
      valProp.SetValue(targetInstance, valValue);
      return targetInstance;
    }
    throw new NotSupportedException($"Conversion from {sourceType.FullName} to {targetType.FullName} is not supported.");
    // return Convert.ChangeType(value, targetType);
  }

  /// <summary>
  /// Converts a value to the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public object? ConvertFrom(object? value, Type? targetType = null)
  {
    if (targetType == null)
      targetType = typeof(ModelType);

    if (value == null) return null;

    var sourceType = value.GetType();
    if (sourceType == targetType)
      return value;

    //Debug.WriteLine($"Start converting from {sourceType.FullName} to {targetType.FullName}");

    var sourceSubType = Nullable.GetUnderlyingType(sourceType) ?? sourceType;
    while (sourceSubType != null)
    {
      //Debug.WriteLine($"Search for conversion from {sourceSubType.FullName} to {targetType.FullName}");

      if (ConversionFromMap.TryGetValue((sourceSubType, targetType), out var conversionFunc))
      {
        //Debug.WriteLine($"Converting from {sourceType.FullName} to {sourceSubType.FullName}");
        return conversionFunc(value);
      }

      sourceSubType = sourceSubType.BaseType;
    }

    if (TryImplicitConvert(value, targetType, out var result))
      return result;

    if (value is DX.OpenXmlLeafTextElement textElement)
    {
      var valValue = textElement.Text;
      return ConvertFrom(valValue, targetType);
    }
    else
    if (sourceType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProp = GetValProperty(sourceType);
      if (valProp == null)
        throw new NotSupportedException($"Val property in {sourceType.FullName} not found.");
      var valValue = valProp.GetValue(value);
      return ConvertFrom(valValue, targetType);
    }
    throw new NotSupportedException($"Conversion from {sourceType.FullName} to {targetType.FullName} is not supported.");
    // return Convert.ChangeType(value, targetType);
  }

  /// <summary>
  /// Attempts to convert a value to the specified target type using an implicit conversion operator, if available.
  /// </summary>
  /// <param name="source">The source value to convert.</param>
  /// <param name="targetType">The type to convert the value to.</param>
  /// <param name="result">The converted value if the conversion succeeds; otherwise, null.</param>
  /// <returns>True if an implicit conversion was performed; otherwise, false.</returns>
  public bool TryImplicitConvert(object? source, Type targetType, out object? result)
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

  public static PropertyInfo? GetValProperty(Type type)
  {
    if (type.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
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

    return null;
  }
}