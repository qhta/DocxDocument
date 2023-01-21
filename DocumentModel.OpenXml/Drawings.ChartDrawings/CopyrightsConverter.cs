namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Copyrights Class.
/// </summary>
public static class CopyrightsConverter
{
  private static Collection<String> GetCopyrightXsdstrings(DXO2016DrawChartDraw.Copyrights openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.CopyrightXsdstring>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    return collection;
  }
  
  private static void SetCopyrightXsdstrings(DXO2016DrawChartDraw.Copyrights openXmlElement, Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.CopyrightXsdstring>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.CopyrightXsdstring>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.Copyrights? CreateModelElement(DXO2016DrawChartDraw.Copyrights? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Copyrights();
      value.CopyrightXsdstrings = GetCopyrightXsdstrings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Copyrights? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Copyrights, new()
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
