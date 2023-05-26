namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public static class AudioCDTimeTypeConverter
{
  /// <summary>
  /// Track
  /// </summary>
  private static Byte? GetTrack(DXD.AudioCDTimeType openXmlElement)
  {
    return openXmlElement?.Track?.Value;
  }
  
  private static bool CmpTrack(DXD.AudioCDTimeType openXmlElement, Byte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Track?.Value == value) return true;
    diffs?.Add(objName, "Track", openXmlElement?.Track?.Value, value);
    return false;
  }
  
  private static void SetTrack(DXD.AudioCDTimeType openXmlElement, Byte? value)
  {
    openXmlElement.Track = value;
  }
  
  /// <summary>
  /// Time
  /// </summary>
  private static UInt32? GetTime(DXD.AudioCDTimeType openXmlElement)
  {
    return openXmlElement?.Time?.Value;
  }
  
  private static bool CmpTime(DXD.AudioCDTimeType openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Time?.Value == value) return true;
    diffs?.Add(objName, "Time", openXmlElement?.Time?.Value, value);
    return false;
  }
  
  private static void SetTime(DXD.AudioCDTimeType openXmlElement, UInt32? value)
  {
    openXmlElement.Time = value;
  }
  
  public static DocumentModel.Drawings.AudioCDTimeType? CreateModelElement(DXD.AudioCDTimeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AudioCDTimeType();
      value.Track = GetTrack(openXmlElement);
      value.Time = GetTime(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AudioCDTimeType? openXmlElement, DMD.AudioCDTimeType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTrack(openXmlElement, value.Track, diffs, objName, propName))
        ok = false;
      if (!CmpTime(openXmlElement, value.Time, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AudioCDTimeType value)
    where OpenXmlElementType: DXD.AudioCDTimeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AudioCDTimeType openXmlElement, DMD.AudioCDTimeType value)
  {
    SetTrack(openXmlElement, value?.Track);
    SetTime(openXmlElement, value?.Time);
  }
}
