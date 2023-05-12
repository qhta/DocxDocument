namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Run"/> class from/to OpenXml converter.
/// </summary>
public static class RunConverter
{
  #region Math Run Properties conversion.
  private static DMM.RunProperties? GetMathRunProperties(DXM.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.RunProperties>();
    if (element != null)
      return DMXM.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMathRunProperties(DXM.Run openXmlElement, DMM.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.RunProperties>(), value, diffs, objName);
  }
  
  private static void SetMathRunProperties(DXM.Run openXmlElement, DMM.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.RunPropertiesConverter.CreateOpenXmlElement<DXM.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Run Properties conversion.
  private static DMW.RunProperties? GetRunProperties(DXM.Run openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXM.Run openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName);
  }
  
  private static void SetRunProperties(DXM.Run openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Run content conversion.
  public static DMW.IRunContent? CreateRunContent(DX.OpenXmlElement? openXmlElement, object? data = null)
  {
    if (openXmlElement is DXM.Text text)
      return DMXW.TextTypeConverter.CreateModelElement(text);
    return DMXW.RunConverter.CreateRunContent(openXmlElement);
  }

  public static bool CompareRunContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null, object? data = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXM.Text text && model is DMM.Text textModel)
        return DMXW.TextTypeConverter.CompareModelElement(text, textModel, diffs, objName);
    }
    return DMXW.RunConverter.CompareRunContent(openXmlElement, model, diffs, objName);
  }

  public static OpenXmlElement CreateOpenXmlElement(DM.IModelElement model, object? data = null)
  {
    if (model is DMM.Text text)
      return DMXW.TextTypeConverter.CreateOpenXmlElement(text);
    return DMXW.RunConverter.CreateOpenXmlElement(model);
  }
  #endregion

  #region Run model conversion.
  public static DMM.Run? CreateModelElement(DXM.Run? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Run();
      model.MathRunProperties = GetMathRunProperties(openXmlElement);
      model.RunProperties = GetRunProperties(openXmlElement);
      ElementCollectionConverter<DMW.IRunContent>.FillModelElementCollection(
        openXmlElement.Where(item => item is not DXW.RunProperties && item is not DXM.RunProperties), model,
        CreateRunContent);

      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Run? openXmlElement, DMM.Run? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpMathRunProperties(openXmlElement, model.MathRunProperties, diffs, objName))
        ok = false;
      if (!CmpRunProperties(openXmlElement, model.RunProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.IRunContent>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item => item is not DXW.RunProperties && item is not DXM.RunProperties), model,
        CompareRunContent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Run CreateOpenXmlElement(DMM.Run model)
  {
    var openXmlElement = new DXM.Run();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Run openXmlElement, DMM.Run model)
  {
    SetMathRunProperties(openXmlElement, model.MathRunProperties);
    SetRunProperties(openXmlElement, model.RunProperties);
    return ElementCollectionConverter<DMW.IRunContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      DMXW.RunConverter.CompareRunContent,
      DMXW.RunConverter.UpdateOpenXmlElement,
      DMXW.RunConverter.CreateOpenXmlElement
      );
  }
  #endregion
}
