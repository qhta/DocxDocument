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
    return openXmlElement?.ArgumentValue?.Value;
  }
  
  private static void SetArgumentValue(DXOW.AllocatedCommand openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ArgumentValue = new StringValue { Value = value };
    else
      openXmlElement.ArgumentValue = null;
  }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  private static String? GetCommandBasedOn(DXOW.AllocatedCommand openXmlElement)
  {
    return openXmlElement?.CommandBasedOn?.Value;
  }
  
  private static void SetCommandBasedOn(DXOW.AllocatedCommand openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CommandBasedOn = new StringValue { Value = value };
    else
      openXmlElement.CommandBasedOn = null;
  }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  private static UInt16? GetCommandIndexBasedOn(DXOW.AllocatedCommand openXmlElement)
  {
    if (openXmlElement.CommandIndexBasedOn?.Value != null)
      return UInt16.Parse(openXmlElement.CommandIndexBasedOn.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCommandIndexBasedOn(DXOW.AllocatedCommand openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.CommandIndexBasedOn = ((UInt16)value).ToString("X4");
      else
        openXmlElement.CommandIndexBasedOn = null;
  }
  
  /// <summary>
  /// acdName
  /// </summary>
  private static String? GetAcceleratorName(DXOW.AllocatedCommand openXmlElement)
  {
    return openXmlElement?.AcceleratorName?.Value;
  }
  
  private static void SetAcceleratorName(DXOW.AllocatedCommand openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AcceleratorName = new StringValue { Value = value };
    else
      openXmlElement.AcceleratorName = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AllocatedCommand? value)
    where OpenXmlElementType: DXOW.AllocatedCommand, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetArgumentValue(openXmlElement, value?.ArgumentValue);
      SetCommandBasedOn(openXmlElement, value?.CommandBasedOn);
      SetCommandIndexBasedOn(openXmlElement, value?.CommandIndexBasedOn);
      SetAcceleratorName(openXmlElement, value?.AcceleratorName);
      return openXmlElement;
    }
    return default;
  }
}
