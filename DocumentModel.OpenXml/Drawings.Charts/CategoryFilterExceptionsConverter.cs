namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryFilterExceptions Class.
/// </summary>
public static class CategoryFilterExceptionsConverter
{
  private static DMDC.CategoryFilterException? GetCategoryFilterException(DXO13DC.CategoryFilterExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.CategoryFilterException>();
    if (element != null)
      return DMXDC.CategoryFilterExceptionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryFilterException(DXO13DC.CategoryFilterExceptions openXmlElement, DMDC.CategoryFilterException? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.CategoryFilterExceptionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.CategoryFilterException>(), value, diffs, objName, propName);
  }
  
  private static void SetCategoryFilterException(DXO13DC.CategoryFilterExceptions openXmlElement, DMDC.CategoryFilterException? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.CategoryFilterException>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.CategoryFilterExceptionConverter.CreateOpenXmlElement<DXO13DC.CategoryFilterException>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryFilterExceptions? CreateModelElement(DXO13DC.CategoryFilterExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryFilterExceptions();
      value.CategoryFilterException = GetCategoryFilterException(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.CategoryFilterExceptions? openXmlElement, DMDC.CategoryFilterExceptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCategoryFilterException(openXmlElement, value.CategoryFilterException, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.CategoryFilterExceptions value)
    where OpenXmlElementType: DXO13DC.CategoryFilterExceptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.CategoryFilterExceptions openXmlElement, DMDC.CategoryFilterExceptions value)
  {
    SetCategoryFilterException(openXmlElement, value?.CategoryFilterException);
  }
}
