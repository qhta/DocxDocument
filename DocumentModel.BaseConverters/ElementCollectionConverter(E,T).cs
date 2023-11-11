namespace DocumentModel.OpenXml;

#region CreateModelElement method delegates

/// <summary>
/// Used in collection object conversion methods to pass a specific method to create a model element from an openXml element.
/// </summary>
/// <param name="openXmlElement">OpenXml element read from DocumentFormat.OpenXml document.</param>
/// <returns>Newly created model element (or <c>null</c> if openXmlElement is not recognized)</returns>
public delegate ModelType? CreateModelElementMethod2<ElementType, ModelType>(ElementType openXmlElement);

/// <summary>
/// Used in collection object conversion methods to pass a specific method to create a model element from an openXml element.
/// </summary>
/// <param name="openXmlElement">OpenXml element read from DocumentFormat.OpenXml document.</param>
/// <param name="data">Additional parameter</param>
/// <returns>Newly created model element (or <c>null</c> if openXmlElement is not recognized)</returns>
public delegate ModelType? CreateModelElementMethod2Ext<ElementType, ModelType>(ElementType openXmlElement, object? data = null)
where ElementType: DX.OpenXmlElement;
#endregion

#region CreateOpenXmlElement method delegates
/// <summary>
/// Used in collection object conversion methods to pass a specific method to create an openXml element based on a model element.
/// </summary>
/// <param name="model">A model element with valid content.</param>
/// <returns>Newly created openXml element</returns>
public delegate ElementType CreateOpenXmlElementMethod2<ElementType, ModelType>(ModelType model)
where ElementType: DX.OpenXmlElement;

/// <summary>
/// Used in collection object conversion methods to pass a specific method to create an openXml element based on a model element.
/// </summary>
/// <param name="model">A model element with valid content.</param>
/// <param name="data">Additional parameter</param>
/// <returns>Newly created openXml element</returns>
public delegate ElementType CreateOpenXmlElementMethod2Ext<ElementType, ModelType>(ModelType model, object? data = null)
where ElementType: DX.OpenXmlElement;
#endregion

#region UpdateOpenXmlElement method delegates
/// <summary>
/// Used in collection object conversion methods to pass a specific method to update an openXml element based on a model element.
/// </summary>
/// <param name="openXmlElement">OpenXml element to update.</param>
/// <param name="model">A model element with valid content.</param>
/// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
public delegate bool UpdateOpenXmlElementMethod2<ElementType, ModelType>(ElementType openXmlElement, ModelType model)
where ElementType: DX.OpenXmlElement;

/// <summary>
/// Used in collection object conversion methods to pass a specific method to update an openXml element based on a model element.
/// </summary>
/// <param name="openXmlElement">OpenXml element to update.</param>
/// <param name="model">A model element with valid content.</param>
/// <param name="data">Additional parameter</param>
/// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
public delegate bool UpdateOpenXmlElementMethod2Ext<ElementType, ModelType>(ElementType openXmlElement, ModelType model, object? data = null)
where ElementType: DX.OpenXmlElement;

#endregion

