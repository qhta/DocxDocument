using DocumentModel.Drawings.Charts;
using CategoryFilterExceptions = DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the CategoryFilterExceptions Class.
/// </summary>
public static class CategoryFilterExceptionsConverter
{
  public static CategoryFilterException? GetCategoryFilterException(CategoryFilterExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>();
    if (itemElement != null)
      return CategoryFilterExceptionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCategoryFilterException(CategoryFilterExceptions? openXmlElement, CategoryFilterException? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryFilterExceptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.CategoryFilterExceptions? CreateModelElement(CategoryFilterExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryFilterExceptions();
      value.CategoryFilterException = GetCategoryFilterException(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CategoryFilterExceptions? value)
    where OpenXmlElementType : CategoryFilterExceptions, new()
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