namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Constraint List.
/// </summary>
public static class ConstraintsConverter
{
  private static Collection<DMDrawsDgms.Constraint> GetItems(DXDrawDgms.Constraints openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Constraint>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Constraint>())
    {
      var newItem = DMXDrawsDgms.ConstraintConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXDrawDgms.Constraints openXmlElement, Collection<DMDrawsDgms.Constraint>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXDrawDgms.Constraints openXmlElement, Collection<DMDrawsDgms.Constraint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Constraint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ConstraintConverter.CreateOpenXmlElement<DXDrawDgms.Constraint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.Constraints? CreateModelElement(DXDrawDgms.Constraints? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Constraints();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Constraints? openXmlElement, DMDrawsDgms.Constraints? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Constraints? value)
    where OpenXmlElementType: DXDrawDgms.Constraints, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
