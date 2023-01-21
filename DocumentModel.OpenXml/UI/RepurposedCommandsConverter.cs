namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the RepurposedCommands Class.
/// </summary>
public static class RepurposedCommandsConverter
{
  private static Collection<DMUI.RepurposedCommand> GetItems(DXOCustUI.RepurposedCommands openXmlElement)
  {
    var collection = new Collection<DMUI.RepurposedCommand>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.RepurposedCommand>())
    {
      var newItem = DMXUI.RepurposedCommandConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXOCustUI.RepurposedCommands openXmlElement, Collection<DMUI.RepurposedCommand>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCustUI.RepurposedCommand>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.RepurposedCommandConverter.CreateOpenXmlElement<DXOCustUI.RepurposedCommand>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMUI.RepurposedCommands? CreateModelElement(DXOCustUI.RepurposedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.RepurposedCommands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.RepurposedCommands? value)
    where OpenXmlElementType: DXOCustUI.RepurposedCommands, new()
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
