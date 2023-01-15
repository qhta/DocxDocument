using DocumentFormat.OpenXml.Office.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the AllocatedCommand Class.
/// </summary>
public static class AllocatedCommandConverter
{
  /// <summary>
  ///   argValue
  /// </summary>
  public static String? GetArgumentValue(AllocatedCommand? openXmlElement)
  {
    return openXmlElement?.ArgumentValue?.Value;
  }

  public static void SetArgumentValue(AllocatedCommand? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ArgumentValue = new StringValue { Value = value };
      else
        openXmlElement.ArgumentValue = null;
  }

  /// <summary>
  ///   fciBasedOn
  /// </summary>
  public static String? GetCommandBasedOn(AllocatedCommand? openXmlElement)
  {
    return openXmlElement?.CommandBasedOn?.Value;
  }

  public static void SetCommandBasedOn(AllocatedCommand? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CommandBasedOn = new StringValue { Value = value };
      else
        openXmlElement.CommandBasedOn = null;
  }

  /// <summary>
  ///   fciIndexBasedOn
  /// </summary>
  public static Byte[]? GetCommandIndexBasedOn(AllocatedCommand? openXmlElement)
  {
    if (openXmlElement?.CommandIndexBasedOn?.Value != null)
      return Convert.FromHexString(openXmlElement.CommandIndexBasedOn.Value);
    return null;
  }

  public static void SetCommandIndexBasedOn(AllocatedCommand? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.CommandIndexBasedOn = Convert.ToHexString(value);
      else
        openXmlElement.CommandIndexBasedOn = null;
    }
  }

  /// <summary>
  ///   acdName
  /// </summary>
  public static String? GetAcceleratorName(AllocatedCommand? openXmlElement)
  {
    return openXmlElement?.AcceleratorName?.Value;
  }

  public static void SetAcceleratorName(AllocatedCommand? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AcceleratorName = new StringValue { Value = value };
      else
        openXmlElement.AcceleratorName = null;
  }

  public static DocumentModel.Wordprocessing.AllocatedCommand? CreateModelElement(AllocatedCommand? openXmlElement)
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
    where OpenXmlElementType : AllocatedCommand, new()
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