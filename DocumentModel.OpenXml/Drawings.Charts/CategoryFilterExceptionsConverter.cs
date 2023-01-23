namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryFilterExceptions Class.
/// </summary>
public static class CategoryFilterExceptionsConverter
{
  private static DMDrawsCharts.CategoryFilterException? GetCategoryFilterException(DXO2013DrawChart.CategoryFilterExceptions openXmlElement)
  {
    return DMXDrawsCharts.CategoryFilterExceptionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterException>());
  }
  
  private static bool CmpCategoryFilterException(DXO2013DrawChart.CategoryFilterExceptions openXmlElement, DMDrawsCharts.CategoryFilterException? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryFilterExceptionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.CategoryFilterException>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsCharts.CategoryFilterExceptions? CreateModelElement(DXO2013DrawChart.CategoryFilterExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.CategoryFilterExceptions();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CategoryFilterExceptions? value)
    where OpenXmlElementType: DXO2013DrawChart.CategoryFilterExceptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCategoryFilterException(openXmlElement, value?.CategoryFilterException);
      return openXmlElement;
    }
    return default;
  }
}
