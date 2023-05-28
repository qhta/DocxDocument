namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Background Formatting.
/// </summary>
public static class BackgroundConverter
{
  private static DMD.EffectList? GetEffectList(DXDD.Background openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXDD.Background openXmlElement, DMD.EffectList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), model, diffs, objName, propName);
  }
  
  private static void SetEffectList(DXDD.Background openXmlElement, DMD.EffectList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectDag? GetEffectDag(DXDD.Background openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXDD.Background openXmlElement, DMD.EffectDag? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), model, diffs, objName, propName);
  }
  
  private static void SetEffectDag(DXDD.Background openXmlElement, DMD.EffectDag? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.Background? CreateModelElement(DXDD.Background? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMDD.Background();
      model.Fill = FillConverter.CreateFillModel(openXmlElement);
      model.EffectList = GetEffectList(openXmlElement);
      model.EffectDag = GetEffectDag(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.Background? openXmlElement, DMDD.Background? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!FillConverter.CompareFillModel(openXmlElement, model.Fill, diffs, objName, propName))
        ok = false;
      if (!CmpEffectList(openXmlElement, model.EffectList, diffs, objName, propName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, model.EffectDag, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Background model)
    where OpenXmlElementType: DXDD.Background, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Background openXmlElement, DMDD.Background model)
  {
    FillConverter.UpdateOpenXmlElement(openXmlElement, model.Fill);
    SetEffectList(openXmlElement, model.EffectList);
    SetEffectDag(openXmlElement, model.EffectDag);
  }
}
