using DocumentModel.Drawings.ChartDrawings;
using FormatOverrides = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the FormatOverrides Class.
/// </summary>
public static class FormatOverridesConverter
{
  public static Collection<FormatOverride>? GetItems(FormatOverrides? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<FormatOverride>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>())
      {
        var newItem = FormatOverrideConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(FormatOverrides? openXmlElement, Collection<FormatOverride>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = FormatOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.FormatOverrides? CreateModelElement(FormatOverrides? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.FormatOverrides();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.FormatOverrides? value)
    where OpenXmlElementType : FormatOverrides, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}