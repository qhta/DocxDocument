namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion method for common paragraph content elements: Run, Hyperlink, SimpleField, 
/// CustomXmlRun, SdtRun, BidirectionalOverride, BidirectionalEmbedding, SubDocumentReference.
/// Also converts CommonMarkers and CommonMath.
/// </summary>
public static class ParagraphContentConverter
{
  #region Paragraph content conversion
  public static DM.IModelElement? CreateParagraphContent(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.ParagraphProperties)
      return null;
    if (openXmlElement is DXW.Run run)
      return DMXW.RunConverter.CreateModelElement(run);
    if (openXmlElement is DXW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateModelElement(hyperlink);
    if (openXmlElement is DXW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateModelElement(customXmlRun);
    if (openXmlElement is DXW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateModelElement(simpleField);
    if (openXmlElement is DXW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateModelElement(sdtRun);
    if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(bidirectionalOverride);
    if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(bidirectionalEmbedding);
    if (openXmlElement is DXW.SubDocumentReference subDocumentReference)
      return DMXW.RelationshipTypeConverter.CreateModelElement(subDocumentReference);

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    var commonMathElement = CommonMathConverter.CreateModelElement(openXmlElement);
    if (commonMathElement != null)
      return commonMathElement;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in ParagraphContentConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareParagraphContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Run run && model is DMW.Run runModel)
        return DMXW.RunConverter.CompareModelElement(run, runModel, diffs, objName);
      if (openXmlElement is DXW.Hyperlink hyperlink && model is DMW.Hyperlink hyperlinkModel)
        return DMXW.HyperlinkConverter.CompareModelElement(hyperlink, hyperlinkModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRun customXmlRun && model is DMW.CustomXmlRun customXmlRunModel)
        return DMXW.CustomXmlRunConverter.CompareModelElement(customXmlRun, customXmlRunModel, diffs, objName);
      if (openXmlElement is DXW.SimpleField simpleField && model is DMW.SimpleField simpleFieldModel)
        return DMXW.SimpleFieldConverter.CompareModelElement(simpleField, simpleFieldModel, diffs, objName);
      if (openXmlElement is DXW.SdtRun sdtRun && model is DMW.SdtRun sdtRunModel)
        return DMXW.SdtRunConverter.CompareModelElement(sdtRun, sdtRunModel, diffs, objName);
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
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlParagraphContent(DM.IModelElement model)
  {
    if (model is DMW.Run run)
      return DMXW.RunConverter.CreateOpenXmlElement(run);
    if (model is DMW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateOpenXmlElement(hyperlink);
    if (model is DMW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateOpenXmlElement(customXmlRun);
    if (model is DMW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateOpenXmlElement(simpleField);
    if (model is DMW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateOpenXmlElement(sdtRun);
    if (model is DMW.BidirectionalOverride bidirectionalOverride)
      return DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement(bidirectionalOverride);
    if (model is DMW.BidirectionalEmbedding bidirectionalEmbedding)
      return DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement(bidirectionalEmbedding);
    if (model is DMW.SubDocumentReference subDocumentReference)
      return DMXW.RelationshipTypeConverter.CreateOpenXmlElement(subDocumentReference);

    var commonMarker = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (commonMarker != null) return commonMarker;

    var commonMathElement = CommonMathConverter.CreateOpenXmlElement(model as DMMath.ICommonMathContent);
    if (commonMathElement != null) return commonMathElement;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in ParagraphContentConverter.CreateOpenXmlParagraphContent method");
  }

  public static bool UpdateOpenXmlParagraphContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Run run && model is DMW.Run runModel)
        return DMXW.RunConverter.UpdateOpenXmlElement(run, runModel);
      if (openXmlElement is DXW.Hyperlink hyperlink && model is DMW.Hyperlink hyperlinkModel)
        return DMXW.HyperlinkConverter.UpdateOpenXmlElement(hyperlink, hyperlinkModel);
      if (openXmlElement is DXW.CustomXmlRun customXmlRun && model is DMW.CustomXmlRun customXmlRunModel)
        return DMXW.CustomXmlRunConverter.UpdateOpenXmlElement(customXmlRun, customXmlRunModel);
      if (openXmlElement is DXW.SimpleField simpleField && model is DMW.SimpleField simpleFieldModel)
        return DMXW.SimpleFieldConverter.UpdateOpenXmlElement(simpleField, simpleFieldModel);
      if (openXmlElement is DXW.SdtRun sdtRun && model is DMW.SdtRun sdtRunModel)
        return DMXW.SdtRunConverter.UpdateOpenXmlElement(sdtRun, sdtRunModel);
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
      return true;
    }
    return false;
  }
  #endregion
}
