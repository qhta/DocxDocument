namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the EmbeddedWavAudioFileType Class converter from/to OpenXml.
///</summary>
public static class EmbeddedWavAudioFileTypeConverter
{
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  private static String? GetEmbed(DXDraw.EmbeddedWavAudioFileType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXDraw.EmbeddedWavAudioFileType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXDraw.EmbeddedWavAudioFileType openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  private static String? GetName(DXDraw.EmbeddedWavAudioFileType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDraw.EmbeddedWavAudioFileType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDraw.EmbeddedWavAudioFileType openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
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
  
  public static DocumentModel.Drawings.EmbeddedWavAudioFileType? CreateModelElement(DXDraw.EmbeddedWavAudioFileType? openXmlElement)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EmbeddedWavAudioFileType value)
    where OpenXmlElementType: DXDraw.EmbeddedWavAudioFileType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.EmbeddedWavAudioFileType openXmlElement, DMDraws.EmbeddedWavAudioFileType value)
  {
    SetEmbed(openXmlElement, value?.Embed);
    SetName(openXmlElement, value?.Name);
    SetBuiltIn(openXmlElement, value?.BuiltIn);
  }
}
