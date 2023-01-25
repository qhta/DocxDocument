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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.TableGridChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.TableGridChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  private static DMW.PreviousTableGrid? GetPreviousTableGrid(DXW.TableGridChange openXmlElement)
  {
    return DMXW.PreviousTableGridConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PreviousTableGrid>());
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
  
  public static DMW.TableGridChange? CreateModelElement(DXW.TableGridChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableGridChange();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableGridChange? value)
    where OpenXmlElementType: DXW.TableGridChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetPreviousTableGrid(openXmlElement, value?.PreviousTableGrid);
      return openXmlElement;
    }
    return default;
  }
}
