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
  /// Gets the collection of data types supported by this instance.
  /// </summary>
  /// <remarks>Use this property to determine which types can be processed or handled by the current
  /// implementation. The returned array may be empty if no types are supported.</remarks>
  public abstract Type[] SupportedTypes { get; }

  /// <summary>
  /// Determines whether the specified type is supported, either directly or through inheritance, based on the provided
  /// list of supported types.
  /// </summary>
  /// <remarks>This method checks if the given type is a subclass of OpenXmlLeafTextElement or
  /// OpenXmlLeafElement, or if it matches any of the types in the supportedTypes array. For types derived from
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

    return SupportedTypes.Contains(type);
  }

  /// <summary>
  /// Converts the specified model value to an Open XML-compatible object of the given target type.
  /// </summary>
  /// <param name="value">The model value to convert. Can be null if the conversion supports null values.</param>
  /// <param name="targetType">The type of object to convert the model value to. Must be a valid Open XML-compatible type.</param>
  /// <returns>An object representing the converted value in the specified Open XML format, or null if the conversion cannot be
  /// performed or the input value is null.</returns>
  public abstract object? ConvertToOpenXml(ModelType value, Type targetType);


  /// <summary>
  /// Converts an OpenXML value to its corresponding model type representation.
  /// </summary>
  /// <param name="value">The OpenXML value to convert. Can be null if the source value is missing or optional.</param>
  /// <returns>A nullable model type representing the converted value, or null if the conversion is not possible or the input is
  /// null.</returns>
  public abstract ModelType ConvertFromOpenXml(object value);
}