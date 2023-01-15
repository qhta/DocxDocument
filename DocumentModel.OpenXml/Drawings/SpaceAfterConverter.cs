using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Space After.
/// </summary>
public static class SpaceAfterConverter
{
  public static Int32? GetSpacingPercent(SpaceAfter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SpacingPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSpacingPercent(SpaceAfter? openXmlElement, Int32? value)
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

  public static Int32? GetSpacingPoints(SpaceAfter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SpacingPoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSpacingPoints(SpaceAfter? openXmlElement, Int32? value)
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

  public static DocumentModel.Drawings.SpaceAfter? CreateModelElement(SpaceAfter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SpaceAfter();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SpaceAfter? value)
    where OpenXmlElementType : SpaceAfter, new()
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