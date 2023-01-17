namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public static class FixedCommandKeyboardCustomizationConverter
{
  /// <summary>
  /// fciName
  /// </summary>
  private static String? GetCommandName(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization openXmlElement)
  {
    return openXmlElement?.CommandName?.Value;
  }
  
  private static void SetCommandName(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CommandName = new StringValue { Value = value };
    else
      openXmlElement.CommandName = null;
  }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  private static UInt16? GetCommandIndex(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization openXmlElement)
  {
    if (openXmlElement.CommandIndex?.Value != null)
      return UInt16.Parse(openXmlElement.CommandIndex.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCommandIndex(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.CommandIndex = ((UInt16)value).ToString("X4");
      else
        openXmlElement.CommandIndex = null;
  }
  
  /// <summary>
  /// swArg
  /// </summary>
  private static UInt16? GetArgument(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization openXmlElement)
  {
    if (openXmlElement.Argument?.Value != null)
      return UInt16.Parse(openXmlElement.Argument.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetArgument(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.Argument = ((UInt16)value).ToString("X4");
      else
        openXmlElement.Argument = null;
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
