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
  public static Byte[]? GetCommandIndex(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement)
  {
    if (openXmlElement?.CommandIndex?.Value != null)
      return Convert.FromHexString(openXmlElement.CommandIndex.Value);
    return null;
  }
  
  public static void SetCommandIndex(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.CommandIndex = Convert.ToHexString(value);
      else
        openXmlElement.CommandIndex = null;
    }
  }
  
  /// <summary>
  /// swArg
  /// </summary>
  public static Byte[]? GetArgument(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement)
  {
    if (openXmlElement?.Argument?.Value != null)
      return Convert.FromHexString(openXmlElement.Argument.Value);
    return null;
  }
  
  public static void SetArgument(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Argument = Convert.ToHexString(value);
      else
        openXmlElement.Argument = null;
    }
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommandName(openXmlElement, value?.CommandName);
      SetCommandIndex(openXmlElement, value?.CommandIndex);
      SetArgument(openXmlElement, value?.Argument);
      return openXmlElement;
    }
    return default;
  }
}
