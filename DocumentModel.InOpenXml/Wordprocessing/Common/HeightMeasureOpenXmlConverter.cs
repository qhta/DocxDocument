namespace DocumentModel.Wordprocessing;

/// <summary>
/// Converter class responsible for registering Open XML conversion delegates for table measurement properties,
/// specifically for the HeightMeasure property in WordprocessingML documents.
/// This class ensures that the conversion logic for HeightMeasure is properly integrated into the OpenXmlModelConverter framework,
/// allowing seamless translation between the DocumentModel representation and the Open XML SDK representation of table height properties.
/// </summary>
public static class HeightMeasureOpenXmlConverter
{
  /// <summary>
  /// Registers the conversion delegates that enable conversion between the HeightMeasure type and its Open XML
  /// representation.
  /// </summary>
  /// <remarks>Call this method to ensure that HeightMeasure objects can be correctly converted to and from their
  /// Open XML equivalents when working with OpenXmlModelConverter. This registration is required before performing
  /// conversions involving HeightMeasure in Open XML documents.</remarks>
  public static void RegisterOpenXmlConversion()
  {
    OpenXmlModelConverter.ConvertFromOpenXmlDelegates[typeof(DXW.TableRowHeight)] = ConvertFromOpenXmlTableRowHeight;
    OpenXmlModelConverter.ConvertToOpenXmlDelegates[typeof(DXW.TableRowHeight)] = ConvertToOpenXmlTableRowHeight;
  }


  /// <summary>
  /// Converts an Open XML TableRowHeight element to its corresponding domain model representation.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element to convert. Must be an instance of DXW.TableRowHeight to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name="modelType">The target model type. Conversion is performed only if this is typeof(HeightMeasure).</param>
  /// <returns>A HeightMeasure object if the conversion is successful; otherwise, null.</returns>
  private static HeightMeasure? ConvertFromOpenXmlTableRowHeight(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXW.TableRowHeight tableRowHeight)
    {
      if (tableRowHeight.HeightType == null || tableRowHeight.Val == null)
        return null;
      if (tableRowHeight.HeightType == DXW.HeightRuleValues.Auto)
        return new HeightMeasure("auto");
      if (tableRowHeight.HeightType == DXW.HeightRuleValues.AtLeast)
        return new HeightMeasure("atLeast "+tableRowHeight.Val);
      if (tableRowHeight.HeightType == DXW.HeightRuleValues.Exact)
        return new HeightMeasure("exact "+tableRowHeight.Val);
    }
    return null;
  }


  /// <summary>
  /// Converts a model object representing table width to an Open XML TableRowHeight  object if the specified type
  /// matches.
  /// </summary>
  /// <remarks>This method is intended for internal use when mapping model objects to Open XML types. If the
  /// provided model object is not compatible with the specified Open XML type, the method returns null without throwing
  /// an exception.</remarks>
  /// <param name="modelObject">The model object to convert. Must be an instance of DocumentModel.HeadingPairs to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name="openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXW.TableRowHeight).</param>
  /// <returns>An Open XML TableRowHeight object if the conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlTableRowHeight(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXW.TableRowHeight))
    {
      if (modelObject is HeightMeasure HeightMeasure)
        return new DXW.TableRowHeight
        {
          Val = (UInt32)HeightMeasure.UIntValue,
          // ReSharper disable once InvokeAsExtensionMember
          HeightType = EnumTypeConverter.CreateOpenXmlEnumValue<DXW.HeightRuleValues, HeightMeasureType>(HeightMeasure.Type)
        };
    }
    return null;
  }

}