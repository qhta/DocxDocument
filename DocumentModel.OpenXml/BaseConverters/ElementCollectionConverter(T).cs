using System.Xml.Linq;

using DocumentFormat.OpenXml;

using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml;

public delegate bool CompareOpenXmlElementMethod(DX.OpenXmlElement? openXmlElement, DM.IModelElement? value, DiffList? diffs = null, string? objName = null);

public delegate bool UpdateOpenXmlElementMethod(DX.OpenXmlElement openXmlElement, DM.IModelElement value);

public delegate OpenXmlElement CreateOpenXmlElementMethod(DM.IModelElement value);


/// <summary>
/// Universal model element converter. 
/// Uses type reflection to dispatch to specific converter.
/// </summary>
public static class ElementCollectionConverter<T>
  where T : IModelElement
{
  #region collection object conversion
  public static ElementType? CreateModelElement<ElementType>(DX.OpenXmlCompositeElement? openXmlElement)
    where ElementType : ElementCollection<T>, new()
  {
    if (openXmlElement != null)
    {
      var nspace = typeof(T).Namespace ?? "";
      nspace = nspace.Replace("DocumentModel", "DocumentModel.OpenXml");
      var typeName = nspace + "." + typeof(T).Name + "Converter";
      var elementConverterType = Type.GetType(typeName);
      if (elementConverterType == null)
        throw new InvalidOperationException($"Converter of type {typeName} not found");
      var converterMethod = elementConverterType.GetMethod("CreateModelElement", BindingFlags.Public | BindingFlags.Static);
      if (converterMethod == null)
        throw new InvalidOperationException($"Method \"CreateModelElement\" not found in type {typeName}");
      var result = new ElementType();
      foreach (var element in openXmlElement)
      {
        var value = converterMethod.Invoke(null, new object[] { element });
        if (value is T val)
          result.Add(val);
      }
      if (result.Count == 0) return null;
      return result;
    }
    return null;
  }

  public static bool CompareModelElement(DX.OpenXmlElement? openXmlElement, DM.ModelElement? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var nspace = typeof(T).Namespace ?? "";
      nspace = nspace.Replace("DocumentFormat.OpenXml", "DocumentModel.OpenXml");
      var typeName = nspace + "." + typeof(T).Name + "Converter";
      var elementConverterType = Type.GetType(typeName);
      if (elementConverterType == null)
        throw new InvalidOperationException($"Converter of type {typeName} not found");
      var converterMethod = elementConverterType.GetMethod("CompareModelElement", BindingFlags.Public | BindingFlags.Static);
      if (converterMethod == null)
        throw new InvalidOperationException($"Method \"CompareModelElement\" not found in type {typeName}");
      var ok = converterMethod.Invoke(null, new object?[] { openXmlElement, value, diffs, objName });
      if (ok is bool result)
        return result;
      return false;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DX.OpenXmlElement CreateOpenXmlElement(DM.ModelElement value)
  {
    var nspace = value.GetType().Namespace ?? "";
    nspace = nspace.Replace("DocumentModel", "DocumentModel.OpenXml");
    var typeName = nspace + "." + value.GetType().Name + "Converter";
    var elementConverterType = Type.GetType(typeName);
    if (elementConverterType == null)
      throw new InvalidOperationException($"Converter of type {typeName} not found");
    var converterMethod = elementConverterType.GetMethod("CreateOpenXmlElement", BindingFlags.Public | BindingFlags.Static);
    if (converterMethod == null)
      throw new InvalidOperationException($"Method \"CreateOpenXmlElement\" not found in type {typeName}");
    var openXmlElement = converterMethod.Invoke(null, new object[] { value });
    if (openXmlElement is DX.OpenXmlElement result)
      return result;
    throw new InvalidOperationException($"Method \"CreateOpenXmlElement\" in type {typeName} must return OpenXmlElement result");
  }

  public static bool UpdateOpenXmlElement(DX.OpenXmlElement openXmlElement, DM.ModelElement value)
  {
    var nspace = openXmlElement.GetType().Namespace ?? "";
    nspace = nspace.Replace("DocumentFormat.OpenXml", "DocumentModel.OpenXml");
    var typeName = nspace + "." + value.GetType().Name + "Converter";
    var elementConverterType = Type.GetType(typeName);
    if (elementConverterType == null)
      throw new InvalidOperationException($"Converter of type {typeName} not found");
    var converterMethod = elementConverterType.GetMethod("UpdateOpenXmlElement", BindingFlags.Public | BindingFlags.Static);
    if (converterMethod == null)
      throw new InvalidOperationException($"Method \"UpdateOpenXmlElement\" not found in type {typeName}");
    converterMethod.Invoke(null, new object[] { openXmlElement, value });
    return true;
  }
  #endregion

  #region collection items conversion
  public static bool UpdateOpenXmlElementCollection(DX.OpenXmlCompositeElement contentElement, DM.ElementCollection<T> modelElementCollection,
    CompareOpenXmlElementMethod compareElementMethod, UpdateOpenXmlElementMethod updateElementMethod, CreateOpenXmlElementMethod createElementMethod)
  {
    var elements = contentElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    var modelEnumerator = modelElementCollection.GetEnumerator();
    while (elementsEnumerator.MoveNext() && modelEnumerator.MoveNext())
    {
      var modelElement = modelEnumerator.Current;
      OpenXmlElement? openXmlElement = elementsEnumerator.Current;
      if (openXmlElement != null && modelElement != null)
      {
        var diffs = new DiffList();
        if (!compareElementMethod(openXmlElement, modelElement, diffs, "Item"))
        {
          var diff = diffs.FirstOrDefault();
          if (diff != null && diff.ObjectName == "Item")
          {
            if (diff.PropertyName != "@Type" && diff.PropertyName?.EndsWith("Id") != true)
            {
              updateElementMethod(openXmlElement, modelElement);
              continue;
            }
          }
        }
        contentElement.AddChild(createElementMethod(modelElement));
      }
    }
    return true;
  }

  public static bool CompareOpenXmlElementCollection(DX.OpenXmlCompositeElement? contentElement, DM.ElementCollection<T> modelElementCollection,
  CompareOpenXmlElementMethod compareElementMethod, DiffList? diffs, string? objName)
  {
    if (contentElement != null)
    {
      var elements = contentElement.Elements();
      if (modelElementCollection.Any())
      {
        var elementsEnumerator = elements.GetEnumerator();
        var modelEnumerator = modelElementCollection.GetEnumerator();
        var ok = true;
        int i = 0;
        while (elementsEnumerator.MoveNext() && modelEnumerator.MoveNext())
        {
          var modelElement = modelEnumerator.Current;
          OpenXmlElement? openXmlElement = elementsEnumerator.Current;
          if (openXmlElement != null && modelElement != null)
          {
            if (!compareElementMethod(openXmlElement, modelElement, diffs, $"Item[{i}]"))
              ok = false;
          }
        }
        if (!Int32ValueConverter.CmpValue(elements.Count(), modelElementCollection.Count(), diffs, objName))
          ok = false;
        return ok;
      }
      else
      {
        diffs?.Add(objName,"Count", elements.Count(), 0);
        return false;
      }
    }
    else
    {
      if (modelElementCollection.Any())
      {
        diffs?.Add(objName,"Count", 0, modelElementCollection.Count());
        return false;
      }
    }
    return true;
  }
  #endregion
}
