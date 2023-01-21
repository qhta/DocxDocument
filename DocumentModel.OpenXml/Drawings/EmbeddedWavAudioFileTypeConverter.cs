namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public static class EmbeddedWavAudioFileTypeConverter
{
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  private static String? GetEmbed(DXDraw.EmbeddedWavAudioFileType openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }
  
  private static void SetEmbed(DXDraw.EmbeddedWavAudioFileType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Embed = new StringValue { Value = value };
    else
      openXmlElement.Embed = null;
  }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  private static String? GetName(DXDraw.EmbeddedWavAudioFileType openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDraw.EmbeddedWavAudioFileType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Recognized Built-In Sound
  /// </summary>
  private static Boolean? GetBuiltIn(DXDraw.EmbeddedWavAudioFileType openXmlElement)
  {
    return openXmlElement?.BuiltIn?.Value;
  }
  
  private static void SetBuiltIn(DXDraw.EmbeddedWavAudioFileType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BuiltIn = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BuiltIn = null;
  }
  
  public static DMDraws.EmbeddedWavAudioFileType? CreateModelElement(DXDraw.EmbeddedWavAudioFileType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.EmbeddedWavAudioFileType();
      value.Embed = GetEmbed(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.BuiltIn = GetBuiltIn(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EmbeddedWavAudioFileType? value)
    where OpenXmlElementType: DXDraw.EmbeddedWavAudioFileType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEmbed(openXmlElement, value?.Embed);
      SetName(openXmlElement, value?.Name);
      SetBuiltIn(openXmlElement, value?.BuiltIn);
      return openXmlElement;
    }
    return default;
  }
}
