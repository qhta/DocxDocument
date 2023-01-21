namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public static class AllocatedCommandsConverter
{
  private static Collection<DMW.AllocatedCommand> GetItems(DXOW.AllocatedCommands openXmlElement)
  {
    var collection = new Collection<DMW.AllocatedCommand>();
    foreach (var item in openXmlElement.Elements<DXOW.AllocatedCommand>())
    {
      var newItem = DMXW.AllocatedCommandConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXOW.AllocatedCommands openXmlElement, Collection<DMW.AllocatedCommand>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.AllocatedCommand>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.AllocatedCommandConverter.CreateOpenXmlElement<DXOW.AllocatedCommand>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.AllocatedCommands? CreateModelElement(DXOW.AllocatedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AllocatedCommands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AllocatedCommands? value)
    where OpenXmlElementType: DXOW.AllocatedCommands, new()
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
