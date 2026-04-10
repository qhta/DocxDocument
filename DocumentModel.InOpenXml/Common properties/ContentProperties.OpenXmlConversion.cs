namespace DocumentModel;
public partial class ContentProperties
{
 /// <summary>
 /// Registers conversion delegates for OpenXml property types to enable conversion between OpenXml elements and their
 /// corresponding domain objects.
 /// </summary>
 /// <remarks>Call this method before performing conversions using the OpenXmlModelConverter to ensure that the
 /// necessary type mappings are available. This method is typically invoked during application initialization to
 /// configure conversion support for HeadingPairs, TitlesOfParts, HyperlinkList, and DigitalSignature
 /// elements.</remarks>
 public new static void RegisterOpenXmlConversion()
 {
  OpenXmlModelConverter.ConvertFromOpenXmlDelegates[typeof(DXEP.HeadingPairs)] = ConvertFromOpenXmlHeadingPairs;
  OpenXmlModelConverter.ConvertFromOpenXmlDelegates[typeof(DXEP.TitlesOfParts)] = ConvertFromOpenXmlTitlesOfParts;
  OpenXmlModelConverter.ConvertFromOpenXmlDelegates[typeof(DXEP.HyperlinkList)] = ConvertFromOpenXmlHyperlinkList;
  OpenXmlModelConverter.ConvertFromOpenXmlDelegates[typeof(DXEP.DigitalSignature)] = ConvertFromOpenXmlDigitalSignature;
  OpenXmlModelConverter.ConvertToOpenXmlDelegates[typeof(DXEP.HeadingPairs)] = ConvertToOpenXmlHeadingPairs;
  OpenXmlModelConverter.ConvertToOpenXmlDelegates[typeof(DXEP.TitlesOfParts)] = ConvertToOpenXmlTitlesOfParts;
  OpenXmlModelConverter.ConvertToOpenXmlDelegates[typeof(DXEP.HyperlinkList)] = ConvertToOpenXmlHyperlinkList;
  OpenXmlModelConverter.ConvertToOpenXmlDelegates[typeof(DXEP.DigitalSignature)] = ConvertToOpenXmlDigitalSignature;
 }

 /// <summary>
 /// Converts an Open XML HeadingPairs element to its corresponding domain model representation.
 /// </summary>
 /// <param name = "openXmlElement"></param>
 /// <param name = "modelType"></param>
 /// <returns></returns>
 private static object? ConvertFromOpenXmlHeadingPairs(object? openXmlElement, Type modelType)
 {
  if (openXmlElement is DXEP.HeadingPairs headingPairs)
  {
   var variant = headingPairs.VTVector;
   return VTVectorToHeadingPairs(variant);
  }

  return null;
 }

