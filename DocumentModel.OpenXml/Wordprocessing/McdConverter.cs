namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public static class McdConverter
{
  /// <summary>
  /// macroName
  /// </summary>
  public static String? GetMacroName(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    return openXmlElement?.MacroName?.Value;
  }
  
  public static void SetMacroName(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MacroName = new StringValue { Value = value };
      else
        openXmlElement.MacroName = null;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  public static String? GetMenuHelp(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    return openXmlElement?.MenuHelp?.Value;
  }
  
  public static void SetMenuHelp(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MenuHelp = new StringValue { Value = value };
      else
        openXmlElement.MenuHelp = null;
  }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public static DocumentModel.HexBinary? GetBEncrypt(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetBEncrypt(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// cmg
  /// </summary>
  public static DocumentModel.HexBinary? GetCmg(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetCmg(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static DocumentModel.Wordprocessing.Mcd? CreateModelElement(DocumentFormat.OpenXml.Office.Word.Mcd? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Mcd();
      value.MacroName = GetMacroName(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.MenuHelp = GetMenuHelp(openXmlElement);
      value.BEncrypt = GetBEncrypt(openXmlElement);
      value.Cmg = GetCmg(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Mcd? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.Mcd, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
