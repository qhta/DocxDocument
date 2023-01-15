using DocumentModel.Math;
using MatrixRow = DocumentFormat.OpenXml.Math.MatrixRow;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Matrix Row.
/// </summary>
public static class MatrixRowConverter
{
  public static Collection<Base>? GetBases(MatrixRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Base>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.Base>())
      {
        var newItem = BaseConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBases(MatrixRow? openXmlElement, Collection<Base>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.Base>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Math.MatrixRow? CreateModelElement(MatrixRow? openXmlElement)
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
    where OpenXmlElementType : MatrixRow, new()
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