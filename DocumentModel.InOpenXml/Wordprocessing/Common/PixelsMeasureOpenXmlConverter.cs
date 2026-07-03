namespace DocumentModel.Wordprocessing;
/// <summary>
/// Converter class responsible for registering Open XML conversion delegates for table measurement properties,
/// specifically for the PixelsMeasure property in WordprocessingML documents.
/// This class ensures that the conversion logic for PixelsMeasure is properly integrated into the OpenXmlModelConverter framework,
/// allowing seamless translation between the DocumentModel representation and the Open XML SDK representation of table height properties.
/// </summary>
public static class PixelsMeasureOpenXmlConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DX.UInt32Value), nameof(ConvertFromUInt32Value), nameof(ConvertToUInt32Value)),
    new(typeof(DXW.MarginHeight), nameof(ConvertFromOpenXmlPixelsMeasureType), nameof(ConvertToOpenXmlPixelsMeasureType)),
    new(typeof(DXW.MarginWidth), nameof(ConvertFromOpenXmlPixelsMeasureType), nameof(ConvertToOpenXmlPixelsMeasureType)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="PixelsMeasureOpenXmlConverter"/>.
  /// </summary>
  static PixelsMeasureOpenXmlConverter()
  {
    RegisterOpenXmlConversion();
  }
  /// <summary>
  /// Registers the conversion delegates that enable conversion between the PixelsMeasure type and its Open XML
  /// representation.
  /// </summary>
  /// <remarks>Call this method to ensure that PixelsMeasure objects can be correctly converted to and from their
  /// Open XML equivalents when working with OpenXmlModelConverter. This registration is required before performing
  /// conversions involving PixelsMeasure in Open XML documents.</remarks>
  public static void RegisterOpenXmlConversion()
  {
    ConverterBase.RegisterConversionMethods(typeof(PixelsMeasureOpenXmlConverter), typeof(PixelsMeasure), supportedConversions, ConversionToMap, ConversionFromMap);
    SimpleValueConverter.RegisterConverterType(typeof(PixelsMeasureOpenXmlConverter));
  }

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to Int32.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The Int32 value, or null if the element has no content.</returns>
  private static PixelsMeasure? ConvertFromUInt32Value(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;

    if (UInt32Value.Value > Int32.MaxValue)
      throw new OverflowException($"Value {UInt32Value.Value} is out of range for Int32");

    return new PixelsMeasure((Int32)UInt32Value.Value);
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  private static DX.UInt32Value? ConvertToUInt32Value(PixelsMeasure? value)
  {
    if (value == null) return null;

    return new DX.UInt32Value { Value = (UInt32)value.Value };
  }

  #endregion

  /// <summary>
  /// Converts an Open XML PixelsMeasureType element to its corresponding domain model representation.
  /// </summary>
  /// <param name = "openXmlElement">The Open XML element to convert. Must be an instance of DXW.PixelsMeasureType to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name = "modelType">The target model type. Conversion is performed only if this is typeof(PixelsMeasure).</param>
  /// <returns>A PixelsMeasure object if the conversion is successful; otherwise, null.</returns>
  private static PixelsMeasure? ConvertFromOpenXmlPixelsMeasureType(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXW.PixelsMeasureType pixelsMeasureType)
      return PixelsMeasure.FromOpenXml(pixelsMeasureType);
    return null;
  }

  /// <summary>
  /// Converts a model object representing PixelsMeasure to an Open XML PixelsMeasureType object if the specified type
  /// matches.
  /// </summary>
  /// <remarks>This method is intended for internal use when mapping model objects to Open XML types. If the
  /// provided model object is not compatible with the specified Open XML type, the method returns null without throwing
  /// an exception.</remarks>
  /// <param name = "modelObject">The model object to convert. Must be an instance of DocumentModel.PixelsMeasure to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name = "openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXW.PixelsMeasureType).</param>
  /// <returns>An Open XML PixelsMeasureType object if the conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlPixelsMeasureType(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXW.PixelsMeasureType) && modelObject is PixelsMeasure PixelsMeasure)
    {
      return PixelsMeasure.ToOpenXml(openXmlType);
    }

    return null;
  }
}