/// <summary>
/// Generic model element collection converter. It has two method sets. 
/// <list type="bullet">
///   <item>
///     First set uses type reflection to dispatch a generic method to specific converter searched by a item type name (+"Converter" suffix).
///     These methods are used in specific collection converters which item conversion implementation can be redirected to specific item converters.
///   </item>
///   <item>
///      Second set contains methods used when an item conversion is handled in methods contained in same collection converters.
///      You must pass specific method delegates.
/// </item>
/// </list>
/// </summary>
public static class ElementCollectionConverter2<ItemType, ModelType>
  where ItemType: DX.OpenXmlElement, new()
  where ModelType : IModelElement
{
  #region collection object conversion

  /// <summary>
  /// Creates generic model element collection from a OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="ElementType">Generic model element collection.</typeparam>
  /// <param name="compositeElement">Composite OpenXmlElement read from DocumentFormat.OpenXml document.</param>
  /// <returns>Newly created model element collection (or <c>null</c> if openXmlElement contains no recognized elements)</returns>
  /// <exception cref="InvalidOperationException">Thrown if a specific converter or its CreateModelElement method not found.</exception>
  public static ElementType? CreateModelElement<ElementType>(DX.OpenXmlCompositeElement? compositeElement)
    where ElementType : ElementCollection<ModelType>, new()
  {
    if (compositeElement != null)
    {
      var nspace = typeof(ModelType).Namespace ?? "";
      nspace = nspace.Replace("DocumentModel", "DocumentModel.OpenXml");
      var typeName = nspace + "." + typeof(ModelType).Name + "Converter";
      var elementConverterType = Type.GetType(typeName);
      if (elementConverterType == null)
        throw new InvalidOperationException($"Converter of type {typeName} not found");
      var converterMethod = elementConverterType.GetMethod("CreateModelElement", BindingFlags.Public | BindingFlags.Static);
      if (converterMethod == null)
        throw new InvalidOperationException($"Method \"CreateModelElement\" not found in type {typeName}");
      var result = new ElementType();
      foreach (var element in compositeElement)
      {
        var value = converterMethod.Invoke(null, new object[] { element });
        if (value is ModelType val)
          result.Add(val);
      }
      if (result.Count == 0) return null;
      return result;
    }
    return null;
  }

  /// <summary>
  /// Creates a composite openXml element based on a model element collection.
  /// </summary>
  /// <param name="modelElementCollection">A model element collection with valid content.</param>
  /// <returns>Newly created composite openXml element</returns>
  /// <exception cref="InvalidOperationException">
  ///   Thrown if a specific converter or its CreateOpenXmlElement method not found 
  ///   or invoked CreateOpenXmlElement methods returns invalid result.
  /// </exception>
  public static DX.OpenXmlCompositeElement CreateOpenXmlElement(ElementCollection<ModelType> modelElementCollection)
  {
    var nspace = modelElementCollection.GetType().Namespace ?? "";
    nspace = nspace.Replace("DocumentModel", "DocumentModel.OpenXml");
    var typeName = nspace + "." + modelElementCollection.GetType().Name + "Converter";
    var elementConverterType = Type.GetType(typeName);
    if (elementConverterType == null)
      throw new InvalidOperationException($"Converter of type {typeName} not found");
    var converterMethod = elementConverterType.GetMethod("CreateOpenXmlParagraphContent", BindingFlags.Public | BindingFlags.Static);
    if (converterMethod == null)
      throw new InvalidOperationException($"Method \"CreateOpenXmlParagraphContent\" not found in type {typeName}");
    var openXmlElement = converterMethod.Invoke(null, new object[] { modelElementCollection });
    if (openXmlElement is DX.OpenXmlCompositeElement result)
      return result;
    throw new InvalidOperationException($"Method \"CreateOpenXmlParagraphContent\" in type {typeName} must return OpenXmlElement result");
  }

  /// <summary>
  /// Updates an openXml composite element based on a model element collection.
  /// </summary>
  /// <param name="compositeElement">Composite openXml element to update.</param>
  /// <param name="modelElementCollection">A model element collection with valid content.</param>
  /// <returns><c>True</c> if the composite openXml element was updated succesfully, <c>false</c> otherwise</returns>
  /// <exception cref="InvalidOperationException">Thrown if a specific converter or its UpdateOpenXmlElement method not found.</exception>
  public static bool UpdateOpenXmlElement(DX.OpenXmlCompositeElement compositeElement, DM.ModelElement modelElementCollection)
  {
    var nspace = compositeElement.GetType().Namespace ?? "";
    nspace = nspace.Replace("DocumentFormat.OpenXml", "DocumentModel.OpenXml");
    var typeName = nspace + "." + modelElementCollection.GetType().Name + "Converter";
    var elementConverterType = Type.GetType(typeName);
    if (elementConverterType == null)
      throw new InvalidOperationException($"Converter of type {typeName} not found");
    var converterMethod = elementConverterType.GetMethod("UpdateOpenXmlElement", BindingFlags.Public | BindingFlags.Static);
    if (converterMethod == null)
      throw new InvalidOperationException($"Method \"UpdateOpenXmlElement\" not found in type {typeName}");
    converterMethod.Invoke(null, new object[] { compositeElement, modelElementCollection });
    return true;
  }
  #endregion

  #region collection fill methods with delegate parameters

  /// <summary>
  /// Reads all elements contained in a composite openXml element, converts them to model elements and fills a model element collection.
  /// </summary>
  /// <param name="elements">A collection of openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="modelElementCollection">A model element collection to fill with newly created model elements.</param>
  /// <param name="createElementMethod">Delegate to a method to convert openXml elements to model elements.</param>
  /// <returns><c>True</c> if conversion was successful, <c>false</c> otherwise.</returns>
  public static bool FillModelElementCollection(IEnumerable<ItemType>? elements, DM.ElementCollection<ModelType> modelElementCollection,
    CreateModelElementMethod2<ItemType, ModelType> createElementMethod)
  {
    if (elements != null)
    {
      foreach (var element in elements)
      {
        var item = createElementMethod(element);
        if (item is ModelType modelElement)
          modelElementCollection.Add(modelElement);
        else if (item != null)
          throw new InvalidOperationException($"Type {item.GetType()} does not implement {typeof(ModelType)}");
      }
    }
    return true;
  }

    /// <summary>
  /// Reads all elements contained in a composite openXml element, converts them to model elements and fills a model element collection.
  /// </summary>
  /// <param name="elements">A collection of openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="modelElementCollection">A model element collection to fill with newly created model elements.</param>
  /// <param name="createElementMethod">Delegate to a method to convert openXml elements to model elements.</param>
  /// <param name="data">Additional parameter passed to <see cref="CreateModelElementMethodExt"/> method.</param>
  /// <returns><c>True</c> if conversion was successful, <c>false</c> otherwise.</returns>
  public static bool FillModelElementCollection(IEnumerable<ItemType>? elements, DM.ElementCollection<ModelType> modelElementCollection,
    CreateModelElementMethod2Ext<ItemType, ModelType> createElementMethod, object data)
  {
    if (elements != null)
    {
      foreach (var element in elements)
      {
        var item = createElementMethod(element, data);
        if (item is ModelType modelElement)
          modelElementCollection.Add(modelElement);
        else if (item != null)
          throw new InvalidOperationException($"Type {item.GetType()} does not implement {typeof(ModelType)}");
      }
    }
    return true;
  }
  #endregion

}
