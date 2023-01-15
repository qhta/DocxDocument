using DocumentModel.Math;
using MatrixColumns = DocumentFormat.OpenXml.Math.MatrixColumns;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Matrix Columns.
/// </summary>
public static class MatrixColumnsConverter
{
  public static Collection<MatrixColumn>? GetItems(MatrixColumns? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<MatrixColumn>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.MatrixColumn>())
      {
        var newItem = MatrixColumnConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(MatrixColumns? openXmlElement, Collection<MatrixColumn>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.MatrixColumn>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = MatrixColumnConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixColumn>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Math.MatrixColumns? CreateModelElement(MatrixColumns? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MatrixColumns();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.MatrixColumns? value)
    where OpenXmlElementType : MatrixColumns, new()
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