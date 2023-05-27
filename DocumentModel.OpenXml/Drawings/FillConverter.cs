namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DMD.Fill"/> abstract class from/to OpenXml converter.
/// </summary>
public static class FillConverter
{
  #region Methods to switch fill conversion.
  public static DM.IModelElement? CreateFill(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXD.NoFill)
      return new DMD.NoFill();

    if (openXmlElement is DXD.SolidFill solidFill)
      return DMXD.SolidFillConverter.CreateModelElement(solidFill);

    if (openXmlElement is DXD.GradientFill gradientFill)
      return DMXD.GradientFillConverter.CreateModelElement(gradientFill);

    if (openXmlElement is DXD.BlipFill blipFill)
      return DMXD.BlipFillConverter.CreateModelElement(blipFill);

    if (openXmlElement is DXD.PatternFill patternFill)
      return DMXD.PatternFillConverter.CreateModelElement(patternFill);

    if (openXmlElement is DXD.GroupFill)
      return new DMD.GroupFill();

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in FillConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareFill(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model,
    DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXD.NoFill && model is DMD.NoFill)
        return true;

      if (openXmlElement is DXD.SolidFill solidFillElement && model is DMD.SolidFill solidFillModel)
        return DMXD.SolidFillConverter.CompareModelElement(solidFillElement, solidFillModel, diffs, objName, propName);

      if (openXmlElement is DXD.GradientFill gradientFillElement && model is DMD.GradientFill gradientFillModel)
        return DMXD.GradientFillConverter.CompareModelElement(gradientFillElement, gradientFillModel, diffs, objName, propName);

      if (openXmlElement is DXD.BlipFill blipFillElement && model is DMD.BlipFill blipFillModel)
        return DMXD.BlipFillConverter.CompareModelElement(blipFillElement, blipFillModel, diffs, objName, propName);

      if (openXmlElement is DXD.PatternFill patternFillElement && model is DMD.PatternFill patternFillModel)
        return DMXD.PatternFillConverter.CompareModelElement(patternFillElement, patternFillModel, diffs, objName, propName);

      if (openXmlElement is DXD.GroupFill && model is DMD.GroupFill)
        return true;

      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlFillElement(DM.IModelElement model)
  {
    if (model is DMD.NoFill)
      return new DXD.NoFill();

    if (model is DMD.SolidFill solidFillModel)
      return DMXD.SolidFillConverter.CreateOpenXmlElement(solidFillModel);

    if (model is DMD.GradientFill gradientFillModel)
      return DMXD.GradientFillConverter.CreateOpenXmlElement(gradientFillModel);

    if (model is DMD.BlipFill blipFillModel)
      return DMXD.BlipFillConverter.CreateOpenXmlElement(blipFillModel);

    if (model is DMD.PatternFill patternFillModel)
      return DMXD.PatternFillConverter.CreateOpenXmlElement(patternFillModel);

    if (model is DMD.GroupFill)
      return new DXD.GroupFill();

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in ParagraphContentConverter.CreateOpenXmlParagraphContent method");
  }

  public static bool UpdateOpenXmlFillElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXD.NoFill && model is DMD.NoFill)
        return true;

      if (openXmlElement is DXD.SolidFill solidFillElement && model is DMD.SolidFill solidFillModel)
        return DMXD.SolidFillConverter.UpdateOpenXmlElement(solidFillElement, solidFillModel);

      if (openXmlElement is DXD.GradientFill gradientFillElement && model is DMD.GradientFill gradientFillModel)
        return DMXD.GradientFillConverter.UpdateOpenXmlElement(gradientFillElement, gradientFillModel);

      if (openXmlElement is DXD.BlipFill blipFillElement && model is DMD.BlipFill blipFillModel)
        return DMXD.BlipFillConverter.UpdateOpenXmlElement(blipFillElement, blipFillModel);

      if (openXmlElement is DXD.PatternFill patternFillElement && model is DMD.PatternFill patternFillModel)
        return DMXD.PatternFillConverter.UpdateOpenXmlElement(patternFillElement, patternFillModel);

      if (openXmlElement is DXD.GroupFill && model is DMD.GroupFill)
        return true;

      return true;
    }
    return false;
  }
  #endregion

  #region Methods to convert a bunch of fill specifying elements.

  private static bool IsFillElement(DX.OpenXmlElement element)
    => element is DXD.NoFill
        || element is DXD.SolidFill
        || element is DXD.GradientFill
        || element is DXD.BlipFill
        || element is DXD.PatternFill
        || element is DXD.GroupFill;

  public static DMD.Fill? CreateFillModel(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var fillElement = openXmlElement.Elements().FirstOrDefault(element => IsFillElement(element));
      var model = FillConverter.CreateFill(fillElement);
      return model as DMD.Fill;
    }
    return null;
  }

  public static bool CompareFillModel(DX.OpenXmlCompositeElement? openXmlElement, DMD.Fill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var fillElement = openXmlElement.Elements().FirstOrDefault(element => IsFillElement(element));
      return FillConverter.CompareFill(fillElement, model, diffs, objName, propName);
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateFillElement<OpenXmlElementType>(DMD.Fill model)
    where OpenXmlElementType : DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateFillElement(DX.OpenXmlCompositeElement openXmlElement, DMD.Fill model)
  {
    var fillElement = openXmlElement.Elements().FirstOrDefault(element => IsFillElement(element));
    if (fillElement!=null && FillConverter.UpdateOpenXmlFillElement(fillElement, model))
      return true;
    var element = FillConverter.CreateOpenXmlFillElement(model);
    if (element != null)
    {
      openXmlElement.AddChild(element);
      return true;
    }
    return false;
  }
  #endregion

  #region Methods to convert an element which contains a single fill element.
  public static DMD.Fill? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = FillConverter.CreateFill(openXmlElement.Elements().FirstOrDefault());
      return model as DMD.Fill;
    }
    return null;
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMD.Fill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      return FillConverter.CompareFill(openXmlElement.Elements().FirstOrDefault(), model, diffs, objName, propName);
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Fill model)
    where OpenXmlElementType : DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMD.Fill model)
  {
    openXmlElement.RemoveAllChildren();
    var element = FillConverter.CreateOpenXmlFillElement(model);
    if (element != null)
    {
      openXmlElement.AddChild(element);
      return true;
    }
    return false;
  }
  #endregion
}