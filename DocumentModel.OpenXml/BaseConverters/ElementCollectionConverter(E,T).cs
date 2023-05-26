using System.Reflection.Metadata.Ecma335;

using DocumentFormat.OpenXml.Office2019.Excel.RichData2;

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

#region CompareModelElement method delegates
/// <summary>
/// Used in collection object conversion methods to pass a specific method to compare an openXml element 
/// and a model element that was created from that openXml element.
/// </summary>
/// <param name="openXmlElement">OpenXml element read from DocumentFormat.OpenXml document.</param>
/// <param name="model">A model element created from the openXmlElement.</param>
/// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
/// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
/// <returns><c>True</c> if the model element is equivalent to openXmlElement, <c>false</c> otherwise</returns>
public delegate bool CompareOpenXmlElementMethod2<ElementType, ModelType>(ElementType openXmlElement, ModelType model,
  DiffList? diffs = null, string? objName = null, string? propName = null)
  where ElementType: DX.OpenXmlElement;

/// <summary>
/// Used in collection object conversion methods to pass a specific method to compare an openXml element 
/// and a model element that was created from that openXml element.
/// </summary>
/// <param name="openXmlElement">OpenXml element read from DocumentFormat.OpenXml document.</param>
/// <param name="model">A model element created from the openXmlElement.</param>
/// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
/// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
/// <param name="data">Additional parameter</param>
/// <returns><c>True</c> if the model element is equivalent to openXmlElement, <c>false</c> otherwise</returns>
public delegate bool CompareOpenXmlElementMethod2Ext<ElementType, ModelType>(ElementType openXmlElement, ModelType model,
  DiffList? diffs = null, string? objName = null, object? data = null)
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
  /// Compares a composite openXml element and a model element collection that was created from that openXml element.
  /// </summary>
  /// <param name="compositeElement">Composite openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="modelElementCollection">A model element collection created from the openXmlElement.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element collection is equivalent to composite openXmlElement, <c>false</c> otherwise</returns>
  /// <exception cref="InvalidOperationException">Thrown if a specific converter or its CompareModelElement method not found.</exception>
  public static bool CompareModelElement(DX.OpenXmlCompositeElement? compositeElement, ElementCollection<ModelType>? modelElementCollection, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (compositeElement != null && modelElementCollection != null)
    {
      var nspace = typeof(ModelType).Namespace ?? "";
      nspace = nspace.Replace("DocumentFormat", "DocumentModel");
      if (nspace == "DocumentModel")
        nspace = "DocumentModel.OpenXml";
      var typeName = nspace + "." + typeof(ModelType).Name + "Converter";
      var elementConverterType = Type.GetType(typeName);
      if (elementConverterType == null)
        throw new InvalidOperationException($"Converter of type {typeName} not found");
      var converterMethod = elementConverterType.GetMethod("CompareModelElement", BindingFlags.Public | BindingFlags.Static);
      if (converterMethod == null)
        throw new InvalidOperationException($"Method \"CompareModelElement\" not found in type {typeName}");
      var openXmlEnumerator = compositeElement.GetEnumerator();
      var modelElementEnumerator = modelElementCollection.GetEnumerator();
      var ok = true;
      while (openXmlEnumerator.MoveNext() && modelElementEnumerator.MoveNext())
      {
        var openXmlItem = openXmlEnumerator.Current;
        var modelItem = modelElementEnumerator.Current;
        var ok1 = converterMethod.Invoke(null, new object?[] { openXmlItem, modelItem, diffs, objName });
        if (ok1 is bool bv && bv == false)
          ok = false;
      }
      var openXmlItemCount = compositeElement.Count();
      var modelItemCount = modelElementCollection.Count();
      if (!Int32ValueConverter.CmpValue(openXmlItemCount, modelItemCount))
        ok = false;
      return ok;
    }
    if (compositeElement == null && modelElementCollection == null) return true;
    diffs?.Add(objName, compositeElement?.GetType().Name, compositeElement, modelElementCollection);
    return false;
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

  #region Collection compare methods with delegate parameters
  /// <summary>
  /// Compares all elements contained in a composite openXml element with model elements contained in model element collection.
  /// </summary>
  /// <param name="compositeElement">Composite openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="collection">A model element collection with items created from openXml elements.</param>
  /// <param name="compareElementMethod">Delegate to a method to compare openXml elements to model elements.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element collection is equivalent to composite openXmlElement, <c>false</c> otherwise</returns>
  public static bool CompareOpenXmlElementCollection(DX.OpenXmlCompositeElement? compositeElement, 
    DM.ElementCollection<ModelType>? collection,
  CompareOpenXmlElementMethod2<ItemType, ModelType> compareElementMethod, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (compositeElement != null && collection != null)
    {
      var elements = compositeElement.Elements<ItemType>();
      return CompareOpenXmlElementCollection(elements, collection, compareElementMethod, diffs, objName, propName);
    }
    if (compositeElement == null && collection == null)
      return true;
    diffs?.Add(objName, compositeElement?.GetType().Name, compositeElement, collection);
    return false;
  }

  /// <summary>
  /// Compares all elements contained in an openXml element collection with model elements contained in model element collection.
  /// </summary>
  /// <param name="elements">Collection of openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="models">A model element collection with items created from openXml elements.</param>
  /// <param name="compareElementMethod">Delegate to a method to compare openXml elements to model elements.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element collection is equivalent to composite openXmlElement, <c>false</c> otherwise</returns>
  public static bool CompareOpenXmlElementCollection(IEnumerable<ItemType>? elements, 
    DM.ElementCollection<ModelType> models,
    CompareOpenXmlElementMethod2<ItemType, ModelType> compareElementMethod, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (elements != null)
    {
      var ok = true;
      if (elements.Any() && models.Any())
      {
        var elementsEnumerator = elements.GetEnumerator();
        var modelEnumerator = models.GetEnumerator();
        int i = 0;
        while (elementsEnumerator.MoveNext() && modelEnumerator.MoveNext())
        {
          var modelElement = modelEnumerator.Current;
          ItemType? openXmlElement = elementsEnumerator.Current;
          if (openXmlElement != null && modelElement != null)
          {
            if (!compareElementMethod(openXmlElement, modelElement, diffs, (objName != null) ? $"{objName}[{i}]" : $"Item[{i}]"))
              ok = false;
          }
        }
        if (!Int32ValueConverter.CmpValue(elements.Count(), models.Count(), diffs, objName, "Count"))
          ok = false;
        return ok;
      }
      else
      {
        if (!Int32ValueConverter.CmpValue(elements.Count(), models.Count(), diffs, objName, "Count"))
          ok = false;
        return ok;
      }
    }
    return true;
  }
  /// <summary>
  /// Compares all elements contained in an openXml element collection with model elements contained in model element collection.
  /// </summary>
  /// <param name="elements">Collection of openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="models">A model element collection with items created from openXml elements.</param>
  /// <param name="compareElementMethod">Delegate to a method to compare openXml elements to model elements.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <param name="data">Additional parameter passed to <see cref="CompareOpenXmlElementMethod"/> method.</param>
  /// <returns><c>True</c> if the model element collection is equivalent to composite openXmlElement, <c>false</c> otherwise</returns>
  public static bool CompareOpenXmlElementCollection(IEnumerable<ItemType>? elements, 
    DM.ElementCollection<ModelType> models,
  CompareOpenXmlElementMethod2Ext<ItemType, ModelType> compareElementMethod, DiffList? diffs, string? objName, object? data = null)
  {
    if (elements != null)
    {
      var ok = true;
      if (elements.Any() && models.Any())
      {
        var elementsEnumerator = elements.GetEnumerator();
        var modelEnumerator = models.GetEnumerator();
        int i = 0;
        while (elementsEnumerator.MoveNext() && modelEnumerator.MoveNext())
        {
          var modelElement = modelEnumerator.Current;
          var openXmlElement = elementsEnumerator.Current as ItemType;
          if (openXmlElement != null && modelElement != null)
          {
            if (!compareElementMethod(openXmlElement, modelElement, diffs, (objName != null) ? $"{objName}[{i}]" : $"Item[{i}]", 
              data))
              ok = false;
          }
        }
        if (!Int32ValueConverter.CmpValue(elements.Count(), models.Count(), diffs, objName, "Count"))
          ok = false;
        return ok;
      }
      else
      {
        if (!Int32ValueConverter.CmpValue(elements.Count(), models.Count(), diffs, objName, "Count"))
          ok = false;
        return ok;
      }
    }
    return true;
  }
  #endregion

  #region Collection update methods with delegate parameters
  /// <summary>
  /// Updates the content of a composite openXml element based on model elements contained in model element collection.
  /// </summary>
  /// <param name="compositeElement">Composite openXmlElement to update.</param>
  /// <param name="modelElementCollection">Model element collection with valid items</param>
  /// <param name="compareElementMethod">Delegate to a method to compare openXml elements to model elements.</param>
  /// <param name="updateElementMethod">Delegate to a method to update openXml elements based on model elements.</param>
  /// <param name="createElementMethod">Delegate to a method to create openXml elements from model elements.</param>
  /// <returns><c>True</c> if update was successfull, <c>false</c> otherwise.</returns>
  public static bool UpdateOpenXmlElementCollection(DX.OpenXmlCompositeElement compositeElement, DM.ElementCollection<ModelType> modelElementCollection,
    CompareOpenXmlElementMethod2<ItemType, ModelType>compareElementMethod,
    UpdateOpenXmlElementMethod2<ItemType, ModelType> updateElementMethod,
    CreateOpenXmlElementMethod2<ItemType, ModelType> createElementMethod)
  {
    return UpdateOpenXmlElementCollection(compositeElement, null, modelElementCollection,
      compareElementMethod, updateElementMethod, createElementMethod);
  }

  /// <summary>
  /// Updates the content of a composite openXml element based on model elements contained in model element collection.
  /// First, if filter is supplied, then child elements of composite openXml element are qualified to form a list.
  /// If there is no filter, then all child elements are qualified.
  /// Second, the qualified list of openXml elements is compared to model element collection (item by item).
  /// If all the items are equal, then then nothing is done and this method returns true.
  /// If diffs are found, then further processing is as following: Different openXml element is tried to update.
  /// Remaining openXml elements are removed. Remaining model elements create new openXml elements, which are added to 
  /// the composite element.
  /// </summary>
  /// <param name="compositeElement">Composite openXmlElement to update.</param>
  /// <param name="filter">Predicate to qualify openXmlElement. If null then all child element are qualified to update</param>
  /// <param name="modelElementCollection">Model element collection with valid items</param>
  /// <param name="compareElementMethod">Delegate to a method to compare openXml elements to model elements.</param>
  /// <param name="updateElementMethod">Delegate to a method to update openXml elements based on model elements.</param>
  /// <param name="createElementMethod">Delegate to a method to create openXml elements from model elements.</param>
  /// <returns><c>True</c> if update was successfull, <c>false</c> otherwise.</returns>
  public static bool UpdateOpenXmlElementCollection(DX.OpenXmlCompositeElement compositeElement,
    Predicate<DX.OpenXmlElement>? filter,
    DM.ElementCollection<ModelType> modelElementCollection,
    CompareOpenXmlElementMethod2<ItemType, ModelType> compareElementMethod,
    UpdateOpenXmlElementMethod2<ItemType, ModelType> updateElementMethod,
    CreateOpenXmlElementMethod2<ItemType, ModelType> createElementMethod)
  {
    var qualifiedElements = (filter != null)
      ? compositeElement.Elements<ItemType>().Where(item=>filter(item)).ToList()
      : compositeElement.Elements<ItemType>().ToList();
    var modelElements = new List<ModelType>(modelElementCollection);

    var sameElementsCount = 0;
    for (int i=0; i < qualifiedElements.Count && i< modelElements.Count; i++)
    {
      var openXmlElement = qualifiedElements[i];
      var modelElement = modelElements[i];
      if (!compareElementMethod(openXmlElement, modelElement, null, null)
        && !updateElementMethod(openXmlElement, modelElement))
        break;
      else
        sameElementsCount++;
    }
    if (sameElementsCount == qualifiedElements.Count && sameElementsCount ==  modelElements.Count)
      return true;
    if (sameElementsCount < qualifiedElements.Count)
      foreach (var openXmlElement in qualifiedElements.GetRange(sameElementsCount, qualifiedElements.Count-sameElementsCount))
        openXmlElement.Remove();
    if (sameElementsCount < modelElements.Count)
      foreach (var modelElement in modelElements.GetRange(sameElementsCount, modelElements.Count-sameElementsCount))
      {
        var openXmlElement = createElementMethod(modelElement);
        if (openXmlElement!=null)
         compositeElement.AppendChild(openXmlElement);
      }
    return true;
  }

  /// <summary>
  /// Updates the content of a composite openXml element based on model elements contained in model element collection.
  /// First, if filter is supplied, then child elements of composite openXml element are qualified to form a list.
  /// If there is no filter, then all child elements are qualified.
  /// Second, the qualified list of openXml elements is compared to model element collection (item by item).
  /// If all the items are equal, then then nothing is done and this method returns true.
  /// If diffs are found, then further processing is as following: Different openXml element is tried to update.
  /// Remaining openXml elements are removed. Remaining model elements create new openXml elements, which are added to 
  /// the composite element.
  /// </summary>
  /// <param name="compositeElement">Composite openXmlElement to update.</param>
  /// <param name="filter">Predicate to qualify openXmlElement. If null then all child element are qualified to update</param>
  /// <param name="modelElementCollection">Model element collection with valid items</param>
  /// <param name="compareElementMethod">Delegate to a method to compare openXml elements to model elements.</param>
  /// <param name="updateElementMethod">Delegate to a method to update openXml elements based on model elements.</param>
  /// <param name="createElementMethod">Delegate to a method to create openXml elements from model elements.</param>
  /// <param name="data">Additional parameter passed to delegate methods.</param>
  /// <returns><c>True</c> if update was successfull, <c>false</c> otherwise.</returns>
  public static bool UpdateOpenXmlElementCollection(DX.OpenXmlCompositeElement compositeElement,
    Predicate<DX.OpenXmlElement>? filter,
    DM.ElementCollection<ModelType> modelElementCollection,
    CompareOpenXmlElementMethod2Ext<ItemType, ModelType> compareElementMethod,
    UpdateOpenXmlElementMethod2Ext<ItemType, ModelType> updateElementMethod,
    CreateOpenXmlElementMethod2Ext<ItemType, ModelType> createElementMethod,
    object? data = null)
  {
    var qualifiedElements = (filter != null)
      ? compositeElement.Elements<ItemType>().Where(item=>filter(item)).ToList()
      : compositeElement.Elements<ItemType>().ToList();
    var modelElements = new List<ModelType>(modelElementCollection);

    var sameElementsCount = 0;
    for (int i=0; i < qualifiedElements.Count && i< modelElements.Count; i++)
    {
      var openXmlElement = qualifiedElements[i];
      var modelElement = modelElements[i];
      if (!compareElementMethod(openXmlElement, modelElement, null, null, data)
        && !updateElementMethod(openXmlElement, modelElement, data))
        break;
      else
        sameElementsCount++;
    }
    if (sameElementsCount == qualifiedElements.Count && sameElementsCount ==  modelElements.Count)
      return true;
    if (sameElementsCount < qualifiedElements.Count)
      foreach (var openXmlElement in qualifiedElements.GetRange(sameElementsCount, qualifiedElements.Count-sameElementsCount))
        openXmlElement.Remove();
    if (sameElementsCount < modelElements.Count)
      foreach (var modelElement in modelElements.GetRange(sameElementsCount, modelElements.Count-sameElementsCount))
      {
        var openXmlElement = createElementMethod(modelElement, data);
        if (openXmlElement!=null)
         compositeElement.AppendChild(openXmlElement);
      }
    return true;
  }
  #endregion
}
