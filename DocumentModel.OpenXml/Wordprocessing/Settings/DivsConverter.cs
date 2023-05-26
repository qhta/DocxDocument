namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Divs"/> class from/to OpenXml converter.
/// </summary>
public static class DivsConverter
{
  #region item conversion
  public static DM.IModelElement? GetItem(DX.OpenXmlElement openXmlElement)
  {
    if (openXmlElement is DXW.Div div)
      return DivConverter.CreateModelElement(div);

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in DivsConverter.CreateModelElement method");
    return null;

  }

  public static bool CmpItem(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model,
    DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Div divElement && model is DMW.Div divModel)
        return DivConverter.CompareModelElement(divElement, divModel, diffs, objName, propName);

      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static bool UpdateItem(DX.OpenXmlElement openXmlElement, DM.IModelElement model)
  {
    if (openXmlElement is DXW.Div divElement && model is DMW.Div divModel)
      return DivConverter.UpdateOpenXmlElement(divElement, divModel);
    return false;
  }

  public static OpenXmlElement CreateItemElement(DM.IModelElement model)
  {
    if (model is DMW.Div divModel)
      return DivConverter.CreateOpenXmlElement(divModel);

    return null!;
  }
  #endregion


  #region Divs model conversion.
  public static DMW.Divs? CreateModelElement(DXW.DivsType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Divs();
      ElementCollectionConverter<DMW.Div>.FillModelElementCollection(
        openXmlElement, model,
        GetItem);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.DivsType? openXmlElement, DMW.Divs? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMW.Div>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CmpItem, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static ElementType CreateOpenXmlElement<ElementType>(DMW.Divs model)
    where ElementType : DXW.DivsType, new()
  {
    var openXmlElement = new ElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.DivsType openXmlElement, DMW.Divs model)
  {
    return ElementCollectionConverter<DMW.Div>.UpdateOpenXmlElementCollection(
      openXmlElement,
      model,
      CmpItem,
      UpdateItem,
      CreateItemElement
    );
  }
  #endregion
}
