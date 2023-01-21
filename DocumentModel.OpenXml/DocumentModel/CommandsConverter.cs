namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Commands Class.
/// </summary>
public static class CommandsConverter
{
  private static Collection<DM.Command> GetItems(DXO2010CustUI.Commands openXmlElement)
  {
    var collection = new Collection<DM.Command>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.Command>())
    {
      var newItem = DMX.CommandConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXO2010CustUI.Commands openXmlElement, Collection<DM.Command>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.Command>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.CommandConverter.CreateOpenXmlElement<DXO2010CustUI.Command>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.Commands? CreateModelElement(DXO2010CustUI.Commands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Commands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Commands? value)
    where OpenXmlElementType: DXO2010CustUI.Commands, new()
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
