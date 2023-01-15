using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Copyrights Class.
/// </summary>
public static class CopyrightsConverter
{
  public static Collection<String>? GetCopyrightXsdstrings(Copyrights? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<String>();
      foreach (var item in openXmlElement.Elements<CopyrightXsdstring>())
      {
        var newItem = StringValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((string)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCopyrightXsdstrings(Copyrights? openXmlElement, Collection<String>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<CopyrightXsdstring>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<CopyrightXsdstring>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.Copyrights? CreateModelElement(Copyrights? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Copyrights();
      value.CopyrightXsdstrings = GetCopyrightXsdstrings(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Copyrights? value)
    where OpenXmlElementType : Copyrights, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCopyrightXsdstrings(openXmlElement, value?.CopyrightXsdstrings);
      return openXmlElement;
    }
    return default;
  }
}