using DocumentFormat.OpenXml.Wordprocessing;
using LevelOverride = DocumentModel.Wordprocessing.LevelOverride;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Numbering Definition Instance.
/// </summary>
public static class NumberingInstanceConverter
{
  /// <summary>
  ///   numId
  /// </summary>
  public static Int32? GetNumberID(NumberingInstance? openXmlElement)
  {
    return openXmlElement?.NumberID?.Value;
  }

  public static void SetNumberID(NumberingInstance? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NumberID = value;
  }

  /// <summary>
  ///   durableId
  /// </summary>
  public static Int32? GetDurableId(NumberingInstance? openXmlElement)
  {
    return openXmlElement?.DurableId?.Value;
  }

  public static void SetDurableId(NumberingInstance? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DurableId = value;
  }

  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  public static Int32? GetAbstractNumId(NumberingInstance? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AbstractNumId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAbstractNumId(NumberingInstance? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AbstractNumId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new AbstractNumId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<LevelOverride>? GetLevelOverrides(NumberingInstance? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LevelOverride>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>())
      {
        var newItem = LevelOverrideConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLevelOverrides(NumberingInstance? openXmlElement, Collection<LevelOverride>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LevelOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.NumberingInstance? CreateModelElement(NumberingInstance? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingInstance();
      value.NumberID = GetNumberID(openXmlElement);
      value.DurableId = GetDurableId(openXmlElement);
      value.AbstractNumId = GetAbstractNumId(openXmlElement);
      value.LevelOverrides = GetLevelOverrides(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingInstance? value)
    where OpenXmlElementType : NumberingInstance, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberID(openXmlElement, value?.NumberID);
      SetDurableId(openXmlElement, value?.DurableId);
      SetAbstractNumId(openXmlElement, value?.AbstractNumId);
      SetLevelOverrides(openXmlElement, value?.LevelOverrides);
      return openXmlElement;
    }
    return default;
  }
}