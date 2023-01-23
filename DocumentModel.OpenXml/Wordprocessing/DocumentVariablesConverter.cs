namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Variables.
/// </summary>
public static class DocumentVariablesConverter
{
  private static Collection<DMW.DocumentVariable> GetItems(DXW.DocumentVariables openXmlElement)
  {
    var collection = new Collection<DMW.DocumentVariable>();
    foreach (var item in openXmlElement.Elements<DXW.DocumentVariable>())
    {
      var newItem = DMXW.DocumentVariableConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXW.DocumentVariables openXmlElement, Collection<DMW.DocumentVariable>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXW.DocumentVariables openXmlElement, Collection<DMW.DocumentVariable>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.DocumentVariable>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.DocumentVariableConverter.CreateOpenXmlElement<DXW.DocumentVariable>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.DocumentVariables? CreateModelElement(DXW.DocumentVariables? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocumentVariables();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocumentVariables? openXmlElement, DMW.DocumentVariables? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocumentVariables? value)
    where OpenXmlElementType: DXW.DocumentVariables, new()
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
