namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public static class EmbeddedWavAudioFileTypeConverter
{
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  private static String? GetEmbed(DXD.EmbeddedWavAudioFileType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXD.EmbeddedWavAudioFileType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXD.EmbeddedWavAudioFileType openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  private static String? GetName(DXD.EmbeddedWavAudioFileType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXD.EmbeddedWavAudioFileType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXD.EmbeddedWavAudioFileType openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Recognized Built-In Sound
  /// </summary>
  private static Boolean? GetBuiltIn(DXD.EmbeddedWavAudioFileType openXmlElement)
  {
    return openXmlElement?.BuiltIn?.Value;
  }
  
  private static bool CmpBuiltIn(DXD.EmbeddedWavAudioFileType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BuiltIn?.Value == value) return true;
    diffs?.Add(objName, "BuiltIn", openXmlElement?.BuiltIn?.Value, value);
    return false;
  }
  
  private static void SetBuiltIn(DXD.EmbeddedWavAudioFileType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BuiltIn = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BuiltIn = null;
  }
  
  public static DocumentModel.Drawings.EmbeddedWavAudioFileType? CreateModelElement(DXD.EmbeddedWavAudioFileType? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.EmbeddedWavAudioFileType? openXmlElement, DMD.EmbeddedWavAudioFileType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.EmbeddedWavAudioFileType value)
    where OpenXmlElementType: DXD.EmbeddedWavAudioFileType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.EmbeddedWavAudioFileType openXmlElement, DMD.EmbeddedWavAudioFileType value)
  {
    SetEmbed(openXmlElement, value?.Embed);
    SetName(openXmlElement, value?.Name);
    SetBuiltIn(openXmlElement, value?.BuiltIn);
  }
}
