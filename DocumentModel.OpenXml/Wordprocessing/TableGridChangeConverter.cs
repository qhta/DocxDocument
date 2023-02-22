namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public static class TableGridChangeConverter
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TableGridChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TableGridChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.TableGridChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  private static DMW.PreviousTableGrid? GetPreviousTableGrid(DXW.TableGridChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTableGrid>();
    if (element != null)
      return DMXW.PreviousTableGridConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTableGrid(DXW.TableGridChange openXmlElement, DMW.PreviousTableGrid? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTableGridConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableGrid>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TableGridChange? CreateModelElement(DXW.TableGridChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableGridChange();
      value.Id = GetId(openXmlElement);
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
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
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
    SetId(openXmlElement, value?.Id);
    SetPreviousTableGrid(openXmlElement, value?.PreviousTableGrid);
  }
}
