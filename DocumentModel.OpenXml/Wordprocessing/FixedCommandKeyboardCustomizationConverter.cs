namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public static class FixedCommandKeyboardCustomizationConverter
{
  /// <summary>
  /// fciName
  /// </summary>
  public static String? GetCommandName(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement)
  {
    return openXmlElement?.CommandName?.Value;
  }
  
  public static void SetCommandName(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CommandName = new StringValue { Value = value };
      else
        openXmlElement.CommandName = null;
  }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  public static DocumentModel.HexBinary? GetCommandIndex(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetCommandIndex(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// swArg
  /// </summary>
  public static DocumentModel.HexBinary? GetArgument(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetArgument(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization? CreateModelElement(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization();
      value.CommandName = GetCommandName(openXmlElement);
      value.CommandIndex = GetCommandIndex(openXmlElement);
      value.Argument = GetArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
