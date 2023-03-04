using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml;

/// <summary>
/// Universal model element converter. 
/// Uses type reflection to dispatch to specific converter.
/// </summary>
public static class ElementCollectionConverter<T>
//  where T: ModelElement, new()
{
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

  public static void UpdateOpenXmlElement(DX.OpenXmlElement openXmlElement, DM.ModelElement value)
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
  }
}
