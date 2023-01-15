using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Space Before.
/// </summary>
public static class SpaceBeforeConverter
{
  public static Int32? GetSpacingPercent(SpaceBefore? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SpacingPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSpacingPercent(SpaceBefore? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SpacingPercent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SpacingPercent { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetSpacingPoints(SpaceBefore? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SpacingPoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSpacingPoints(SpaceBefore? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SpacingPoints>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SpacingPoints { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.SpaceBefore? CreateModelElement(SpaceBefore? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SpaceBefore();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SpaceBefore? value)
    where OpenXmlElementType : SpaceBefore, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSpacingPercent(openXmlElement, value?.SpacingPercent);
      SetSpacingPoints(openXmlElement, value?.SpacingPoints);
      return openXmlElement;
    }
    return default;
  }
}