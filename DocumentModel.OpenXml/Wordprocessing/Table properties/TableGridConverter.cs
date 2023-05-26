namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public static class TableGridConverter
{
  #region TableGridChange conversion.
  private static DMW.TableGridChange? GetTableGridChange(DXW.TableGrid openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableGridChange>();
    if (element != null)
      return DMXW.TableGridChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableGridChange(DXW.TableGrid openXmlElement, DMW.TableGridChange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TableGridChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableGridChange>(), value, diffs, objName, propName);
  }
  
  private static void SetTableGridChange(DXW.TableGrid openXmlElement, DMW.TableGridChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableGridChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableGridChangeConverter.CreateOpenXmlElement<DXW.TableGridChange>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableGrid model conversion.
  public static DMW.TableGrid? CreateModelElement(DXW.TableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableGrid();
      BaseTableGridConverter.UpdateModelElement(model, openXmlElement);
      model.TableGridChange = GetTableGridChange(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableGrid? openXmlElement, DMW.TableGrid? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!BaseTableGridConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName))
        ok = false;
      if (!CmpTableGridChange(openXmlElement, model.TableGridChange, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableGrid model)
    where OpenXmlElementType: DXW.TableGrid, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableGrid openXmlElement, DMW.TableGrid model)
  {
    BaseTableGridConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetTableGridChange(openXmlElement, model.TableGridChange);
  }
  #endregion
}
