namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods between model values and Open XML types.
/// </summary>
public static class OpenXmlConverter
{
  public static readonly Dictionary<Type, ConvertFromOpenXml> ConvertFromOpenDelegates = new();
  public static readonly Dictionary<Type, ConvertToOpenXml> ConvertToOpenDelegates = new();

  /// <summary>
  /// Converts a model value to the specified Open XML type.
  /// </summary>
  /// <param name="modelValue">The value from the model to convert.</param>
  /// <param name="openXmlType">The target Open XML type.</param>
  /// <returns>The converted value as an Open XML type, or null if the input is null.</returns>
  public static object? ConvertToOpenXml(object? modelValue, Type openXmlType)
  {
    if (modelValue == null)
      return null;
    var modelType = modelValue.GetType().GetNotNullableType();
    if (ConvertToOpenDelegates.TryGetValue(modelType, out var convertToOpenXml)
        || ConvertToOpenDelegates.TryGetValue(openXmlType, out convertToOpenXml))
      return convertToOpenXml(modelValue, openXmlType);
    if (openXmlType.IsSubclassOf(typeof(DX.OpenXmlElement)))
      return OpenXmlElementConverter.ConvertToOpenXml(modelValue, openXmlType);
    if (openXmlType.IsSubclassOf(typeof(DX.OpenXmlSimpleType)))
      return OpenXmlSimpleValueConverter.ConvertToOpenXml(modelValue, openXmlType);
    return Convert.ChangeType(modelValue, openXmlType);
  }

  /// <summary>
  /// Converts an Open XML value to the specified model type.
  /// </summary>
  /// <param name="openXmlValue">The value from Open XML to convert.</param>
  /// <param name="modelType">The target model type.</param>
  /// <returns>The converted value as a model type, or null if the input is null.</returns>
  public static object? ConvertFromOpenXml(object? openXmlValue, Type modelType)
  {
    if (openXmlValue == null)
      return null;
    modelType = modelType.GetNotNullableType();
    var openXmlType = openXmlValue.GetType();
    if (ConvertFromOpenDelegates.TryGetValue(modelType, out var convertFromOpenXml)
        || ConvertFromOpenDelegates.TryGetValue(openXmlType, out convertFromOpenXml))
      return convertFromOpenXml(openXmlValue, modelType);

    if (modelType.IsAssignableFrom(openXmlValue.GetType()!))
    {
      return openXmlValue;
    }

    if (openXmlValue is DX.OpenXmlElement openXmlElement)
      return OpenXmlElementConverter.ConvertFromOpenXml(openXmlElement, modelType);
    if (openXmlValue is DX.OpenXmlSimpleType openXmlSimpleType)
      return OpenXmlSimpleValueConverter.ConvertFromOpenXml(openXmlSimpleType, modelType);
    return Convert.ChangeType(openXmlValue, modelType);
  }

}