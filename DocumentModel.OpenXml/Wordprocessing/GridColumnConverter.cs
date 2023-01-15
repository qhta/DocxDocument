using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Grid Column Definition.
/// </summary>
public static class GridColumnConverter
{
  /// <summary>
  ///   Grid Column Width
  /// </summary>
  public static String? GetWidth(GridColumn? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(GridColumn? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Width = new StringValue { Value = value };
      else
        openXmlElement.Width = null;
  }

  public static DocumentModel.Wordprocessing.GridColumn? CreateModelElement(GridColumn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GridColumn();
      value.Width = GetWidth(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GridColumn? value)
    where OpenXmlElementType : GridColumn, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      return openXmlElement;
    }
    return default;
  }
}