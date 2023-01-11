namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Commands Class.
/// </summary>
public static class CommandsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Command>? GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.Commands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Command>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Command>())
      {
        var newItem = DocumentModel.OpenXml.CommandConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.Commands? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Command>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Command>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.CommandConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Command>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Commands? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Commands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Commands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Commands? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.Commands, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
