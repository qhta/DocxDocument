namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Indentation Class.
/// </summary>
public static class IndentationConverter
{
  /// <summary>
  /// Left Indentation
  /// </summary>
  private static String? GetLeft(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  private static bool CmpLeft(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Left?.Value == value;
  }
  
  private static void SetLeft(DXW.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Left = new StringValue { Value = value };
    else
      openXmlElement.Left = null;
  }
  
  /// <summary>
  /// start, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetStart(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.Start?.Value;
  }
  
  private static bool CmpStart(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Start?.Value == value;
  }
  
  private static void SetStart(DXW.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Start = new StringValue { Value = value };
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// Left Indentation in Character Units
  /// </summary>
  private static Int32? GetLeftChars(DXW.Indentation openXmlElement)
  {
    return openXmlElement.LeftChars?.Value;
  }
  
  private static bool CmpLeftChars(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.LeftChars?.Value == value;
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
    return openXmlElement.StartCharacters?.Value;
  }
  
  private static bool CmpStartCharacters(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.StartCharacters?.Value == value;
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
    return openXmlElement?.Right?.Value;
  }
  
  private static bool CmpRight(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Right?.Value == value;
  }
  
  private static void SetRight(DXW.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Right = new StringValue { Value = value };
    else
      openXmlElement.Right = null;
  }
  
  /// <summary>
  /// end, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetEnd(DXW.Indentation openXmlElement)
  {
    return openXmlElement?.End?.Value;
  }
  
  private static bool CmpEnd(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.End?.Value == value;
  }
  
  private static void SetEnd(DXW.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.End = new StringValue { Value = value };
    else
      openXmlElement.End = null;
  }
  
  /// <summary>
  /// Right Indentation in Character Units
  /// </summary>
  private static Int32? GetRightChars(DXW.Indentation openXmlElement)
  {
    return openXmlElement.RightChars?.Value;
  }
  
  private static bool CmpRightChars(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.RightChars?.Value == value;
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
    return openXmlElement.EndCharacters?.Value;
  }
  
  private static bool CmpEndCharacters(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.EndCharacters?.Value == value;
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
    return openXmlElement?.Hanging?.Value;
  }
  
  private static bool CmpHanging(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Hanging?.Value == value;
  }
  
  private static void SetHanging(DXW.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Hanging = new StringValue { Value = value };
    else
      openXmlElement.Hanging = null;
  }
  
  /// <summary>
  /// Indentation Removed From First Line in Character Units
  /// </summary>
  private static Int32? GetHangingChars(DXW.Indentation openXmlElement)
  {
    return openXmlElement.HangingChars?.Value;
  }
  
  private static bool CmpHangingChars(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.HangingChars?.Value == value;
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
    return openXmlElement?.FirstLine?.Value;
  }
  
  private static bool CmpFirstLine(DXW.Indentation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FirstLine?.Value == value;
  }
  
  private static void SetFirstLine(DXW.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FirstLine = new StringValue { Value = value };
    else
      openXmlElement.FirstLine = null;
  }
  
  /// <summary>
  /// Additional First Line Indentation in Character Units
  /// </summary>
  private static Int32? GetFirstLineChars(DXW.Indentation openXmlElement)
  {
    return openXmlElement.FirstLineChars?.Value;
  }
  
  private static bool CmpFirstLineChars(DXW.Indentation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.FirstLineChars?.Value == value;
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Indentation? value)
    where OpenXmlElementType: DXW.Indentation, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
