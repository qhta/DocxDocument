namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Indentation Class converter from/to OpenXml.
///</summary>
public static class IndentationConverter
{
  /// <summary>
  /// Left Indentation
  /// </summary>
  private static String? GetLeft(DXW.Indentation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Left);
  }
  
  private static bool CmpLeft(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Left, value, diffs, objName, "Left");
  }
  
  private static void SetLeft(DXW.Indentation openXmlElement, String? value)
  {
    openXmlElement.Left = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// start, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetStart(DXW.Indentation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Start);
  }
  
  private static bool CmpStart(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Start, value, diffs, objName, "Start");
  }
  
  private static void SetStart(DXW.Indentation openXmlElement, String? value)
  {
    openXmlElement.Start = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Left Indentation in Character Units
  /// </summary>
  private static Int32? GetLeftChars(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.LeftChars?.Value;
  }
  
  private static bool CmpLeftChars(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LeftChars?.Value == value) return true;
    diffs?.Add(objName, "LeftChars", openXmlElement?.LeftChars?.Value, value);
    return false;
  }
  
  private static void SetLeftChars(DXW.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.LeftChars = value;
  }
  
  /// <summary>
  /// startChars, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStartCharacters(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.StartCharacters?.Value;
  }
  
  private static bool CmpStartCharacters(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StartCharacters?.Value == value) return true;
    diffs?.Add(objName, "StartCharacters", openXmlElement?.StartCharacters?.Value, value);
    return false;
  }
  
  private static void SetStartCharacters(DXW.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.StartCharacters = value;
  }
  
  /// <summary>
  /// Right Indentation
  /// </summary>
  private static String? GetRight(DXW.Indentation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Right);
  }
  
  private static bool CmpRight(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Right, value, diffs, objName, "Right");
  }
  
  private static void SetRight(DXW.Indentation openXmlElement, String? value)
  {
    openXmlElement.Right = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// end, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetEnd(DXW.Indentation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.End);
  }
  
  private static bool CmpEnd(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.End, value, diffs, objName, "End");
  }
  
  private static void SetEnd(DXW.Indentation openXmlElement, String? value)
  {
    openXmlElement.End = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Right Indentation in Character Units
  /// </summary>
  private static Int32? GetRightChars(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.RightChars?.Value;
  }
  
  private static bool CmpRightChars(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RightChars?.Value == value) return true;
    diffs?.Add(objName, "RightChars", openXmlElement?.RightChars?.Value, value);
    return false;
  }
  
  private static void SetRightChars(DXW.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.RightChars = value;
  }
  
  /// <summary>
  /// endChars, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetEndCharacters(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.EndCharacters?.Value;
  }
  
  private static bool CmpEndCharacters(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EndCharacters?.Value == value) return true;
    diffs?.Add(objName, "EndCharacters", openXmlElement?.EndCharacters?.Value, value);
    return false;
  }
  
  private static void SetEndCharacters(DXW.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.EndCharacters = value;
  }
  
  /// <summary>
  /// Indentation Removed from First Line
  /// </summary>
  private static String? GetHanging(DXW.Indentation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Hanging);
  }
  
  private static bool CmpHanging(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Hanging, value, diffs, objName, "Hanging");
  }
  
  private static void SetHanging(DXW.Indentation openXmlElement, String? value)
  {
    openXmlElement.Hanging = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Indentation Removed From First Line in Character Units
  /// </summary>
  private static Int32? GetHangingChars(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.HangingChars?.Value;
  }
  
  private static bool CmpHangingChars(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HangingChars?.Value == value) return true;
    diffs?.Add(objName, "HangingChars", openXmlElement?.HangingChars?.Value, value);
    return false;
  }
  
  private static void SetHangingChars(DXW.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.HangingChars = value;
  }
  
  /// <summary>
  /// Additional First Line Indentation
  /// </summary>
  private static String? GetFirstLine(DXW.Indentation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FirstLine);
  }
  
  private static bool CmpFirstLine(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FirstLine, value, diffs, objName, "FirstLine");
  }
  
  private static void SetFirstLine(DXW.Indentation openXmlElement, String? value)
  {
    openXmlElement.FirstLine = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Additional First Line Indentation in Character Units
  /// </summary>
  private static Int32? GetFirstLineChars(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.FirstLineChars?.Value;
  }
  
  private static bool CmpFirstLineChars(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FirstLineChars?.Value == value) return true;
    diffs?.Add(objName, "FirstLineChars", openXmlElement?.FirstLineChars?.Value, value);
    return false;
  }
  
  private static void SetFirstLineChars(DXW.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.FirstLineChars = value;
  }
  
  public static DMW.Indentation? CreateModelElement(DXW.Indentation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Indentation();
      value.Left = GetLeft(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.LeftChars = GetLeftChars(openXmlElement);
      value.StartCharacters = GetStartCharacters(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.End = GetEnd(openXmlElement);
      value.RightChars = GetRightChars(openXmlElement);
      value.EndCharacters = GetEndCharacters(openXmlElement);
      value.Hanging = GetHanging(openXmlElement);
      value.HangingChars = GetHangingChars(openXmlElement);
      value.FirstLine = GetFirstLine(openXmlElement);
      value.FirstLineChars = GetFirstLineChars(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Indentation? openXmlElement, DMW.Indentation? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName))
        ok = false;
      if (!CmpStart(openXmlElement, value.Start, diffs, objName))
        ok = false;
      if (!CmpLeftChars(openXmlElement, value.LeftChars, diffs, objName))
        ok = false;
      if (!CmpStartCharacters(openXmlElement, value.StartCharacters, diffs, objName))
        ok = false;
      if (!CmpRight(openXmlElement, value.Right, diffs, objName))
        ok = false;
      if (!CmpEnd(openXmlElement, value.End, diffs, objName))
        ok = false;
      if (!CmpRightChars(openXmlElement, value.RightChars, diffs, objName))
        ok = false;
      if (!CmpEndCharacters(openXmlElement, value.EndCharacters, diffs, objName))
        ok = false;
      if (!CmpHanging(openXmlElement, value.Hanging, diffs, objName))
        ok = false;
      if (!CmpHangingChars(openXmlElement, value.HangingChars, diffs, objName))
        ok = false;
      if (!CmpFirstLine(openXmlElement, value.FirstLine, diffs, objName))
        ok = false;
      if (!CmpFirstLineChars(openXmlElement, value.FirstLineChars, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Indentation value)
    where OpenXmlElementType: DXW.Indentation, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Indentation openXmlElement, DMW.Indentation value)
  {
    SetLeft(openXmlElement, value?.Left);
    SetStart(openXmlElement, value?.Start);
    SetLeftChars(openXmlElement, value?.LeftChars);
    SetStartCharacters(openXmlElement, value?.StartCharacters);
    SetRight(openXmlElement, value?.Right);
    SetEnd(openXmlElement, value?.End);
    SetRightChars(openXmlElement, value?.RightChars);
    SetEndCharacters(openXmlElement, value?.EndCharacters);
    SetHanging(openXmlElement, value?.Hanging);
    SetHangingChars(openXmlElement, value?.HangingChars);
    SetFirstLine(openXmlElement, value?.FirstLine);
    SetFirstLineChars(openXmlElement, value?.FirstLineChars);
  }
}
