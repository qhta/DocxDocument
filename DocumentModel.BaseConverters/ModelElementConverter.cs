using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml;

/// <summary>
/// Generic model element converter. 
/// Uses type reflection to dispatch a generic method to specific converter searched by an openXml element type name (+"Converter" suffix).
/// </summary>
public static class ModelElementConverter
{

  /// <summary>
  /// Creates a model element from an openXml element using its specific converter method.
  /// </summary>
  /// <param name="openXmlElement">An openXml element read from DocumentFormat.OpenXml document</param>
  /// <returns>Newly created model element (or <c>null</c> if conversion failed)</returns>
  /// <exception cref="InvalidOperationException">Thrown if a specific converter or its CreateModelElement method not found.</exception>
  public static DM.ModelElement? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var nspace = openXmlElement.GetType().Namespace ?? "";
      nspace = nspace.Replace("DocumentFormat.OpenXml", "DocumentModel.OpenXml");
      var typeName = nspace + "." + openXmlElement.GetType().Name + "Converter";
      var elementConverterType = Type.GetType(typeName);
      if (elementConverterType == null)
        throw new InvalidOperationException($"Converter of type {typeName} not found");
      var converterMethod = elementConverterType.GetMethod("CreateModelElement", BindingFlags.Public | BindingFlags.Static);
      if (converterMethod == null)
        throw new InvalidOperationException($"Method \"CreateModelElement\" not found in type {typeName}");
      var value = converterMethod.Invoke(null, new object[] { openXmlElement });
      return value as DM.ModelElement;
    }
    return null;
  }

   /// <summary>
  /// Creates an openXml element based on a model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>
  /// <exception cref="InvalidOperationException">
  ///   Thrown if a specific converter or its CreateOpenXmlElement method not found 
  ///   or invoked CreateOpenXmlElement methods returns invalid result.
  /// </exception>
  public static DX.OpenXmlElement CreateOpenXmlElement(DM.ModelElement model)
  {
    var nspace = model.GetType().Namespace ?? "";
    nspace = nspace.Replace("DocumentModel", "DocumentModel.OpenXml");
    var typeName = nspace + "." + model.GetType().Name + "Converter";
    var elementConverterType = Type.GetType(typeName);
    if (elementConverterType == null)
      throw new InvalidOperationException($"Converter of type {typeName} not found");
    var converterMethod = elementConverterType.GetMethod("CreateOpenXmlParagraphContent", BindingFlags.Public | BindingFlags.Static);
    if (converterMethod == null)
      throw new InvalidOperationException($"Method \"CreateOpenXmlParagraphContent\" not found in type {typeName}");
    var openXmlElement = converterMethod.Invoke(null, new object[] { model });
    if (openXmlElement is DX.OpenXmlElement result)
      return result;
    throw new InvalidOperationException($"Method \"CreateOpenXmlParagraphContent\" in type {typeName} must return OpenXmlElement result");
  }

  /// <summary>
  /// Updates an openXml element based on a model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
  /// <exception cref="InvalidOperationException">Thrown if a specific converter or its UpdateOpenXmlElement method not found.</exception>
  public static bool UpdateOpenXmlElement(DX.OpenXmlElement openXmlElement, DM.ModelElement model)
  {
    var nspace = openXmlElement.GetType().Namespace ?? "";
    nspace = nspace.Replace("DocumentFormat.OpenXml", "DocumentModel.OpenXml");
    var typeName = nspace + "." + model.GetType().Name + "Converter";
    var elementConverterType = Type.GetType(typeName);
    if (elementConverterType == null)
      throw new InvalidOperationException($"Converter of type {typeName} not found");
    var converterMethod = elementConverterType.GetMethod("UpdateOpenXmlElement", BindingFlags.Public | BindingFlags.Static);
    if (converterMethod == null)
      throw new InvalidOperationException($"Method \"UpdateOpenXmlElement\" not found in type {typeName}");
    var result = converterMethod.Invoke(null, new object[] { openXmlElement, model });
    if (result is bool boolResult)
      return boolResult;
    return true;
  }

}
