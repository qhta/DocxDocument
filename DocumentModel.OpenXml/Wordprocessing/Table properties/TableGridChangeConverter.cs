namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public static class TableGridChangeConverter
{
  #region Annotation Identifier conversion.
  private static String? GetId(DXW.TableGridChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TableGridChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.TableGridChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Previous Table Grid conversion.
  private static DMW.PreviousTableGrid? GetPreviousTableGrid(DXW.TableGridChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTableGrid>();
    if (element != null)
      return DMXW.PreviousTableGridConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTableGrid(DXW.TableGridChange openXmlElement, DMW.PreviousTableGrid? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTableGridConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableGrid>(), value, diffs, objName);
  }
  
  private static void SetPreviousTableGrid(DXW.TableGridChange openXmlElement, DMW.PreviousTableGrid? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTableGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTableGridConverter.CreateOpenXmlElement<DXW.PreviousTableGrid>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableGridChange model conversion.
  public static DMW.TableGridChange? CreateModelElement(DXW.TableGridChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableGridChange();
      value.AnnotationId = GetId(openXmlElement);
      value.PreviousTableGrid = GetPreviousTableGrid(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableGridChange? openXmlElement, DMW.TableGridChange? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.AnnotationId, diffs, objName))
        ok = false;
      if (!CmpPreviousTableGrid(openXmlElement, value.PreviousTableGrid, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableGridChange value)
    where OpenXmlElementType: DXW.TableGridChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableGridChange openXmlElement, DMW.TableGridChange value)
  {
    SetId(openXmlElement, value?.AnnotationId);
    SetPreviousTableGrid(openXmlElement, value?.PreviousTableGrid);
  }
  #endregion
}
