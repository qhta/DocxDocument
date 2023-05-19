namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Denominator"/> class from/to OpenXml converter.
/// </summary>
public static class DenominatorConverter
{
  #region ArgumentProperties conversion.
  private static DMM.ArgumentProperties? GetArgumentProperties(DXM.Denominator openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ArgumentProperties>();
    if (element != null)
      return DMXM.ArgumentPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgumentProperties(DXM.Denominator openXmlElement, DMM.ArgumentProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ArgumentProperties>(), value, diffs, objName);
  }
  
  private static void SetArgumentProperties(DXM.Denominator openXmlElement, DMM.ArgumentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ArgumentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ArgumentPropertiesConverter.CreateOpenXmlElement<DXM.ArgumentProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMM.Accent? GetAccent(DXM.Denominator openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Accent>();
    if (element != null)
      return DMXM.AccentConverter.CreateModelElement(element);
    return null;
  }
  #endregion
  
  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.Denominator openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.Denominator openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.Denominator openXmlElement, DMM.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Denominator content conversion
  public static DMM.IMathArgumentContent? CreateDenominatorContent(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXM.Run run)
      return DMXM.RunConverter.CreateModelElement(run);
    if (openXmlElement is DXM.Paragraph paragraph)
      return DMXM.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXW.ContentPart contentPart)
      return DMXW.ContentPartConverter.CreateModelElement(contentPart);
    if (openXmlElement is DXW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateModelElement(hyperlink);
    if (openXmlElement is DXW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateModelElement(customXmlRun);
    if (openXmlElement is DXW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateModelElement(simpleField);
    if (openXmlElement is DXW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateModelElement(sdtRun);

    var commonMarker = DMXW.CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    var commonMathElement = DMXM.CommonMathConverter.CreateModelElement(openXmlElement);
    if (commonMathElement != null)
      return commonMathElement;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in DenominatorContentConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareDenominatorContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.Run run && model is DMM.Run runModel)
        return DMXM.RunConverter.CompareModelElement(run, runModel, diffs, objName);
      if (openXmlElement is DXM.Paragraph paragraph && model is DMM.Paragraph paragraphModel)
        return DMXM.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXW.ContentPart contentPart && model is DMW.ContentPart contentPartModel)
        return DMXW.ContentPartConverter.CompareModelElement(contentPart, contentPartModel, diffs, objName);
      if (openXmlElement is DXW.Hyperlink hyperlink && model is DMW.Hyperlink hyperlinkModel)
        return DMXW.HyperlinkConverter.CompareModelElement(hyperlink, hyperlinkModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRun customXmlRun && model is DMW.CustomXmlRun customXmlRunModel)
        return DMXW.CustomXmlRunConverter.CompareModelElement(customXmlRun, customXmlRunModel, diffs, objName);
      if (openXmlElement is DXW.SimpleField simpleField && model is DMW.SimpleField simpleFieldModel)
        return DMXW.SimpleFieldConverter.CompareModelElement(simpleField, simpleFieldModel, diffs, objName);
      if (openXmlElement is DXW.SdtRun sdtRun && model is DMW.SdtRun sdtRunModel)
        return DMXW.SdtRunConverter.CompareModelElement(sdtRun, sdtRunModel, diffs, objName);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = DMXW.CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      if (model is DMM.ICommonMathContent commonMathModel)
      {
        var result = DMXM.CommonMathConverter.CompareModelElement(openXmlElement, commonMathModel, diffs, objName);
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

  public static OpenXmlElement CreateOpenXmlDenominatorContent(DM.IModelElement model)
  {
    if (model is DMM.Run run)
      return DMXM.RunConverter.CreateOpenXmlElement(run);
    if (model is DMM.Paragraph paragraph)
      return DMXM.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (model is DMW.ContentPart contentPart)
      return DMXW.ContentPartConverter.CreateOpenXmlElement(contentPart);
    if (model is DMW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateOpenXmlElement(hyperlink);
    if (model is DMW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateOpenXmlElement(customXmlRun);
    if (model is DMW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateOpenXmlElement(simpleField);
    if (model is DMW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateOpenXmlElement(sdtRun);

    var commonMarker = DMXW.CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (commonMarker != null) return commonMarker;

    var commonMathElement = DMXM.CommonMathConverter.CreateOpenXmlElement(model as DMM.ICommonMathContent);
    if (commonMathElement != null) return commonMathElement;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in DenominatorContentConverter.CreateOpenXmlDenominatorContent method");
  }

  public static bool UpdateOpenXmlDenominatorContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.Run run && model is DMM.Run runModel)
        return DMXM.RunConverter.UpdateOpenXmlElement(run, runModel);
      if (openXmlElement is DXM.Paragraph paragraph && model is DMM.Paragraph paragraphModel)
        return DMXM.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
      if (openXmlElement is DXW.ContentPart contentPart && model is DMW.ContentPart contentPartModel)
        return DMXW.ContentPartConverter.UpdateOpenXmlElement(contentPart, contentPartModel);
      if (openXmlElement is DXW.Hyperlink hyperlink && model is DMW.Hyperlink hyperlinkModel)
        return DMXW.HyperlinkConverter.UpdateOpenXmlElement(hyperlink, hyperlinkModel);
      if (openXmlElement is DXW.CustomXmlRun customXmlRun && model is DMW.CustomXmlRun customXmlRunModel)
        return DMXW.CustomXmlRunConverter.UpdateOpenXmlElement(customXmlRun, customXmlRunModel);
      if (openXmlElement is DXW.SimpleField simpleField && model is DMW.SimpleField simpleFieldModel)
        return DMXW.SimpleFieldConverter.UpdateOpenXmlElement(simpleField, simpleFieldModel);
      if (openXmlElement is DXW.SdtRun sdtRun && model is DMW.SdtRun sdtRunModel)
        return DMXW.SdtRunConverter.UpdateOpenXmlElement(sdtRun, sdtRunModel);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = DMXW.CommonMarkersConverter.UpdateOpenXmlElement(openXmlElement, commonElementModel);
        if (result != null)
          return (bool)result;
      }
      if (model is DMM.ICommonMathContent commonMathModel)
      {
        var result = DMXM.CommonMathConverter.UpdateOpenXmlElement(openXmlElement, commonMathModel);
        if (result != null)
          return (bool)result;
      }
      return true;
    }
    return false;
  }
  #endregion

  #region Denominator model conversion.
  public static DMM.Denominator? CreateModelElement(DXM.Denominator? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Denominator();
      model.ArgumentProperties = GetArgumentProperties(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      ElementCollectionConverter<DMM.IMathArgumentContent>.FillModelElementCollection(
        openXmlElement.Where(item=>item is not DXM.ArgumentProperties && item is not DXM.ControlProperties), model,
        CreateDenominatorContent);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Denominator? openXmlElement, DMM.Denominator? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpArgumentProperties(openXmlElement, model.ArgumentProperties, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMM.IMathArgumentContent>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item=>item is not DXM.ArgumentProperties && item is not DXM.ControlProperties), model,
        CompareDenominatorContent, diffs, objName))
        ok = false;

      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.Denominator value)
    where OpenXmlElementType: DXM.Denominator, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Denominator openXmlElement, DMM.Denominator model)
  {
    SetArgumentProperties(openXmlElement, model.ArgumentProperties);
    SetControlProperties(openXmlElement, model.ControlProperties);
    return ElementCollectionConverter<DMM.IMathArgumentContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareDenominatorContent,
      UpdateOpenXmlDenominatorContent,
      CreateOpenXmlDenominatorContent);
  }
  #endregion
}
