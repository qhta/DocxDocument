using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run-Level Structured Document Tag.
/// </summary>
public static class SdtRunConverter
{

  #region SdtContentRun elements conversion

    /// <summary>
  /// Creates item model element for SdtContentRun element item
  /// </summary>
  /// <param name="openXmlElement">Item element of SdtContentRun element</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  /// <exception cref="InvalidOperationException">Thrown if openXml element type is not recognized.</exception>
  public static DMW.ISdtRunContent? CreateSdtContentRunModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Run run)
      return DMXW.RunConverter.CreateModelElement(run);
    if (openXmlElement is DXW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateModelElement(sdtRun);
    if (openXmlElement is DXW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateModelElement(customXmlRun);
    if (openXmlElement is DXW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateModelElement(simpleField);
    if (openXmlElement is DXW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateModelElement(hyperlink);
    if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(bidirectionalOverride);
    if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(bidirectionalEmbedding);
    if (openXmlElement is DXW.SubDocumentReference subDocumentReference)
      return DMXW.RelationshipTypeConverter.CreateModelElement(subDocumentReference);

   var model = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (model != null)
      return model;

    var mathModel = CommonMathConverter.CreateModelElement(openXmlElement);
     if (mathModel != null)
      return mathModel;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in SdtRunConverter.CreateModelElement method");
    return null;
  }

  /// <summary>
  /// Compares SdtContentRun element item with a model element that was created from that openXml element
  /// </summary>
  /// <param name="openXmlElement">Item element of SdtContentRun element</param>
  /// <param name="model">A model element collection created from that openXmlElement.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to the openXmlElement, <c>false</c> otherwise</returns>
  public static bool CompareSdtContentRunElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Run run && model is DMW.Run runModel)
        return DMXW.RunConverter.CompareModelElement(run, runModel, diffs, objName);
      if (openXmlElement is DXW.SdtRun sdtRun && model is DMW.SdtRun sdtRunModel)
        return DMXW.SdtRunConverter.CompareModelElement(sdtRun, sdtRunModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRun customXmlRun && model is DMW.CustomXmlRun customXmlRunModel)
        return DMXW.CustomXmlRunConverter.CompareModelElement(customXmlRun, customXmlRunModel, diffs, objName);
      if (openXmlElement is DXW.SimpleField simpleField && model is DMW.SimpleField simpleFieldModel)
        return DMXW.SimpleFieldConverter.CompareModelElement(simpleField, simpleFieldModel, diffs, objName);
      if (openXmlElement is DXW.Hyperlink hyperlink && model is DMW.Hyperlink hyperlinkModel)
        return DMXW.HyperlinkConverter.CompareModelElement(hyperlink, hyperlinkModel, diffs, objName);
      if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride && model is DMW.BidirectionalOverride bidirectionalOverrideModel)
        return DMXW.BidirectionalOverrideConverter.CompareModelElement(bidirectionalOverride, bidirectionalOverrideModel, diffs, objName);
      if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding && model is DMW.BidirectionalEmbedding bidirectionalEmbeddingModel)
        return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(bidirectionalEmbedding, bidirectionalEmbeddingModel, diffs, objName);
      if (openXmlElement is DXW.SubDocumentReference subDocumentReference && model is DMW.SubDocumentReference subDocumentReferenceModel)
        return DMXW.RelationshipTypeConverter.CompareModelElement(subDocumentReference, subDocumentReferenceModel, diffs, objName);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      if (model is DMMath.ICommonMathContent commonMathModel)
      {
        var result = CommonMathConverter.CompareModelElement(openXmlElement, commonMathModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "@Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  /// <summary>
  /// Creates a SdtContentRun element item based on a model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>
  /// <exception cref="InvalidOperationException">Thrown if a model element type is not recognized.</exception>
  public static OpenXmlElement CreateSdtContentRunOpenXmlElement(IModelElement model)
  {
    if (model is DMW.Run run)
      return DMXW.RunConverter.CreateOpenXmlElement(run);
    if (model is DMW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateOpenXmlElement(sdtRun);
    if (model is DMW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateOpenXmlElement(customXmlRun);
    if (model is DMW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateOpenXmlElement(simpleField);
    if (model is DMW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateOpenXmlElement(hyperlink);
    if (model is DMW.BidirectionalOverride bidirectionalOverride)
      return DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement(bidirectionalOverride);
    if (model is DMW.BidirectionalEmbedding bidirectionalEmbedding)
      return DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement(bidirectionalEmbedding);
    if (model is DMW.SubDocumentReference subDocumentReference)
      return DMXW.RelationshipTypeConverter.CreateOpenXmlElement(subDocumentReference);

    var result = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result != null) return result;

    var mathResult = CommonMathConverter.CreateOpenXmlElement(model as DMMath.ICommonMathContent);
    if (mathResult != null) return mathResult;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in SdtRunConverter.CreateOpenXmlParagraphContent method");
  }

  /// <summary>
  /// Updates a SdtContentRun element item based on a model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
  public static bool UpdateSdtContentRunOpenXmlElement(DX.OpenXmlElement openXmlElement, IModelElement model)
  {
    if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
      return DMXW.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
    if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
      return DMXW.TableConverter.UpdateOpenXmlElement(table, tableModel);
    if (openXmlElement is DXW.SdtRun sdtRun && model is DMW.SdtRun sdtRunModel)
      return DMXW.SdtRunConverter.UpdateOpenXmlElement(sdtRun, sdtRunModel);
    if (openXmlElement is DXW.CustomXmlRun customXmlRun && model is DMW.CustomXmlRun customXmlRunModel)
      return DMXW.CustomXmlRunConverter.UpdateOpenXmlElement(customXmlRun, customXmlRunModel);
      if (openXmlElement is DXW.SimpleField simpleField && model is DMW.SimpleField simpleFieldModel)
        return DMXW.SimpleFieldConverter.UpdateOpenXmlElement(simpleField, simpleFieldModel);
      if (openXmlElement is DXW.Hyperlink hyperlink && model is DMW.Hyperlink hyperlinkModel)
        return DMXW.HyperlinkConverter.UpdateOpenXmlElement(hyperlink, hyperlinkModel);
      if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride && model is DMW.BidirectionalOverride bidirectionalOverrideModel)
        return DMXW.BidirectionalOverrideConverter.UpdateOpenXmlElement(bidirectionalOverride, bidirectionalOverrideModel);
      if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding && model is DMW.BidirectionalEmbedding bidirectionalEmbeddingModel)
        return DMXW.BidirectionalEmbeddingConverter.UpdateOpenXmlElement(bidirectionalEmbedding, bidirectionalEmbeddingModel);
      if (openXmlElement is DXW.SubDocumentReference subDocumentReference && model is DMW.SubDocumentReference subDocumentReferenceModel)
        return DMXW.RelationshipTypeConverter.UpdateOpenXmlElement(subDocumentReference, subDocumentReferenceModel);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.UpdateOpenXmlElement(openXmlElement, commonElementModel);
        if (result != null)
          return (bool)result;
      }
      if (model is DMMath.ICommonMathContent commonMathModel)
      {
        var result = CommonMathConverter.UpdateOpenXmlElement(openXmlElement, commonMathModel);
        if (result != null)
          return (bool)result;
      }

    return false;
  }

  #endregion


  #region StdRun conversion

  /// <summary>
  /// Creates a model element for a SdtRun element.
  /// </summary>
  /// <param name="openXmlElement">SdtBlock element read from DocumentFormat.OpenXml document</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  public static DMW.SdtRun? CreateModelElement(DXW.SdtRun? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SdtRun();
      model.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      model.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      ElementCollectionConverter<DMW.ISdtRunContent>.FillModelElementCollection(openXmlElement.SdtContentRun, model, 
        (CreateModelElementMethod)CreateSdtContentRunModelElement);
      return model;
    }
    return null;
  }

  /// <summary>
  /// Compares a SdtRun openXml element and a SdtRun model element that was created from that openXml element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="model">A model element created from the openXml element.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to openXml element, <c>false</c> otherwise</returns>
  public static bool CompareModelElement(DXW.SdtRun? openXmlElement, DMW.SdtRun? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, model.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.ISdtRunContent>.CompareOpenXmlElementCollection(openXmlElement.SdtContentRun, model,
        (CompareOpenXmlElementMethod)CompareSdtContentRunElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  /// <summary>
  /// Creates a SdtRun openXml element based on a SdtRun model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>

  public static DXW.SdtRun CreateOpenXmlElement(DMW.SdtRun value)
  {
    var openXmlElement = new DXW.SdtRun();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  /// <summary>
  /// Updates a SdtRun element based on a SdtRun model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>

  public static bool UpdateOpenXmlElement(DXW.SdtRun openXmlElement, DMW.SdtRun model)
  {
    SdtElementConverter.SetSdtProperties(openXmlElement, model.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties);
    return ElementCollectionConverter<DMW.ISdtRunContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      (CompareOpenXmlElementMethod)CompareSdtContentRunElement,
      (UpdateOpenXmlElementMethod)UpdateSdtContentRunOpenXmlElement,
      (CreateOpenXmlElementMethod)CreateSdtContentRunOpenXmlElement);
  }
  #endregion

}
