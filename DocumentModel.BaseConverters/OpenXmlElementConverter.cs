namespace DocumentModel.OpenXml;


/// <summary>
/// Provides conversion methods between model objects and Open XML element types.
/// </summary>
public static class OpenXmlElementConverter
{

  /// <summary>
  /// Converts a model modelValue to an Open XML element of the specified type.
  /// </summary>
  /// <param name="modelValue">The model modelValue to convert.</param>
  /// <param name="openXmlType">The target Open XML element type.</param>
  /// <returns>The converted Open XML element instance.</returns>
  /// <exception cref="NotSupportedException">Thrown if the conversion is not supported for the specified type.</exception>
  public static object? ConvertTo(object? modelValue, Type openXmlType)
  {
    if (modelValue == null)
      return null;

    var modelType = modelValue.GetType().GetNotNullableType();
    if (modelType == openXmlType)
      return true;

    if (OpenXmlModelConverter.ConvertToOpenXmlDelegates.TryGetValue(modelType, out var convertDelegate)
        || OpenXmlModelConverter.ConvertToOpenXmlDelegates.TryGetValue(openXmlType, out convertDelegate))
    {
      return convertDelegate(modelValue, openXmlType)!;
    }
    if (openXmlType.IsEqualOrSubclassOf(typeof(DXW.EmptyType)))
    {
      if (modelValue is bool boolValue && boolValue)
      {
        return Activator.CreateInstance(modelType);
      }
      return null;
    }

    if (SimpleValueConverter.TryConvertTo(modelValue, openXmlType, out var result))
    {
      return result;
    }


    var openXmlElement = Activator.CreateInstance(openXmlType)!;
    OpenXmlModelConverter.UpdateData(modelValue, openXmlElement, openXmlType);
    return openXmlElement;
  }

  /// <summary>
  /// Converts an Open XML openXmlElement to a model object of the specified type.
  /// </summary>
  /// <param name="openXmlElement">The Open XML openXmlElement to convert from.</param>
  /// <param name="modelType">The target model type.</param>
  /// <returns>The converted model object.</returns>
  /// <exception cref="NotSupportedException">Thrown if the conversion is not supported for the openXmlElement type.</exception>
  public static object? ConvertFrom(DX.OpenXmlElement? openXmlElement, Type modelType)
  {
    if (openXmlElement == null)
      return null;

    var openXmlType = openXmlElement.GetType().GetNotNullableType();
    if (openXmlType == modelType)
      return openXmlElement;

    if (OpenXmlModelConverter.ConvertFromOpenXmlDelegates.TryGetValue(openXmlType, out var convertDelegate) 
        || OpenXmlModelConverter.ConvertFromOpenXmlDelegates.TryGetValue(modelType, out convertDelegate))
    {
      return convertDelegate(openXmlElement, modelType)!;
    }

    if (openXmlType.IsEqualOrSubclassOf(typeof(DXW.EmptyType)) && modelType==typeof(bool))
    {
      return true;
    }
    if (SimpleValueConverter.TryConvertFrom(openXmlElement, modelType, out var result))
    {
      return result;
    }
    var modelObject = Activator.CreateInstance(modelType)!;
    OpenXmlModelConverter.LoadData(modelObject, openXmlElement);
    return modelObject;
  }


}
