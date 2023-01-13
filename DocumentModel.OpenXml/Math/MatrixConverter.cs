namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public static class MatrixConverter
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public static DocumentModel.Math.MatrixProperties? GetMatrixProperties(DocumentFormat.OpenXml.Math.Matrix? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.MatrixPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMatrixProperties(DocumentFormat.OpenXml.Math.Matrix? openXmlElement, DocumentModel.Math.MatrixProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.MatrixPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Math.MatrixRow>? GetMatrixRows(DocumentFormat.OpenXml.Math.Matrix? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Math.MatrixRow>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.MatrixRow>())
      {
        var newItem = DocumentModel.OpenXml.Math.MatrixRowConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetMatrixRows(DocumentFormat.OpenXml.Math.Matrix? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Math.MatrixRow>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.MatrixRow>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Math.MatrixRowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixRow>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Math.Matrix? CreateModelElement(DocumentFormat.OpenXml.Math.Matrix? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Matrix();
      value.MatrixProperties = GetMatrixProperties(openXmlElement);
      value.MatrixRows = GetMatrixRows(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Matrix? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Matrix, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMatrixProperties(openXmlElement, value?.MatrixProperties);
      SetMatrixRows(openXmlElement, value?.MatrixRows);
      return openXmlElement;
    }
    return default;
  }
}
