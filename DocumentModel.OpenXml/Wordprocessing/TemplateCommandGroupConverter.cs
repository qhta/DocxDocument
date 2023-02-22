namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public static class TemplateCommandGroupConverter
{
  private static Collection<DMW.KeyMapCustomizations>? GetKeyMapCustomizations(DXOW.TemplateCommandGroup openXmlElement)
  {
    var collection = new Collection<DMW.KeyMapCustomizations>();
    foreach (var item in openXmlElement.Elements<DXOW.KeyMapCustomizations>())
    {
      var newItem = DMXW.KeyMapCustomizationsConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpKeyMapCustomizations(DXOW.TemplateCommandGroup openXmlElement, Collection<DMW.KeyMapCustomizations>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOW.KeyMapCustomizations>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.KeyMapCustomizationsConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetKeyMapCustomizations(DXOW.TemplateCommandGroup openXmlElement, Collection<DMW.KeyMapCustomizations>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.KeyMapCustomizations>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.KeyMapCustomizationsConverter.CreateOpenXmlElement<DXOW.KeyMapCustomizations>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMW.MismatchedKeyMapCustomization>? GetMismatchedKeyMapCustomizations(DXOW.TemplateCommandGroup openXmlElement)
  {
    var collection = new Collection<DMW.MismatchedKeyMapCustomization>();
    foreach (var item in openXmlElement.Elements<DXOW.MismatchedKeyMapCustomization>())
    {
      var newItem = DMXW.MismatchedKeyMapCustomizationConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpMismatchedKeyMapCustomizations(DXOW.TemplateCommandGroup openXmlElement, Collection<DMW.MismatchedKeyMapCustomization>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOW.MismatchedKeyMapCustomization>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.MismatchedKeyMapCustomizationConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetMismatchedKeyMapCustomizations(DXOW.TemplateCommandGroup openXmlElement, Collection<DMW.MismatchedKeyMapCustomization>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.MismatchedKeyMapCustomization>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.MismatchedKeyMapCustomizationConverter.CreateOpenXmlElement<DXOW.MismatchedKeyMapCustomization>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.Toolbars? GetToolbars(DXOW.TemplateCommandGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.Toolbars>();
    if (element != null)
      return DMXW.ToolbarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToolbars(DXOW.TemplateCommandGroup openXmlElement, DMW.Toolbars? value, DiffList? diffs, string? objName)
  {
    return DMXW.ToolbarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOW.Toolbars>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetToolbars(DXOW.TemplateCommandGroup openXmlElement, DMW.Toolbars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.Toolbars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ToolbarsConverter.CreateOpenXmlElement<DXOW.Toolbars>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.AllocatedCommands>? GetAllocatedCommands(DXOW.TemplateCommandGroup openXmlElement)
  {
    var collection = new Collection<DMW.AllocatedCommands>();
    foreach (var item in openXmlElement.Elements<DXOW.AllocatedCommands>())
    {
      var newItem = DMXW.AllocatedCommandsConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAllocatedCommands(DXOW.TemplateCommandGroup openXmlElement, Collection<DMW.AllocatedCommands>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOW.AllocatedCommands>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.AllocatedCommandsConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAllocatedCommands(DXOW.TemplateCommandGroup openXmlElement, Collection<DMW.AllocatedCommands>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.AllocatedCommands>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.AllocatedCommandsConverter.CreateOpenXmlElement<DXOW.AllocatedCommands>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TemplateCommandGroup? CreateModelElement(DXOW.TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TemplateCommandGroup();
      value.KeyMapCustomizations = GetKeyMapCustomizations(openXmlElement);
      value.MismatchedKeyMapCustomizations = GetMismatchedKeyMapCustomizations(openXmlElement);
      value.Toolbars = GetToolbars(openXmlElement);
      value.AllocatedCommands = GetAllocatedCommands(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.TemplateCommandGroup? openXmlElement, DMW.TemplateCommandGroup? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpKeyMapCustomizations(openXmlElement, value.KeyMapCustomizations, diffs, objName))
        ok = false;
      if (!CmpMismatchedKeyMapCustomizations(openXmlElement, value.MismatchedKeyMapCustomizations, diffs, objName))
        ok = false;
      if (!CmpToolbars(openXmlElement, value.Toolbars, diffs, objName))
        ok = false;
      if (!CmpAllocatedCommands(openXmlElement, value.AllocatedCommands, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TemplateCommandGroup value)
    where OpenXmlElementType: DXOW.TemplateCommandGroup, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.TemplateCommandGroup openXmlElement, DMW.TemplateCommandGroup value)
  {
    SetKeyMapCustomizations(openXmlElement, value?.KeyMapCustomizations);
    SetMismatchedKeyMapCustomizations(openXmlElement, value?.MismatchedKeyMapCustomizations);
    SetToolbars(openXmlElement, value?.Toolbars);
    SetAllocatedCommands(openXmlElement, value?.AllocatedCommands);
  }
}
