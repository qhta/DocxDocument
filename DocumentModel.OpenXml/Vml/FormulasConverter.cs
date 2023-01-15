using DocumentModel.Vml;
using Formulas = DocumentFormat.OpenXml.Vml.Formulas;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the Formulas Class.
/// </summary>
public static class FormulasConverter
{
  public static Collection<Formula>? GetItems(Formulas? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Formula>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Formula>())
      {
        var newItem = FormulaConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Formulas? openXmlElement, Collection<Formula>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Formula>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = FormulaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Formula>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Vml.Formulas? CreateModelElement(Formulas? openXmlElement)
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
    where OpenXmlElementType : Formulas, new()
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