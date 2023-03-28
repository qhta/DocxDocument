namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryFilterExceptions Class converter from/to OpenXml.
///</summary>
public static class CategoryFilterExceptionsConverter
{
  private static DMDrawsCharts.CategoryFilterException? GetCategoryFilterException(DXO2013DrawChart.CategoryFilterExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterException>();
    if (element != null)
      return DMXDrawsCharts.CategoryFilterExceptionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryFilterException(DXO2013DrawChart.CategoryFilterExceptions openXmlElement, DMDrawsCharts.CategoryFilterException? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryFilterExceptionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.CategoryFilterException>(), value, diffs, objName);
  }
  
  private static void SetCategoryFilterException(DXO2013DrawChart.CategoryFilterExceptions openXmlElement, DMDrawsCharts.CategoryFilterException? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.CategoryFilterException>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.CategoryFilterExceptionConverter.CreateOpenXmlElement<DXO2013DrawChart.CategoryFilterException>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryFilterExceptions? CreateModelElement(DXO2013DrawChart.CategoryFilterExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryFilterExceptions();
      value.CategoryFilterException = GetCategoryFilterException(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.CategoryFilterExceptions? openXmlElement, DMDrawsCharts.CategoryFilterExceptions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCategoryFilterException(openXmlElement, value.CategoryFilterException, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CategoryFilterExceptions value)
    where OpenXmlElementType: DXO2013DrawChart.CategoryFilterExceptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.CategoryFilterExceptions openXmlElement, DMDrawsCharts.CategoryFilterExceptions value)
  {
    SetCategoryFilterException(openXmlElement, value?.CategoryFilterException);
  }
}
