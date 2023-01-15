using DocumentModel.Math;
using Matrix = DocumentFormat.OpenXml.Math.Matrix;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Matrix Function.
/// </summary>
public static class MatrixConverter
{
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  public static MatrixProperties? GetMatrixProperties(Matrix? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixProperties>();
    if (itemElement != null)
      return MatrixPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMatrixProperties(Matrix? openXmlElement, MatrixProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MatrixPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<MatrixRow>? GetMatrixRows(Matrix? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<MatrixRow>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.MatrixRow>())
      {
        var newItem = MatrixRowConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetMatrixRows(Matrix? openXmlElement, Collection<MatrixRow>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.MatrixRow>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = MatrixRowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixRow>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Math.Matrix? CreateModelElement(Matrix? openXmlElement)
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
    where OpenXmlElementType : Matrix, new()
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