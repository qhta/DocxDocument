namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Choose Element.
/// </summary>
public static class ChooseConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDD.Choose openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDD.Choose openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDD.Choose openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDD.DiagramChooseIf? GetDiagramChooseIf(DXDD.Choose openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.DiagramChooseIf>();
    if (element != null)
      return DMXDD.DiagramChooseIfConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiagramChooseIf(DXDD.Choose openXmlElement, DMDD.DiagramChooseIf? value, DiffList? diffs, string? objName)
  {
    return DMXDD.DiagramChooseIfConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.DiagramChooseIf>(), value, diffs, objName);
  }
  
  private static void SetDiagramChooseIf(DXDD.Choose openXmlElement, DMDD.DiagramChooseIf? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.DiagramChooseIf>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.DiagramChooseIfConverter.CreateOpenXmlElement<DXDD.DiagramChooseIf>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.DiagramChooseElse? GetDiagramChooseElse(DXDD.Choose openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.DiagramChooseElse>();
    if (element != null)
      return DMXDD.DiagramChooseElseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiagramChooseElse(DXDD.Choose openXmlElement, DMDD.DiagramChooseElse? value, DiffList? diffs, string? objName)
  {
    return DMXDD.DiagramChooseElseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.DiagramChooseElse>(), value, diffs, objName);
  }
  
  private static void SetDiagramChooseElse(DXDD.Choose openXmlElement, DMDD.DiagramChooseElse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.DiagramChooseElse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.DiagramChooseElseConverter.CreateOpenXmlElement<DXDD.DiagramChooseElse>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Choose? CreateModelElement(DXDD.Choose? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Choose();
      value.Name = GetName(openXmlElement);
      value.DiagramChooseIf = GetDiagramChooseIf(openXmlElement);
      value.DiagramChooseElse = GetDiagramChooseElse(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.Choose? openXmlElement, DMDD.Choose? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpDiagramChooseIf(openXmlElement, value.DiagramChooseIf, diffs, objName))
        ok = false;
      if (!CmpDiagramChooseElse(openXmlElement, value.DiagramChooseElse, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Choose value)
    where OpenXmlElementType: DXDD.Choose, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Choose openXmlElement, DMDD.Choose value)
  {
    SetName(openXmlElement, value?.Name);
    SetDiagramChooseIf(openXmlElement, value?.DiagramChooseIf);
    SetDiagramChooseElse(openXmlElement, value?.DiagramChooseElse);
  }
}
