namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public static class AllocatedCommandConverter
{
  /// <summary>
  /// argValue
  /// </summary>
  private static String? GetArgumentValue(DXOW.AllocatedCommand openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ArgumentValue);
  }
  
  private static bool CmpArgumentValue(DXOW.AllocatedCommand openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ArgumentValue, value, diffs, objName, "ArgumentValue");
  }
  
  private static void SetArgumentValue(DXOW.AllocatedCommand openXmlElement, String? value)
  {
    openXmlElement.ArgumentValue = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  private static String? GetCommandBasedOn(DXOW.AllocatedCommand openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CommandBasedOn);
  }
  
  private static bool CmpCommandBasedOn(DXOW.AllocatedCommand openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CommandBasedOn, value, diffs, objName, "CommandBasedOn");
  }
  
  private static void SetCommandBasedOn(DXOW.AllocatedCommand openXmlElement, String? value)
  {
    openXmlElement.CommandBasedOn = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  private static DM.HexChar? GetCommandIndexBasedOn(DXOW.AllocatedCommand openXmlElement)
  {
    if (openXmlElement?.CommandIndexBasedOn?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.CommandIndexBasedOn.Value);
    return null;
  }
  
  private static bool CmpCommandIndexBasedOn(DXOW.AllocatedCommand openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CommandIndexBasedOn?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.CommandIndexBasedOn.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.CommandIndexBasedOn?.Value == null && value == null) return true;
    diffs?.Add(objName, "CommandIndexBasedOn", openXmlElement?.CommandIndexBasedOn?.Value, value);
    return false;
  }
  
  private static void SetCommandIndexBasedOn(DXOW.AllocatedCommand openXmlElement, DM.HexChar? value)
  {
    if (value != null)
      openXmlElement.CommandIndexBasedOn = value.ToString();
    else
      openXmlElement.CommandIndexBasedOn = null;
  }
  
  /// <summary>
  /// acdName
  /// </summary>
  private static String? GetAcceleratorName(DXOW.AllocatedCommand openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AcceleratorName);
  }
  
  private static bool CmpAcceleratorName(DXOW.AllocatedCommand openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AcceleratorName, value, diffs, objName, "AcceleratorName");
  }
  
  private static void SetAcceleratorName(DXOW.AllocatedCommand openXmlElement, String? value)
  {
    openXmlElement.AcceleratorName = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.AllocatedCommand? CreateModelElement(DXOW.AllocatedCommand? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AllocatedCommand();
      value.ArgumentValue = GetArgumentValue(openXmlElement);
      value.CommandBasedOn = GetCommandBasedOn(openXmlElement);
      value.CommandIndexBasedOn = GetCommandIndexBasedOn(openXmlElement);
      value.AcceleratorName = GetAcceleratorName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.AllocatedCommand? openXmlElement, DMW.AllocatedCommand? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpArgumentValue(openXmlElement, value.ArgumentValue, diffs, objName))
        ok = false;
      if (!CmpCommandBasedOn(openXmlElement, value.CommandBasedOn, diffs, objName))
        ok = false;
      if (!CmpCommandIndexBasedOn(openXmlElement, value.CommandIndexBasedOn, diffs, objName))
        ok = false;
      if (!CmpAcceleratorName(openXmlElement, value.AcceleratorName, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AllocatedCommand value)
    where OpenXmlElementType: DXOW.AllocatedCommand, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.AllocatedCommand openXmlElement, DMW.AllocatedCommand value)
  {
    SetArgumentValue(openXmlElement, value?.ArgumentValue);
    SetCommandBasedOn(openXmlElement, value?.CommandBasedOn);
    SetCommandIndexBasedOn(openXmlElement, value?.CommandIndexBasedOn);
    SetAcceleratorName(openXmlElement, value?.AcceleratorName);
  }
}
