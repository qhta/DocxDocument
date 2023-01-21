namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Formulas Class.
/// </summary>
public static class FormulasConverter
{
  private static Collection<DMVml.Formula> GetItems(DXVml.Formulas openXmlElement)
  {
    var collection = new Collection<DMVml.Formula>();
    foreach (var item in openXmlElement.Elements<DXVml.Formula>())
    {
      var newItem = DMXVml.FormulaConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXVml.Formulas openXmlElement, Collection<DMVml.Formula>? value)
  {
    openXmlElement.RemoveAllChildren<DXVml.Formula>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXVml.FormulaConverter.CreateOpenXmlElement<DXVml.Formula>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMVml.Formulas? CreateModelElement(DXVml.Formulas? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Formulas();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Formulas? value)
    where OpenXmlElementType: DXVml.Formulas, new()
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
