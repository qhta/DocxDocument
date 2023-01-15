using DocumentModel.Drawings;
using CustomDash = DocumentFormat.OpenXml.Drawing.CustomDash;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Custom Dash.
/// </summary>
public static class CustomDashConverter
{
  public static Collection<DashStop>? GetDashStops(CustomDash? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DashStop>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.DashStop>())
      {
        var newItem = DashStopConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDashStops(CustomDash? openXmlElement, Collection<DashStop>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.DashStop>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DashStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.DashStop>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.CustomDash? CreateModelElement(CustomDash? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CustomDash();
      value.DashStops = GetDashStops(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CustomDash? value)
    where OpenXmlElementType : CustomDash, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDashStops(openXmlElement, value?.DashStops);
      return openXmlElement;
    }
    return default;
  }
}