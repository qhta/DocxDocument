using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Indentation Class.
/// </summary>
public static class IndentationConverter
{
  /// <summary>
  ///   Left Indentation
  /// </summary>
  public static String? GetLeft(Indentation? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }

  public static void SetLeft(Indentation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Left = new StringValue { Value = value };
      else
        openXmlElement.Left = null;
  }

  /// <summary>
  ///   start, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetStart(Indentation? openXmlElement)
  {
    return openXmlElement?.Start?.Value;
  }

  public static void SetStart(Indentation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Start = new StringValue { Value = value };
      else
        openXmlElement.Start = null;
  }

  /// <summary>
  ///   Left Indentation in Character Units
  /// </summary>
  public static Int32? GetLeftChars(Indentation? openXmlElement)
  {
    return openXmlElement?.LeftChars?.Value;
  }

  public static void SetLeftChars(Indentation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftChars = value;
  }

  /// <summary>
  ///   startChars, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetStartCharacters(Indentation? openXmlElement)
  {
    return openXmlElement?.StartCharacters?.Value;
  }

  public static void SetStartCharacters(Indentation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartCharacters = value;
  }

  /// <summary>
  ///   Right Indentation
  /// </summary>
  public static String? GetRight(Indentation? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }

  public static void SetRight(Indentation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Right = new StringValue { Value = value };
      else
        openXmlElement.Right = null;
  }

  /// <summary>
  ///   end, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetEnd(Indentation? openXmlElement)
  {
    return openXmlElement?.End?.Value;
  }

  public static void SetEnd(Indentation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.End = new StringValue { Value = value };
      else
        openXmlElement.End = null;
  }

  /// <summary>
  ///   Right Indentation in Character Units
  /// </summary>
  public static Int32? GetRightChars(Indentation? openXmlElement)
  {
    return openXmlElement?.RightChars?.Value;
  }

  public static void SetRightChars(Indentation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightChars = value;
  }

  /// <summary>
  ///   endChars, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetEndCharacters(Indentation? openXmlElement)
  {
    return openXmlElement?.EndCharacters?.Value;
  }

  public static void SetEndCharacters(Indentation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndCharacters = value;
  }

  /// <summary>
  ///   Indentation Removed from First Line
  /// </summary>
  public static String? GetHanging(Indentation? openXmlElement)
  {
    return openXmlElement?.Hanging?.Value;
  }

  public static void SetHanging(Indentation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hanging = new StringValue { Value = value };
      else
        openXmlElement.Hanging = null;
  }

  /// <summary>
  ///   Indentation Removed From First Line in Character Units
  /// </summary>
  public static Int32? GetHangingChars(Indentation? openXmlElement)
  {
    return openXmlElement?.HangingChars?.Value;
  }

  public static void SetHangingChars(Indentation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HangingChars = value;
  }

  /// <summary>
  ///   Additional First Line Indentation
  /// </summary>
  public static String? GetFirstLine(Indentation? openXmlElement)
  {
    return openXmlElement?.FirstLine?.Value;
  }

  public static void SetFirstLine(Indentation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FirstLine = new StringValue { Value = value };
      else
        openXmlElement.FirstLine = null;
  }

  /// <summary>
  ///   Additional First Line Indentation in Character Units
  /// </summary>
  public static Int32? GetFirstLineChars(Indentation? openXmlElement)
  {
    return openXmlElement?.FirstLineChars?.Value;
  }

  public static void SetFirstLineChars(Indentation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstLineChars = value;
  }

  public static DocumentModel.Wordprocessing.Indentation? CreateModelElement(Indentation? openXmlElement)
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
    where OpenXmlElementType : Indentation, new()
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