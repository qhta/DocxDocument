using DocumentFormat.OpenXml.Wordprocessing;
using Level = DocumentModel.Wordprocessing.Level;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the LevelOverride Class.
/// </summary>
public static class LevelOverrideConverter
{
  /// <summary>
  ///   Numbering Level ID
  /// </summary>
  public static Int32? GetLevelIndex(LevelOverride? openXmlElement)
  {
    return openXmlElement?.LevelIndex?.Value;
  }

  public static void SetLevelIndex(LevelOverride? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LevelIndex = value;
  }

  /// <summary>
  ///   Numbering Level Starting Value Override.
  /// </summary>
  public static Int32? GetStartOverrideNumberingValue(LevelOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartOverrideNumberingValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetStartOverrideNumberingValue(LevelOverride? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StartOverrideNumberingValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new StartOverrideNumberingValue { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Level Override Definition.
  /// </summary>
  public static Level? GetLevel(LevelOverride? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Level>();
    if (itemElement != null)
      return LevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel(LevelOverride? openXmlElement, Level? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Level>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Level>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.LevelOverride? CreateModelElement(LevelOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LevelOverride();
      value.LevelIndex = GetLevelIndex(openXmlElement);
      value.StartOverrideNumberingValue = GetStartOverrideNumberingValue(openXmlElement);
      value.Level = GetLevel(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LevelOverride? value)
    where OpenXmlElementType : LevelOverride, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLevelIndex(openXmlElement, value?.LevelIndex);
      SetStartOverrideNumberingValue(openXmlElement, value?.StartOverrideNumberingValue);
      SetLevel(openXmlElement, value?.Level);
      return openXmlElement;
    }
    return default;
  }
}