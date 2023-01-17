namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public static class EquationArrayConverter
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  private static DocumentModel.Math.EquationArrayProperties? GetEquationArrayProperties(DocumentFormat.OpenXml.Math.EquationArray openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArrayProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.EquationArrayPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEquationArrayProperties(DocumentFormat.OpenXml.Math.EquationArray openXmlElement, DocumentModel.Math.EquationArrayProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArrayProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.EquationArrayPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.EquationArrayProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Math.Base> GetBases(DocumentFormat.OpenXml.Math.EquationArray openXmlElement)
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
  
  private static void SetBases(DocumentFormat.OpenXml.Math.EquationArray openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Math.Base>? value)
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
  
  public static DocumentModel.Math.EquationArray? CreateModelElement(DocumentFormat.OpenXml.Math.EquationArray? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.EquationArray();
      value.EquationArrayProperties = GetEquationArrayProperties(openXmlElement);
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.EquationArray? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.EquationArray, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEquationArrayProperties(openXmlElement, value?.EquationArrayProperties);
      SetBases(openXmlElement, value?.Bases);
      return openXmlElement;
    }
    return default;
  }
}
