namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Choose Element.
/// </summary>
public static class ChooseConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDrawDgms.Choose openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDrawDgms.Choose openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDrawDgms.Choose openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsDgms.DiagramChooseIf? GetDiagramChooseIf(DXDrawDgms.Choose openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.DiagramChooseIf>();
    if (element != null)
      return DMXDrawsDgms.DiagramChooseIfConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiagramChooseIf(DXDrawDgms.Choose openXmlElement, DMDrawsDgms.DiagramChooseIf? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.DiagramChooseIfConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.DiagramChooseIf>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDiagramChooseIf(DXDrawDgms.Choose openXmlElement, DMDrawsDgms.DiagramChooseIf? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.DiagramChooseIf>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.DiagramChooseIfConverter.CreateOpenXmlElement<DXDrawDgms.DiagramChooseIf>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.DiagramChooseElse? GetDiagramChooseElse(DXDrawDgms.Choose openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.DiagramChooseElse>();
    if (element != null)
      return DMXDrawsDgms.DiagramChooseElseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiagramChooseElse(DXDrawDgms.Choose openXmlElement, DMDrawsDgms.DiagramChooseElse? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.DiagramChooseElseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.DiagramChooseElse>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDiagramChooseElse(DXDrawDgms.Choose openXmlElement, DMDrawsDgms.DiagramChooseElse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.DiagramChooseElse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.DiagramChooseElseConverter.CreateOpenXmlElement<DXDrawDgms.DiagramChooseElse>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Choose? CreateModelElement(DXDrawDgms.Choose? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawDgms.Choose? openXmlElement, DMDrawsDgms.Choose? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Choose value)
    where OpenXmlElementType: DXDrawDgms.Choose, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Choose openXmlElement, DMDrawsDgms.Choose value)
  {
    SetName(openXmlElement, value?.Name);
    SetDiagramChooseIf(openXmlElement, value?.DiagramChooseIf);
    SetDiagramChooseElse(openXmlElement, value?.DiagramChooseElse);
    }
  }
