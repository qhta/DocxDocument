namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public static class CustomDashConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.DashStop>? GetDashStops(DocumentFormat.OpenXml.Drawing.CustomDash? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.DashStop>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.DashStop>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.DashStopConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetDashStops(DocumentFormat.OpenXml.Drawing.CustomDash? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.DashStop>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.DashStop>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.DashStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.DashStop>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.CustomDash? CreateModelElement(DocumentFormat.OpenXml.Drawing.CustomDash? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.CustomDash, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