 /// <summary>
 /// Converts the specified OpenXml VTVector element to a HeadingPairs value.
 /// </summary>
 /// <param name = "element">VTVector element to convert.</param>
 /// <returns>HeadingPairs representation of the VTVector.</returns>
 public static HeadingPairs? VTVectorToHeadingPairs(DXVT.VTVector? element)
 {
  var array = element?.AsArray();
  if (array != null)
  {
   var result = new HeadingPairs();
   for (int i = 0; i < array.Length / 2; i++)
   {
    var item1 = array.GetValue(i * 2);
    var item2 = array.GetValue(i * 2 + 1);
    if (item1 is string str && item2 is int num)
     result.Add(new HeadingPair { Name = str, Number = num });
   }

   return result;
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
 /// <param name = "modelObject">The model object to convert. Must be an instance of DocumentModel.HeadingPairs to perform the conversion;
 /// otherwise, the method returns null.</param>
 /// <param name = "openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXEP.HeadingPairs).</param>
 /// <returns>An Open XML HeadingPairs object if the conversion is successful; otherwise, null.</returns>
 private static object? ConvertToOpenXmlHeadingPairs(object? modelObject, Type openXmlType)
 {
  if (openXmlType == typeof(DXEP.HeadingPairs))
  {
   if (modelObject is DocumentModel.HeadingPairs headingPairs)
    return new DXEP.HeadingPairs(ConvertVTVectorToHeadingPairs(headingPairs)!);
  }

  return null;
 }

 /// <summary>
 /// Converts the specified HeadingPairs value to an OpenXml VTVector element.
 /// </summary>
 /// <param name = "value">The HeadingPairs value to convert.</param>
 /// <returns>VTVector representation of the HeadingPairs.</returns>
 public static DXVT.VTVector? ConvertVTVectorToHeadingPairs(HeadingPairs? value)
 {
  if (value == null)
   return null;
  var result = new DXVT.VTVector
  {
   Size = new DX.UInt32Value((uint)value.Count() * 2),
   BaseType = new DX.EnumValue<DXVT.VectorBaseValues>(DXVT.VectorBaseValues.Variant)
  };
  foreach (var item in value)
  {
   var childItem1 = new DXVT.VTLPSTR(item.Name ?? "");
   result.AppendChild(childItem1);
   var childItem2 = new DXVT.VTInt32(item.Number.ToString() ?? "");
   result.AppendChild(childItem2);
  }

  return result;
 }

 /// <summary>
 /// Converts an OpenXml TitlesOfParts element to a list of string titles, if available.
 /// </summary>
 /// <param name = "openXmlElement">The OpenXml element to convert. If not a TitlesOfParts element, the method returns null.</param>
 /// <param name = "modelType">The target model type for conversion. This parameter is reserved for future extensibility and does not affect the
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
 /// <param name = "modelObject">The model object to convert. Must be a DocumentModel.StringList representing the titles of parts, or null.</param>
 /// <param name = "openXmlType">The target OpenXml type. Conversion is performed only if this is typeof(DXEP.TitlesOfParts).</param>
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
 /// <param name = "openXmlElement">The Open XML element to convert. This should be an instance of a HyperlinkList or null.</param>
 /// <param name = "modelType">The target model type to which the Open XML element should be converted.</param>
 /// <returns>An object representing the converted HyperlinkList, or null if the input is not a valid HyperlinkList element.</returns>
 private static object? ConvertFromOpenXmlHyperlinkList(object? openXmlElement, Type modelType)
 {
  if (openXmlElement is DXEP.HyperlinkList hyperlinkList)
  {
   var variant = hyperlinkList.VTVector;
   return VTVectorToHyperlinkList(variant);
  }

  return null;
 }

 /// <summary>
 /// Converts the specified OpenXml VTVector element to a HyperlinkList value.
 /// </summary>
 /// <param name = "element">The OpenXml VTVector element to convert.</param>
 /// <returns>A HyperlinkList representing the converted element, or null if the conversion fails.</returns>
 public static HyperlinkList? VTVectorToHyperlinkList(DXVT.VTVector? element)
 {
  var array = element?.AsArray();
  if (array != null)
  {
   var result = new HyperlinkList();
   int n = array.Length;
   for (int i = 0; i < n / 6; i++)
   {
    var item = new HyperlinkInfo();
    for (var k = 0; k < 6; k++)
    {
     var varItem = array.GetValue(i * 6 + k);
     if (varItem is not null)
     {
      switch (k)
      {
       case 0:
        item.N1 = (int)varItem;
        break;
       case 1:
        item.N2 = (int)varItem;
        break;
       case 2:
        item.N3 = (int)varItem;
        break;
       case 3:
        var n4 = (int)varItem;
        var n4l = (Int16)(n4 & 0xFFFF);
        item.Attachment = (HyperlinkAttachment)Enum.ToObject(typeof(HyperlinkAttachment), n4l);
        var n4h = (Int16)(n4 >> 16 & 0xFFFF);
        item.Action = (HyperlinkAction)Enum.ToObject(typeof(HyperlinkAction), n4h);
        break;
       case 4:
        item.Target = (string? )varItem ?? string.Empty;
        break;
       case 5:
        item.Location = (string? )varItem ?? string.Empty;
        break;
      }
     }
    }

    result.Add(item);
   }

   return result;
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
 /// <param name = "modelObject">The model object to convert. Expected to be a DocumentModel.HyperlinkList instance if conversion is desired. Can
 /// be null.</param>
 /// <param name = "openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXEP.HyperlinkList).</param>
 /// <returns>An instance of DXEP.HyperlinkList if the conversion is successful; otherwise, null.</returns>
 private static object? ConvertToOpenXmlHyperlinkList(object? modelObject, Type openXmlType)
 {
  if (openXmlType == typeof(DXEP.HyperlinkList))
  {
   if (modelObject is DocumentModel.HyperlinkList hyperlinkList)
    return new DXEP.HyperlinkList(HyperlinkListToVTVector(hyperlinkList)!);
  }

  return null;
 }

 /// <summary>
 /// Converts the specified HyperlinkList value to an OpenXml VTVector element.
 /// </summary>
 /// <param name = "value">The HyperlinkList value to convert.</param>
 /// <returns>VTVector representation of the HyperlinkList.</returns>
 public static DXVT.VTVector? HyperlinkListToVTVector(HyperlinkList? value)
 {
  if (value == null)
   return null;
  var result = new DXVT.VTVector
  {
   Size = new DX.UInt32Value((uint)value.Count * 2),
   BaseType = new DX.EnumValue<DXVT.VectorBaseValues>(DXVT.VectorBaseValues.Variant)
  };
  foreach (var item in value)
  {
   result.AppendChild(new DXVT.VTInt32(item.N1.ToString()));
   result.AppendChild(new DXVT.VTInt32(item.N2.ToString()));
   result.AppendChild(new DXVT.VTInt32(item.N3.ToString()));
   var n4h = (uint)Convert.ChangeType(item.Action, typeof(uint));
   var n4l = (uint)Convert.ChangeType(item.Attachment, typeof(uint));
   var n4 = (n4h << 16) | (n4l);
   result.AppendChild(new DXVT.VTInt32(n4.ToString()));
   result.AppendChild(new DXVT.VTLPSTR(item.Target ?? ""));
   result.AppendChild(new DXVT.VTLPSTR(item.Location ?? ""));
  }

  return result;
 }

 /// <summary>
 /// Converts an Open XML digital signature element to its corresponding byte array representation, if available.
 /// </summary>
 /// <param name = "openXmlElement">The Open XML element to convert. Expected to be a digital signature element or null.</param>
 /// <param name = "modelType">The target model type for the conversion. This parameter is reserved for future extensibility and is not currently
 /// used.</param>
 /// <returns>A byte array containing the digital signature data if the input is a valid digital signature element with a value;
 /// otherwise, null.</returns>
 private static object? ConvertFromOpenXmlDigitalSignature(object? openXmlElement, Type modelType)
 {
  if (openXmlElement is DXEP.DigitalSignature digitalSignature)
  {
   var variant = digitalSignature.VTBlob;
   if (variant != null)
    return new HexBinary(variant.AsByteArray()!);
  }

  return null;
 }

 /// <summary>
 /// Converts a model object representing a digital signature to an Open XML DigitalSignature object, if compatible.
 /// </summary>
 /// <param name = "modelObject">The model object to convert. Must be a byte array representing the digital signature, or null.</param>
 /// <param name = "openXmlType">The target Open XML type for conversion. Must be typeof(DigitalSignature) to perform the conversion.</param>
 /// <returns>An instance of DigitalSignature if the model object is a byte array and the target type is DigitalSignature;
 /// otherwise, null.</returns>
 private static object? ConvertToOpenXmlDigitalSignature(object? modelObject, Type openXmlType)
 {
  if (openXmlType == typeof(DXEP.DigitalSignature) && modelObject is HexBinary digitalSignature)
   return new DXEP.DigitalSignature
   {
    VTBlob = new DXVT.VTBlob(new Base64Binary((byte[])digitalSignature))
   };
  return null;
 }
}
