namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public static class AudioCDTimeTypeConverter
{
  /// <summary>
  /// Track
  /// </summary>
  private static Byte? GetTrack(DXDraw.AudioCDTimeType openXmlElement)
  {
    return openXmlElement?.Track?.Value;
  }
  
  private static bool CmpTrack(DXDraw.AudioCDTimeType openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Track?.Value == value) return true;
    diffs?.Add(objName, "Track", openXmlElement?.Track?.Value, value);
    return false;
  }
  
  private static void SetTrack(DXDraw.AudioCDTimeType openXmlElement, Byte? value)
  {
    openXmlElement.Track = value;
  }
  
  /// <summary>
  /// Time
  /// </summary>
  private static UInt32? GetTime(DXDraw.AudioCDTimeType openXmlElement)
  {
    return openXmlElement?.Time?.Value;
  }
  
  private static bool CmpTime(DXDraw.AudioCDTimeType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Time?.Value == value) return true;
    diffs?.Add(objName, "Time", openXmlElement?.Time?.Value, value);
    return false;
  }
  
  private static void SetTime(DXDraw.AudioCDTimeType openXmlElement, UInt32? value)
  {
    openXmlElement.Time = value;
  }
  
  public static DocumentModel.Drawings.AudioCDTimeType? CreateModelElement(DXDraw.AudioCDTimeType? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.AudioCDTimeType? openXmlElement, DMDraws.AudioCDTimeType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTrack(openXmlElement, value.Track, diffs, objName))
        ok = false;
      if (!CmpTime(openXmlElement, value.Time, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AudioCDTimeType value)
    where OpenXmlElementType: DXDraw.AudioCDTimeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AudioCDTimeType openXmlElement, DMDraws.AudioCDTimeType value)
  {
    SetTrack(openXmlElement, value?.Track);
    SetTime(openXmlElement, value?.Time);
    }
  }
