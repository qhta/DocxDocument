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
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDrawDgms.Choose openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static DMDrawsDgms.DiagramChooseIf? GetDiagramChooseIf(DXDrawDgms.Choose openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.DiagramChooseIf>();
    if (itemElement != null)
      return DMXDrawsDgms.DiagramChooseIfConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.DiagramChooseElse>();
    if (itemElement != null)
      return DMXDrawsDgms.DiagramChooseElseConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsDgms.Choose? CreateModelElement(DXDrawDgms.Choose? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Choose();
      value.Name = GetName(openXmlElement);
      value.DiagramChooseIf = GetDiagramChooseIf(openXmlElement);
      value.DiagramChooseElse = GetDiagramChooseElse(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Choose? value)
    where OpenXmlElementType: DXDrawDgms.Choose, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetDiagramChooseIf(openXmlElement, value?.DiagramChooseIf);
      SetDiagramChooseElse(openXmlElement, value?.DiagramChooseElse);
      return openXmlElement;
    }
    return default;
  }
}
