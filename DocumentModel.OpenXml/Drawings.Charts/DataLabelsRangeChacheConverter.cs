using DocumentFormat.OpenXml.Drawing.Charts;
using DataLabelsRangeChache = DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache;
using StrDataExtensionList = DocumentModel.Drawings.Charts.StrDataExtensionList;
using StringPoint = DocumentModel.Drawings.Charts.StringPoint;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DataLabelsRangeChache Class.
/// </summary>
public static class DataLabelsRangeChacheConverter
{
  public static UInt32? GetPointCount(DataLabelsRangeChache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPointCount(DataLabelsRangeChache? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PointCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PointCount { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<StringPoint>? GetStringPoints(DataLabelsRangeChache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StringPoint>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>())
      {
        var newItem = StringPointConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStringPoints(DataLabelsRangeChache? openXmlElement, Collection<StringPoint>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StringPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static StrDataExtensionList? GetStrDataExtensionList(DataLabelsRangeChache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
    if (itemElement != null)
      return StrDataExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStrDataExtensionList(DataLabelsRangeChache? openXmlElement, StrDataExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrDataExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DataLabelsRangeChache? CreateModelElement(DataLabelsRangeChache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelsRangeChache();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataLabelsRangeChache? value)
    where OpenXmlElementType : DataLabelsRangeChache, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointCount(openXmlElement, value?.PointCount);
      SetStringPoints(openXmlElement, value?.StringPoints);
      SetStrDataExtensionList(openXmlElement, value?.StrDataExtensionList);
      return openXmlElement;
    }
    return default;
  }
}