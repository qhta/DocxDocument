using DocumentFormat.OpenXml.Wordprocessing;
using NumberingChange = DocumentModel.Wordprocessing.NumberingChange;
using TrackChangeType = DocumentModel.Wordprocessing.TrackChangeType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the NumberingProperties Class.
/// </summary>
public static class NumberingPropertiesConverter
{
  /// <summary>
  ///   Numbering Level Reference.
  /// </summary>
  public static Int32? GetNumberingLevelReference(NumberingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingLevelReference>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberingLevelReference(NumberingProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingLevelReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumberingLevelReference { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numbering Definition Instance Reference.
  /// </summary>
  public static Int32? GetNumberingId(NumberingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberingId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberingId(NumberingProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumberingId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Previous Paragraph Numbering Properties.
  /// </summary>
  public static NumberingChange? GetNumberingChange(NumberingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
    if (itemElement != null)
      return NumberingChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingChange(NumberingProperties? openXmlElement, NumberingChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Inserted Numbering Properties.
  /// </summary>
  public static TrackChangeType? GetInserted(NumberingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Inserted>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInserted(NumberingProperties? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Inserted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<Inserted>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.NumberingProperties? CreateModelElement(NumberingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingProperties();
      value.NumberingLevelReference = GetNumberingLevelReference(openXmlElement);
      value.NumberingId = GetNumberingId(openXmlElement);
      value.NumberingChange = GetNumberingChange(openXmlElement);
      value.Inserted = GetInserted(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingProperties? value)
    where OpenXmlElementType : NumberingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberingLevelReference(openXmlElement, value?.NumberingLevelReference);
      SetNumberingId(openXmlElement, value?.NumberingId);
      SetNumberingChange(openXmlElement, value?.NumberingChange);
      SetInserted(openXmlElement, value?.Inserted);
      return openXmlElement;
    }
    return default;
  }
}