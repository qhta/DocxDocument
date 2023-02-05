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
  
  private static bool CmpEmbed(DXDraw.EmbeddedWavAudioFileType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Embed?.Value == value) return true;
    diffs?.Add(objName, "Embed", openXmlElement?.Embed?.Value, value);
    return false;
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
  
  private static bool CmpName(DXDraw.EmbeddedWavAudioFileType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
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
  
  private static bool CmpBuiltIn(DXDraw.EmbeddedWavAudioFileType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BuiltIn?.Value == value) return true;
    diffs?.Add(objName, "BuiltIn", openXmlElement?.BuiltIn?.Value, value);
    return false;
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
  
  public static bool CompareModelElement(DXDraw.EmbeddedWavAudioFileType? openXmlElement, DMDraws.EmbeddedWavAudioFileType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbed(openXmlElement, value.Embed, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpBuiltIn(openXmlElement, value.BuiltIn, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
