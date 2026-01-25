namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for simple value types in Open XML elements.
/// </summary>
public static class OpenXmlSimpleValueConverter
{
  /// <summary>
  /// Converts a model object to an Open XML simple type.
  /// </summary>
  /// <param name="modelValue">The model object to convert.</param>
  /// <param name="openXmlType">The target Open XML simple type.</param>
  /// <returns>The converted Open XML simple type.</returns>
  public static object? ConvertToOpenXml(object modelValue, Type openXmlType)
  {
    //DXW.CharacterSpacingControl
    var modelType = modelValue.GetType();

    if (modelValue is bool boolValue && BooleanOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return BooleanOpenXmlConverter.ConvertToOpenXml(boolValue, openXmlType);

    if (modelValue is string stringValue && StringOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return StringOpenXmlConverter.ConvertToOpenXml(stringValue, openXmlType);

    if (modelValue is Enum enumValue && EnumOpenXmlConverter.SupportsType(openXmlType))
      return EnumOpenXmlConverter.ConvertToOpenXml(enumValue, openXmlType);

    if (modelValue is Int32 int32Value && Int32OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return Int32OpenXmlConverter.ConvertToOpenXml(int32Value, openXmlType);


    throw new InvalidOperationException($"Cannot convert {modelValue} of type {modelType} to Open XML simple type {openXmlType}");
  }
  /// <summary>
  /// Converts an Open XML simple type to a model object.
  /// </summary>
  /// <param name="openXmlValue">The Open XML simple type to convert.</param>
  /// <param name="modelType">The target model type.</param>
  /// <returns>The converted model object.</returns>
  public static object? ConvertFromOpenXml(object? openXmlValue, Type modelType)
  {
    if (openXmlValue == null)
      return null;

    var openXmlType = openXmlValue.GetType();

    if (modelType == typeof(bool) && BooleanOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return BooleanOpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(string) && StringOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return StringOpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType.IsEnum && EnumOpenXmlConverter.SupportsType(openXmlType))
      return EnumOpenXmlConverter.ConvertFromOpenXml(openXmlValue, modelType);

    if (modelType == typeof(Int32) && openXmlType ==  typeof(DX.Int32Value)
                                    && Int32OpenXmlConverter.SupportedTypes.Contains(openXmlType))

      return Int32OpenXmlConverter.ConvertFromOpenXml(openXmlValue);


    throw new InvalidOperationException($"Cannot convert {openXmlValue} of type {openXmlType} to model type {modelType.FullName}");
  }
}