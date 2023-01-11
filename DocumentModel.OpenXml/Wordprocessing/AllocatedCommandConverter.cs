namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public static class AllocatedCommandConverter
{
  /// <summary>
  /// argValue
  /// </summary>
  public static String? GetArgumentValue(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement)
  {
    return openXmlElement?.ArgumentValue?.Value;
  }
  
  public static void SetArgumentValue(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ArgumentValue = new StringValue { Value = value };
      else
        openXmlElement.ArgumentValue = null;
  }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  public static String? GetCommandBasedOn(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement)
  {
    return openXmlElement?.CommandBasedOn?.Value;
  }
  
  public static void SetCommandBasedOn(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CommandBasedOn = new StringValue { Value = value };
      else
        openXmlElement.CommandBasedOn = null;
  }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  public static DocumentModel.HexBinary? GetCommandIndexBasedOn(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetCommandIndexBasedOn(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// acdName
  /// </summary>
  public static String? GetAcceleratorName(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement)
  {
    return openXmlElement?.AcceleratorName?.Value;
  }
  
  public static void SetAcceleratorName(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AcceleratorName = new StringValue { Value = value };
      else
        openXmlElement.AcceleratorName = null;
  }
  
  public static DocumentModel.Wordprocessing.AllocatedCommand? CreateModelElement(DocumentFormat.OpenXml.Office.Word.AllocatedCommand? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AllocatedCommand();
      value.ArgumentValue = GetArgumentValue(openXmlElement);
      value.CommandBasedOn = GetCommandBasedOn(openXmlElement);
      value.CommandIndexBasedOn = GetCommandIndexBasedOn(openXmlElement);
      value.AcceleratorName = GetAcceleratorName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AllocatedCommand? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.AllocatedCommand, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
