namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public static class TemplateCommandGroupConverter
{
  private static Collection<DMW.KeyMapCustomizations> GetKeyMapCustomizationses(DXOW.TemplateCommandGroup openXmlElement)
  {
    var collection = new Collection<DMW.KeyMapCustomizations>();
    foreach (var item in openXmlElement.Elements<DXOW.KeyMapCustomizations>())
    {
      var newItem = DMXW.KeyMapCustomizationsConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetKeyMapCustomizationses(DXOW.TemplateCommandGroup openXmlElement, Collection<DMW.KeyMapCustomizations>? value)
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
  
  private static Collection<DMW.MismatchedKeyMapCustomization> GetMismatchedKeyMapCustomizations(DXOW.TemplateCommandGroup openXmlElement)
  {
    var collection = new Collection<DMW.MismatchedKeyMapCustomization>();
    foreach (var item in openXmlElement.Elements<DXOW.MismatchedKeyMapCustomization>())
    {
      var newItem = DMXW.MismatchedKeyMapCustomizationConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.Toolbars>();
    if (itemElement != null)
      return DMXW.ToolbarsConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static Collection<DMW.AllocatedCommands> GetAllocatedCommandses(DXOW.TemplateCommandGroup openXmlElement)
  {
    var collection = new Collection<DMW.AllocatedCommands>();
    foreach (var item in openXmlElement.Elements<DXOW.AllocatedCommands>())
    {
      var newItem = DMXW.AllocatedCommandsConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetAllocatedCommandses(DXOW.TemplateCommandGroup openXmlElement, Collection<DMW.AllocatedCommands>? value)
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
  
  public static DMW.TemplateCommandGroup? CreateModelElement(DXOW.TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TemplateCommandGroup();
      value.KeyMapCustomizationses = GetKeyMapCustomizationses(openXmlElement);
      value.MismatchedKeyMapCustomizations = GetMismatchedKeyMapCustomizations(openXmlElement);
      value.Toolbars = GetToolbars(openXmlElement);
      value.AllocatedCommandses = GetAllocatedCommandses(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TemplateCommandGroup? value)
    where OpenXmlElementType: DXOW.TemplateCommandGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetKeyMapCustomizationses(openXmlElement, value?.KeyMapCustomizationses);
      SetMismatchedKeyMapCustomizations(openXmlElement, value?.MismatchedKeyMapCustomizations);
      SetToolbars(openXmlElement, value?.Toolbars);
      SetAllocatedCommandses(openXmlElement, value?.AllocatedCommandses);
      return openXmlElement;
    }
    return default;
  }
}
