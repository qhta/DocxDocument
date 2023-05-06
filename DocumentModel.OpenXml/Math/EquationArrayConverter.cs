namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.EquationArray"/> class from/to OpenXml converter.
/// </summary>
public static class EquationArrayConverter
{
  #region EquationArray Properties conversion.
  private static DMM.EquationArrayProperties? GetEquationArrayProperties(DXM.EquationArray openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.EquationArrayProperties>();
    if (element != null)
      return DMXM.EquationArrayPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpEquationArrayProperties(DXM.EquationArray openXmlElement, DMM.EquationArrayProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.EquationArrayPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.EquationArrayProperties>(), value, diffs, objName);
  }

  private static void SetEquationArrayProperties(DXM.EquationArray openXmlElement, DMM.EquationArrayProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.EquationArrayProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.EquationArrayPropertiesConverter.CreateOpenXmlElement<DXM.EquationArrayProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base element conversion.
  private static DMM.Argument? CreateBaseElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXM.Base baseElement)
      return DMXM.ArgumentConverter.CreateModelElement(baseElement);

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in EquationArrayConverter.CreateBaseElement method");
    return null;
  }

  public static bool CompareBaseElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.Base baseElement && model is DMM.Argument baseModel)
        return DMXM.ArgumentConverter.CompareModelElement(baseElement, baseModel, diffs, objName);
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlBaseElement(DM.IModelElement model)
  {
    if (model is DMM.Argument baseModel)
      return DMXM.ArgumentConverter.CreateOpenXmlElement(baseModel);

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in EquationArrayConverter.CreateOpenXmlArgumentContent method");
  }

  public static bool UpdateOpenXmlBaseElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.Base baseElement && model is DMM.Argument baseModel)
        return DMXM.ArgumentConverter.UpdateOpenXmlElement(baseElement, baseModel);
      return true;
    }
    return false;
  }
  #endregion

  #region EquationArray model conversion.
  public static DMM.EquationArray? CreateModelElement(DXM.EquationArray? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.EquationArray();
      model.EquationArrayProperties = GetEquationArrayProperties(openXmlElement);
      ElementCollectionConverter<DMM.Argument>.FillModelElementCollection(
         openXmlElement.Where(item => item is not DXM.EquationArrayProperties), model,
        CreateBaseElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXM.EquationArray? openXmlElement, DMM.EquationArray? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpEquationArrayProperties(openXmlElement, model.EquationArrayProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMM.Argument>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item=>item is not DXM.EquationArrayProperties), model,
        CompareBaseElement, diffs, objName))
        ok = false;

      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXM.EquationArray CreateOpenXmlElement(DMM.EquationArray model)
  {
    var openXmlElement = new DXM.EquationArray();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXM.EquationArray openXmlElement, DMM.EquationArray model)
  {
    SetEquationArrayProperties(openXmlElement, model.EquationArrayProperties);
    return ElementCollectionConverter<DMM.Argument>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareBaseElement,
      UpdateOpenXmlBaseElement,
      CreateOpenXmlBaseElement);
  }
  #endregion
}
