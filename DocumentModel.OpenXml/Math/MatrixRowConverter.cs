namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Row.
/// </summary>
public static class MatrixRowConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Math.Base>? GetBases(DocumentFormat.OpenXml.Math.MatrixRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Math.Base>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.Base>())
      {
        var newItem = DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetBases(DocumentFormat.OpenXml.Math.MatrixRow? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Math.Base>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.Base>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Math.BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Math.MatrixRow? CreateModelElement(DocumentFormat.OpenXml.Math.MatrixRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MatrixRow();
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.MatrixRow? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.MatrixRow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBases(openXmlElement, value?.Bases);
      return openXmlElement;
    }
    return default;
  }
}
