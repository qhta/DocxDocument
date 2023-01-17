namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Formulas Class.
/// </summary>
public static class FormulasConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Vml.Formula> GetItems(DocumentFormat.OpenXml.Vml.Formulas openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Vml.Formula>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Formula>())
    {
      var newItem = DocumentModel.OpenXml.Vml.FormulaConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Vml.Formulas openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Vml.Formula>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Formula>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Vml.FormulaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Formula>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.Formulas? CreateModelElement(DocumentFormat.OpenXml.Vml.Formulas? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Formulas();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Formulas? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Formulas, new()
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
