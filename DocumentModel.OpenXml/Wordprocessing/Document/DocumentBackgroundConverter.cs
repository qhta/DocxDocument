namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.DocumentBackground"/> class from/to OpenXml converter.
/// </summary>
public static class DocumentBackgroundConverter
{

  #region Background conversion.
  private static DMV.Background? GetBackground(DXW.DocumentBackground openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Background>();
    if (element != null)
      return DMXV.BackgroundConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackground(DXW.DocumentBackground openXmlElement, DMV.Background? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.BackgroundConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Background>(), value, diffs, objName, propName);
  }
  
  private static void SetBackground(DXW.DocumentBackground openXmlElement, DMV.Background? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Background>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.BackgroundConverter.CreateOpenXmlElement<DXV.Background>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
#endregion

  public static DMW.DocumentBackground? CreateModelElement(DXW.DocumentBackground? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.DocumentBackground();
      model.Color = DocumentBackgroundColorConverter.CreateModelElement(openXmlElement);
      model.Background = GetBackground(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocumentBackground? openXmlElement, DMW.DocumentBackground? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!DocumentBackgroundColorConverter.CompareModelElement(openXmlElement, model.Color, diffs, objName, propName))
        ok = false;
      if (!CmpBackground(openXmlElement, model.Background, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.DocumentBackground CreateOpenXmlElement(DMW.DocumentBackground model)
  {
    var openXmlElement = new DXW.DocumentBackground();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocumentBackground openXmlElement, DMW.DocumentBackground model)
  {
    DocumentBackgroundColorConverter.UpdateOpenXmlElement(openXmlElement, model.Color);
    SetBackground(openXmlElement, model.Background);
  }
}
