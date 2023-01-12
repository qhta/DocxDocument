namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public static class EmbeddedWavAudioFileTypeConverter
{
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  public static String? GetEmbed(DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType? openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }
  
  public static void SetEmbed(DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Embed = new StringValue { Value = value };
      else
        openXmlElement.Embed = null;
  }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Recognized Built-In Sound
  /// </summary>
  public static Boolean? GetBuiltIn(DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType? openXmlElement)
  {
    return openXmlElement?.BuiltIn?.Value;
  }
  
  public static void SetBuiltIn(DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BuiltIn = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.BuiltIn = null;
  }
  
  public static DocumentModel.Drawings.EmbeddedWavAudioFileType? CreateModelElement(DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EmbeddedWavAudioFileType();
      value.Embed = GetEmbed(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.BuiltIn = GetBuiltIn(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EmbeddedWavAudioFileType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType, new()
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
