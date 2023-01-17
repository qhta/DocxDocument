namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Indentation Class.
/// </summary>
public static class IndentationConverter
{
  /// <summary>
  /// Left Indentation
  /// </summary>
  private static String? GetLeft(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  private static void SetLeft(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Left = new StringValue { Value = value };
    else
      openXmlElement.Left = null;
  }
  
  /// <summary>
  /// start, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetStart(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement?.Start?.Value;
  }
  
  private static void SetStart(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Start = new StringValue { Value = value };
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// Left Indentation in Character Units
  /// </summary>
  private static Int32? GetLeftChars(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement.LeftChars?.Value;
  }
  
  private static void SetLeftChars(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.LeftChars = value;
  }
  
  /// <summary>
  /// startChars, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStartCharacters(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement.StartCharacters?.Value;
  }
  
  private static void SetStartCharacters(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.StartCharacters = value;
  }
  
  /// <summary>
  /// Right Indentation
  /// </summary>
  private static String? GetRight(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  private static void SetRight(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Right = new StringValue { Value = value };
    else
      openXmlElement.Right = null;
  }
  
  /// <summary>
  /// end, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetEnd(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement?.End?.Value;
  }
  
  private static void SetEnd(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.End = new StringValue { Value = value };
    else
      openXmlElement.End = null;
  }
  
  /// <summary>
  /// Right Indentation in Character Units
  /// </summary>
  private static Int32? GetRightChars(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement.RightChars?.Value;
  }
  
  private static void SetRightChars(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.RightChars = value;
  }
  
  /// <summary>
  /// endChars, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetEndCharacters(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement.EndCharacters?.Value;
  }
  
  private static void SetEndCharacters(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.EndCharacters = value;
  }
  
  /// <summary>
  /// Indentation Removed from First Line
  /// </summary>
  private static String? GetHanging(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement?.Hanging?.Value;
  }
  
  private static void SetHanging(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Hanging = new StringValue { Value = value };
    else
      openXmlElement.Hanging = null;
  }
  
  /// <summary>
  /// Indentation Removed From First Line in Character Units
  /// </summary>
  private static Int32? GetHangingChars(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement.HangingChars?.Value;
  }
  
  private static void SetHangingChars(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.HangingChars = value;
  }
  
  /// <summary>
  /// Additional First Line Indentation
  /// </summary>
  private static String? GetFirstLine(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement?.FirstLine?.Value;
  }
  
  private static void SetFirstLine(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FirstLine = new StringValue { Value = value };
    else
      openXmlElement.FirstLine = null;
  }
  
  /// <summary>
  /// Additional First Line Indentation in Character Units
  /// </summary>
  private static Int32? GetFirstLineChars(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement)
  {
    return openXmlElement.FirstLineChars?.Value;
  }
  
  private static void SetFirstLineChars(DocumentFormat.OpenXml.Wordprocessing.Indentation openXmlElement, Int32? value)
  {
    openXmlElement.FirstLineChars = value;
  }
  
  public static DocumentModel.Wordprocessing.Indentation? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Indentation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Indentation();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Indentation? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Indentation, new()
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
