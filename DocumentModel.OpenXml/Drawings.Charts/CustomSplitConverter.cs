using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Custom Split.
/// </summary>
public static class CustomSplitConverter
{
  public static Collection<UInt32>? GetSecondPiePoints(CustomSplit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<UInt32>();
      foreach (var item in openXmlElement.Elements<SecondPiePoint>())
      {
        var newItem = UInt32ValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((UInt32)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSecondPiePoints(CustomSplit? openXmlElement, Collection<UInt32>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<SecondPiePoint>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = UInt32ValueConverter.CreateOpenXmlElement<SecondPiePoint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.CustomSplit? CreateModelElement(CustomSplit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CustomSplit();
      value.SecondPiePoints = GetSecondPiePoints(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CustomSplit? value)
    where OpenXmlElementType : CustomSplit, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSecondPiePoints(openXmlElement, value?.SecondPiePoints);
      return openXmlElement;
    }
    return default;
  }
}