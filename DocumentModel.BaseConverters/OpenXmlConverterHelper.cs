namespace DocumentModel.OpenXml;

public static class OpenXmlConverterHelper
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
      if (SupportsType(valProp.PropertyType supportedTypes))
        return true;

      return false;
    }

    return supportedTypes.Contains(type);
  }
}