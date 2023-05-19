namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion method for common paragraph content elements: Run, Hyperlink, SimpleField, 
/// CustomXmlRun, SdtRun, 
/// Also converts CommonMarkers, CommonMath,
/// BidirectionalOverride, BidirectionalEmbedding, SubDocumentReference.
/// </summary>
public static class ParagraphContentConverter
{
  #region Paragraph content conversion
  public static DM.IModelElement? CreateParagraphContent(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Run run)
      return DMXW.RunConverter.CreateModelElement(run);

    var hyperElement = HyperlinkGroupConverter.CreateModelElement(openXmlElement);
    if (hyperElement != null)
      return hyperElement;

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    var commonMathElement = DMXM.CommonMathConverter.CreateModelElement(openXmlElement);
    if (commonMathElement != null)
      return commonMathElement;

    var bidirSubDocElement = BidirAndSubdocConverter.CreateModelElement(openXmlElement);
    if (bidirSubDocElement != null)
      return bidirSubDocElement;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in ParagraphContentConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareParagraphContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Run run && model is DMW.Run runModel)
        return DMXW.RunConverter.CompareModelElement(run, runModel, diffs, objName);

      var result1 = DMXW.HyperlinkGroupConverter.CompareModelElement(openXmlElement, model, diffs, objName);
      if (result1 != null)
        return (bool)result1;

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result2 = DMXW.CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result2 != null)
          return (bool)result2;
      }
      if (model is DMM.ICommonMathContent commonMathModel)
      {
        var result3 = DMXM.CommonMathConverter.CompareModelElement(openXmlElement, commonMathModel, diffs, objName);
        if (result3 != null)
          return (bool)result3;
      }
      var result4 = DMXW.BidirAndSubdocConverter.CompareModelElement(openXmlElement, model, diffs, objName);
      if (result4 != null)
        return (bool)result4;

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

    var result1 = DMXW.HyperlinkGroupConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result1 != null) return result1;

    var result2 = DMXW.CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result2 != null) return result2;

    var result3 = DMXM.CommonMathConverter.CreateOpenXmlElement(model as DMM.ICommonMathContent);
    if (result3 != null) return result3;

    var result4 = DMXW.BidirAndSubdocConverter.CreateOpenXmlElement(model);
    if (result4 != null) return result4;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in ParagraphContentConverter.CreateOpenXmlParagraphContent method");
  }

  public static bool UpdateOpenXmlParagraphContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Run run && model is DMW.Run runModel)
        return DMXW.RunConverter.UpdateOpenXmlElement(run, runModel);

      var result1 = DMXW.HyperlinkGroupConverter.UpdateOpenXmlElement(openXmlElement, model);
      if (result1 != null)
        return (bool)result1;

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result2 = CommonMarkersConverter.UpdateOpenXmlElement(openXmlElement, commonElementModel);
        if (result2 != null)
          return (bool)result2;
      }
      if (model is DMM.ICommonMathContent commonMathModel)
      {
        var result3 = DMXM.CommonMathConverter.UpdateOpenXmlElement(openXmlElement, commonMathModel);
        if (result3 != null)
          return (bool)result3;
      }

      var result4 = DMXW.BidirAndSubdocConverter.UpdateOpenXmlElement(openXmlElement, model);
      if (result4 != null)
        return (bool)result4;

      return true;
    }
    return false;
  }
  #endregion
}
