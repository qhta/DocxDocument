namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the Commands Class.
/// </summary>
public static class CommandsConverter
{
  public static Collection<Command>? GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.Commands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Command>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Command>())
      {
        var newItem = CommandConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.Commands? openXmlElement, Collection<Command>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Command>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CommandConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Command>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Commands? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Commands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Commands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Commands? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.Commands, new()
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