namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.RubyContent"/> class from/to OpenXml converter.
/// </summary>
public static class RubyContentConverter
{
  #region RubyContent elements conversion.
  /// <summary>
  /// Creates item model element for RubyContent element item
  /// </summary>
  /// <param name="openXmlElement">Item element of RubyContent element</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  /// <exception cref="InvalidOperationException">Thrown if openXml element type is not recognized.</exception>
  public static DMW.IRubyContent? CreateRubyContentModelElement(DX.OpenXmlElement? openXmlElement, object? data = null)
  {
    if (openXmlElement is DXW.Run run)
      return DMXW.RunConverter.CreateModelElement(run);
    var hyperlinkGroupModel = RubyContentElementsConverter.CreateModelElement(openXmlElement);
    if (hyperlinkGroupModel != null)
      return hyperlinkGroupModel;


   var model = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (model != null)
      return model;

    var mathModel = DMXM.CommonMathConverter.CreateModelElement(openXmlElement);
     if (mathModel != null)
      return mathModel;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in SdtRunRubyConverter.CreateModelElement method");
    return null;
  }

  /// <summary>
  /// Compares RubyContent element item with a model element that was created from that openXml element
  /// </summary>
  /// <param name="openXmlElement">Item element of RubyContent element</param>
  /// <param name="model">A model element collection created from that openXmlElement.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to the openXmlElement, <c>false</c> otherwise</returns>
  public static bool CompareRubyContentElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null, object? data = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Run run && model is DMW.Run runModel)
        return DMXW.RunConverter.CompareModelElement(run, runModel, diffs, objName);
      if (model is DMW.IRubyContent rubyCuntentElement)
      {
        var result = RubyContentElementsConverter.CompareModelElement(openXmlElement, rubyCuntentElement, diffs, objName);
        if (result != null)
          return (bool)result;
      }

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      if (model is DMM.ICommonMathContent commonMathModel)
      {
        var result = DMXM.CommonMathConverter.CompareModelElement(openXmlElement, commonMathModel, diffs, objName);
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
  /// Creates a RubyContent element item based on a model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>
  /// <exception cref="InvalidOperationException">Thrown if a model element type is not recognized.</exception>
  public static OpenXmlElement CreateRubyContentOpenXmlElement(IModelElement model, object? data = null)
  {
    if (model is DMW.Run run)
      return DMXW.RunConverter.CreateOpenXmlElement(run);

    var result = RubyContentElementsConverter.CreateOpenXmlElement(model as DMW.IRubyContent);
    if (result != null) return result;

    result = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result != null) return result;

    result = DMXM.CommonMathConverter.CreateOpenXmlElement(model as DMM.ICommonMathContent);
    if (result != null) return result;

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in SdtRunRubyConverter.CreateOpenXmlParagraphContent method");
  }

  /// <summary>
  /// Updates a RubyContent element item based on a model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
  public static bool UpdateRubyContentOpenXmlElement(DX.OpenXmlElement openXmlElement, IModelElement model, object? data = null)
  {
    if (openXmlElement is DXW.SdtRunRuby SdtRunRuby && model is DMW.SdtRunRuby SdtRunRubyModel)
      return DMXW.SdtRunRubyConverter.UpdateOpenXmlElement(SdtRunRuby, SdtRunRubyModel);
    if (openXmlElement is DXW.CustomXmlRuby customXmlRun && model is DMW.CustomXmlRuby customXmlRunModel)
      return DMXW.CustomXmlRubyConverter.UpdateOpenXmlElement(customXmlRun, customXmlRunModel);
      if (openXmlElement is DXW.SimpleFieldRuby simpleField && model is DMW.SimpleFieldRuby simpleFieldModel)
        return DMXW.SimpleFieldRubyConverter.UpdateOpenXmlElement(simpleField, simpleFieldModel);
      if (openXmlElement is DXW.HyperlinkRuby hyperlink && model is DMW.HyperlinkRuby hyperlinkModel)
        return DMXW.HyperlinkRubyConverter.UpdateOpenXmlElement(hyperlink, hyperlinkModel);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.UpdateOpenXmlElement(openXmlElement, commonElementModel);
        if (result != null)
          return (bool)result;
      }
      if (model is DMM.ICommonMathContent commonMathModel)
      {
        var result = DMXM.CommonMathConverter.UpdateOpenXmlElement(openXmlElement, commonMathModel);
        if (result != null)
          return (bool)result;
      }

    return false;
  }
  #endregion

  #region RubyContent model conversion.
  public static DMW.RubyContent? CreateModelElement(DXW.RubyContent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RubyContent();
      ElementCollectionConverter<DMW.IRubyContent>.FillModelElementCollection(openXmlElement, model,
        RubyContentConverter.CreateRubyContentModelElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RubyContent? openXmlElement, DMW.RubyContent? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMW.IRubyContent>.CompareOpenXmlElementCollection(openXmlElement, model,
        RubyContentConverter.CompareRubyContentElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RubyContent model)
    where OpenXmlElementType: DXW.RubyContent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.RubyContent openXmlElement, DMW.RubyContent model)
  {
    return ElementCollectionConverter<DMW.IRubyContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      RubyContentConverter.CompareRubyContentElement,
      RubyContentConverter.UpdateRubyContentOpenXmlElement,
      RubyContentConverter.CreateRubyContentOpenXmlElement);
  }
  #endregion
}
