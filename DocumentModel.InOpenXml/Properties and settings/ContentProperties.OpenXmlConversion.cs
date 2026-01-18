namespace DocumentModel;

public partial class ContentProperties
{
  /// <summary>
  /// Registers conversion delegates for OpenXml property types to enable conversion between OpenXml elements and their
  /// corresponding domain objects.
  /// </summary>
  /// <remarks>Call this method before performing conversions using the OpenXmlConverter to ensure that the
  /// necessary type mappings are available. This method is typically invoked during application initialization to
  /// configure conversion support for HeadingPairs, TitlesOfParts, HyperlinkList, and DigitalSignature
  /// elements.</remarks>
  public new static void RegisterOpenXmlConversion()
  {
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(DXEP.HeadingPairs)] = ConvertFromOpenXmlHeadingPairs;
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(DXEP.TitlesOfParts)] = ConvertFromOpenXmlTitlesOfParts;
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(DXEP.HyperlinkList)] = ConvertFromOpenXmlHyperlinkList;
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(DXEP.DigitalSignature)] = ConvertFromOpenXmlDigitalSignature;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(DXEP.HeadingPairs)] = ConvertToOpenXmlHeadingPairs;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(DXEP.TitlesOfParts)] = ConvertToOpenXmlTitlesOfParts;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(DXEP.HyperlinkList)] = ConvertToOpenXmlHyperlinkList;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(DXEP.DigitalSignature)] = ConvertToOpenXmlDigitalSignature;
  }

  /// <summary>
  /// Converts an Open XML HeadingPairs element to its corresponding domain model representation.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <param name="modelType"></param>
  /// <returns></returns>
  private static object? ConvertFromOpenXmlHeadingPairs(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXEP.HeadingPairs headingPairs)
    {
      var variant = headingPairs.VTVector;
      return variant?.AsHeadingPairs();
    }
    return null;
  }

  /// <summary>
  /// Converts a model object representing heading pairs to an Open XML HeadingPairs object if the specified type
  /// matches.
  /// </summary>
  /// <remarks>This method is intended for internal use when mapping model objects to Open XML types. If the
  /// provided model object is not compatible with the specified Open XML type, the method returns null without throwing
  /// an exception.</remarks>
  /// <param name="modelObject">The model object to convert. Must be an instance of DocumentModel.HeadingPairs to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name="openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXEP.HeadingPairs).</param>
  /// <returns>An Open XML HeadingPairs object if the conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlHeadingPairs(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXEP.HeadingPairs))
    {
      if (modelObject is DocumentModel.HeadingPairs headingPairs)
        return new DXEP.HeadingPairs(headingPairs.AsVTVector()!);
    }
    return null;
  }

  /// <summary>
  /// Converts an OpenXml TitlesOfParts element to a list of string titles, if available.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to convert. If not a TitlesOfParts element, the method returns null.</param>
  /// <param name="modelType">The target model type for conversion. This parameter is reserved for future extensibility and does not affect the
  /// current conversion logic.</param>
  /// <returns>A list of strings representing the titles contained in the OpenXml TitlesOfParts element; or null if the input is
  /// not a valid TitlesOfParts element or contains no titles.</returns>
  private static object? ConvertFromOpenXmlTitlesOfParts(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXEP.TitlesOfParts titlesOfParts)
    {
      var variant = titlesOfParts.VTVector;
      return variant?.AsStringList();
    }
    return null;
  }

  /// <summary>
  /// Converts a model object representing a list of titles of parts to an OpenXml TitlesOfParts instance if the
  /// specified type matches.
  /// </summary>
  /// <remarks>This method returns null if the model object is not a DocumentModel.StringList or if the
  /// openXmlType does not match DXEP.TitlesOfParts.</remarks>
  /// <param name="modelObject">The model object to convert. Must be a DocumentModel.StringList representing the titles of parts, or null.</param>
  /// <param name="openXmlType">The target OpenXml type. Conversion is performed only if this is typeof(DXEP.TitlesOfParts).</param>
  /// <returns>An instance of DXEP.TitlesOfParts if conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlTitlesOfParts(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXEP.TitlesOfParts))
    {
      if (modelObject is DocumentModel.StringList titlesOfParts)
        return new DXEP.TitlesOfParts(titlesOfParts.AsVTVector()!);
    }
    return null;
  }

  /// <summary>
  /// Converts an Open XML HyperlinkList element to its corresponding model representation.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element to convert. This should be an instance of a HyperlinkList or null.</param>
  /// <param name="modelType">The target model type to which the Open XML element should be converted.</param>
  /// <returns>An object representing the converted HyperlinkList, or null if the input is not a valid HyperlinkList element.</returns>
  private static object? ConvertFromOpenXmlHyperlinkList(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXEP.HyperlinkList hyperlinkList)
    {
      var variant = hyperlinkList.VTVector;
      return variant?.AsHyperlinkList();
    }
    return null;
  }

  /// <summary>
  /// Converts a model object representing a hyperlink list to an Open XML HyperlinkList instance if the specified type
  /// matches.
  /// </summary>
  /// <remarks>This method is intended for internal use when mapping model hyperlink lists to their Open XML
  /// equivalents. No conversion is performed if the type does not match or if the model object is not of the expected
  /// type.</remarks>
  /// <param name="modelObject">The model object to convert. Expected to be a DocumentModel.HyperlinkList instance if conversion is desired. Can
  /// be null.</param>
  /// <param name="openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXEP.HyperlinkList).</param>
  /// <returns>An instance of DXEP.HyperlinkList if the conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlHyperlinkList(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXEP.HyperlinkList))
    {
      if (modelObject is DocumentModel.HyperlinkList hyperlinkList)
        return new DXEP.HyperlinkList(hyperlinkList.AsVTVector()!);
    }
    return null;
  }

  /// <summary>
  /// Converts an Open XML digital signature element to its corresponding byte array representation, if available.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element to convert. Expected to be a digital signature element or null.</param>
  /// <param name="modelType">The target model type for the conversion. This parameter is reserved for future extensibility and is not currently
  /// used.</param>
  /// <returns>A byte array containing the digital signature data if the input is a valid digital signature element with a value;
  /// otherwise, null.</returns>
  private static object? ConvertFromOpenXmlDigitalSignature(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXEP.DigitalSignature digitalSignature)
    {
      var variant = digitalSignature.VTBlob;
      return variant?.AsByteArray();
    }
    return null;
  }

  /// <summary>
  /// Converts a model object representing a digital signature to an Open XML DigitalSignature object, if compatible.
  /// </summary>
  /// <param name="modelObject">The model object to convert. Must be a byte array representing the digital signature, or null.</param>
  /// <param name="openXmlType">The target Open XML type for conversion. Must be typeof(DigitalSignature) to perform the conversion.</param>
  /// <returns>An instance of DigitalSignature if the model object is a byte array and the target type is DigitalSignature;
  /// otherwise, null.</returns>
  private static object? ConvertToOpenXmlDigitalSignature(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXEP.DigitalSignature) && modelObject is byte[] digitalSignature)
      return new DXEP.DigitalSignature
      {
        VTBlob = new DXVT.VTBlob(new Base64Binary(digitalSignature))
      };
    return null;
  }

}