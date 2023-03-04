namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public static class FixedCommandKeyboardCustomizationConverter
{
  /// <summary>
  /// fciName
  /// </summary>
  private static String? GetCommandName(DXOW.FixedCommandKeyboardCustomization openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CommandName);
  }
  
  private static bool CmpCommandName(DXOW.FixedCommandKeyboardCustomization openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CommandName, value, diffs, objName, "CommandName");
  }
  
  private static void SetCommandName(DXOW.FixedCommandKeyboardCustomization openXmlElement, String? value)
  {
    openXmlElement.CommandName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  private static DM.HexChar? GetCommandIndex(DXOW.FixedCommandKeyboardCustomization openXmlElement)
  {
    if (openXmlElement?.CommandIndex?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.CommandIndex.Value);
    return null;
  }
  
  private static bool CmpCommandIndex(DXOW.FixedCommandKeyboardCustomization openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CommandIndex?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.CommandIndex.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.CommandIndex?.Value == null && value is null) return true;
    diffs?.Add(objName, "CommandIndex", openXmlElement?.CommandIndex?.Value, value);
    return false;
  }
  
  private static void SetCommandIndex(DXOW.FixedCommandKeyboardCustomization openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.CommandIndex = value.ToString();
    else
      openXmlElement.CommandIndex = null;
  }
  
  /// <summary>
  /// swArg
  /// </summary>
  private static DM.HexChar? GetArgument(DXOW.FixedCommandKeyboardCustomization openXmlElement)
  {
    if (openXmlElement?.Argument?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.Argument.Value);
    return null;
  }
  
  private static bool CmpArgument(DXOW.FixedCommandKeyboardCustomization openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Argument?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.Argument.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.Argument?.Value == null && value is null) return true;
    diffs?.Add(objName, "Argument", openXmlElement?.Argument?.Value, value);
    return false;
  }
  
  private static void SetArgument(DXOW.FixedCommandKeyboardCustomization openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.Argument = value.ToString();
    else
      openXmlElement.Argument = null;
  }
  
  public static DMW.FixedCommandKeyboardCustomization? CreateModelElement(DXOW.FixedCommandKeyboardCustomization? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FixedCommandKeyboardCustomization();
      value.CommandName = GetCommandName(openXmlElement);
      value.CommandIndex = GetCommandIndex(openXmlElement);
      value.Argument = GetArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.FixedCommandKeyboardCustomization? openXmlElement, DMW.FixedCommandKeyboardCustomization? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCommandName(openXmlElement, value.CommandName, diffs, objName))
        ok = false;
      if (!CmpCommandIndex(openXmlElement, value.CommandIndex, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, value.Argument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FixedCommandKeyboardCustomization value)
    where OpenXmlElementType: DXOW.FixedCommandKeyboardCustomization, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.FixedCommandKeyboardCustomization openXmlElement, DMW.FixedCommandKeyboardCustomization value)
  {
    SetCommandName(openXmlElement, value?.CommandName);
    SetCommandIndex(openXmlElement, value?.CommandIndex);
    SetArgument(openXmlElement, value?.Argument);
  }
}
