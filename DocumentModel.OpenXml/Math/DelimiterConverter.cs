namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Delimiter"/> class from/to OpenXml converter.
/// </summary>
public static class DelimiterConverter
{
  #region Delimiter Properties conversion.
  private static DMM.DelimiterProperties? GetDelimiterProperties(DXM.Delimiter openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.DelimiterProperties>();
    if (element != null)
      return DMXM.DelimiterPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpDelimiterProperties(DXM.Delimiter openXmlElement, DMM.DelimiterProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.DelimiterPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.DelimiterProperties>(), value, diffs, objName);
  }

  private static void SetDelimiterProperties(DXM.Delimiter openXmlElement, DMM.DelimiterProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.DelimiterProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.DelimiterPropertiesConverter.CreateOpenXmlElement<DXM.DelimiterProperties>(value);
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
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in DelimiterConverter.CreateBaseElement method");
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

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in DelimiterConverter.CreateOpenXmlArgumentContent method");
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

  #region Delimiter model conversion.
  public static DMM.Delimiter? CreateModelElement(DXM.Delimiter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Delimiter();
      model.DelimiterProperties = GetDelimiterProperties(openXmlElement);
      ElementCollectionConverter<DMM.Argument>.FillModelElementCollection(
         openXmlElement.Where(item => item is not DXM.DelimiterProperties), model,
        CreateBaseElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXM.Delimiter? openXmlElement, DMM.Delimiter? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpDelimiterProperties(openXmlElement, model.DelimiterProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMM.Argument>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item=>item is not DXM.DelimiterProperties), model,
        CompareBaseElement, diffs, objName))
        ok = false;

      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXM.Delimiter CreateOpenXmlElement(DMM.Delimiter model)
  {
    var openXmlElement = new DXM.Delimiter();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXM.Delimiter openXmlElement, DMM.Delimiter model)
  {
    SetDelimiterProperties(openXmlElement, model.DelimiterProperties);
    return ElementCollectionConverter<DMM.Argument>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareBaseElement,
      UpdateOpenXmlBaseElement,
      CreateOpenXmlBaseElement);
  }
  #endregion
}
