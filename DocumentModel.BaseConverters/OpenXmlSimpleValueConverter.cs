namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for simple value types in Open XML elements.
/// </summary>
public static class OpenXmlSimpleValueConverter
{
  /// <summary>
  /// Supported model types for conversion.
  /// </summary>
  public static Type[] SupportedModelTypes { get; } =
  [
    typeof(bool),
    typeof(string),
    typeof(Enum),
    typeof(Int32),
    typeof(Int64),
    typeof(UInt32),
    typeof(UInt16),
    typeof(Int16),
    typeof(Byte),
    typeof(SByte),
    typeof(UInt64),
    typeof(Guid),
  ];

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

    if (modelValue is Int64 int64Value && Int64OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return Int64OpenXmlConverter.ConvertToOpenXml(int64Value, openXmlType);

    if (modelValue is UInt32 uint32Value && UInt32OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return UInt32OpenXmlConverter.ConvertToOpenXml(uint32Value, openXmlType);

    if (modelValue is UInt16 uint16Value && UInt16OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return UInt16OpenXmlConverter.ConvertToOpenXml(uint16Value, openXmlType);

    if (modelValue is Int16 int16Value && Int16OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return Int16OpenXmlConverter.ConvertToOpenXml(int16Value, openXmlType);

    if (modelValue is Byte byteValue && ByteOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return ByteOpenXmlConverter.ConvertToOpenXml(byteValue, openXmlType);

    if (modelValue is SByte sbyteValue && SByteOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return SByteOpenXmlConverter.ConvertToOpenXml(sbyteValue, openXmlType);

    if (modelValue is UInt64 uint64Value && UInt64OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return UInt64OpenXmlConverter.ConvertToOpenXml(uint64Value, openXmlType);

    if (modelValue is Guid guidValue && GuidOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return GuidOpenXmlConverter.ConvertToOpenXml(guidValue, openXmlType);

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

    if (modelType == typeof(Int32) && Int32OpenXmlConverter.SupportedTypes.Contains(openXmlType))

      return Int32OpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(Int64) && Int64OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return Int64OpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(UInt32) && UInt32OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return UInt32OpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(UInt16) && UInt16OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return UInt16OpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(Int16) && Int16OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return Int16OpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(Byte) && ByteOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return ByteOpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(SByte) && SByteOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return SByteOpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(UInt64) && UInt64OpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return UInt64OpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    if (modelType == typeof(Guid) && GuidOpenXmlConverter.SupportedTypes.Contains(openXmlType))
      return GuidOpenXmlConverter.ConvertFromOpenXml(openXmlValue);

    throw new InvalidOperationException($"Cannot convert {openXmlValue} of type {openXmlType} to model type {modelType.FullName}");
  }
}