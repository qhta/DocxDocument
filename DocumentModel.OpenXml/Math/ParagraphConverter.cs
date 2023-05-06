namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Paragraph"/> class from/to OpenXml converter.
/// </summary>
public static class ParagraphConverter
{
  #region Office Math Paragraph Properties conversion.
  private static DMM.ParagraphProperties? GetParagraphProperties(DXM.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ParagraphProperties>();
    if (element != null)
      return DMXM.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraphProperties(DXM.Paragraph openXmlElement, DMM.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetParagraphProperties(DXM.Paragraph openXmlElement, DMM.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ParagraphPropertiesConverter.CreateOpenXmlElement<DXM.ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region MathParagraph content conversion
  public static DM.IModelElement? CreateMathParagraphContent(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXM.OfficeMath oMath)
      return DMXM.OfficeMathConverter.CreateModelElement(oMath);
    if (openXmlElement is DXM.Run run)
      return DMXM.RunConverter.CreateModelElement(run);
    return DMXW.ParagraphContentConverter.CreateParagraphContent(openXmlElement);
  }

  public static bool CompareMathParagraphContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.OfficeMath oMath && model is DMM.OfficeMath oMathModel)
        return DMXM.OfficeMathConverter.CompareModelElement(oMath, oMathModel, diffs, objName);
      if (openXmlElement is DXM.Run run && model is DMM.Run runModel)
        return DMXM.RunConverter.CompareModelElement(run, runModel, diffs, objName);
    }
    return DMXW.ParagraphContentConverter.CompareParagraphContent(openXmlElement, model, diffs);
  }

  public static OpenXmlElement CreateOpenXmlMathParagraphContent(DM.IModelElement model)
  {
    if (model is DMM.OfficeMath oMath)
      return DMXM.OfficeMathConverter.CreateOpenXmlElement(oMath);
    if (model is DMM.Run run)
      return DMXM.RunConverter.CreateOpenXmlElement(run);
    return DMXW.ParagraphContentConverter.CreateOpenXmlParagraphContent(model);
  }

  public static bool UpdateOpenXmlMathParagraphContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.OfficeMath oMath && model is DMM.OfficeMath oMathModel)
        return DMXM.OfficeMathConverter.UpdateOpenXmlElement(oMath, oMathModel);
      if (openXmlElement is DXM.Run run && model is DMM.Run runModel)
        return DMXM.RunConverter.UpdateOpenXmlElement(run, runModel);
    }
    return DMXW.ParagraphContentConverter.UpdateOpenXmlParagraphContent(openXmlElement, model);
  }
  #endregion

  #region MathParagraph model conversion.
  public static DMM.Paragraph? CreateModelElement(DXM.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Paragraph();
      model.ParagraphProperties = GetParagraphProperties(openXmlElement);
      ElementCollectionConverter<DMM.IMathParagraphContent>.FillModelElementCollection(
        openXmlElement.Where(item=>item is not DXM.ParagraphProperties), model,
       CreateMathParagraphContent);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Paragraph? openXmlElement, DMM.Paragraph? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpParagraphProperties(openXmlElement, model.ParagraphProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMM.IMathParagraphContent>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item=>item is not DXM.ParagraphProperties), model,
        CompareMathParagraphContent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Paragraph CreateOpenXmlElement(DMM.Paragraph model)
  {
    var openXmlElement = new DXM.Paragraph();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Paragraph openXmlElement, DMM.Paragraph model)
  {
    SetParagraphProperties(openXmlElement, model.ParagraphProperties);
    return ElementCollectionConverter<DMM.IMathParagraphContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareMathParagraphContent, UpdateOpenXmlMathParagraphContent, CreateOpenXmlMathParagraphContent);
  }
  #endregion
}
