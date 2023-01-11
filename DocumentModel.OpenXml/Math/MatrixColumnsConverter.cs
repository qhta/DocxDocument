namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Columns.
/// </summary>
public static class MatrixColumnsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Math.MatrixColumn>? GetItems(DocumentFormat.OpenXml.Math.MatrixColumns? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Math.MatrixColumn>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.MatrixColumn>())
      {
        var newItem = DocumentModel.OpenXml.Math.MatrixColumnConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Math.MatrixColumns? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Math.MatrixColumn>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.MatrixColumn>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Math.MatrixColumnConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixColumn>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Math.MatrixColumns? CreateModelElement(DocumentFormat.OpenXml.Math.MatrixColumns? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.MatrixColumns, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
