namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public static class PieSerExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieSerExtension>? GetPieSerExtensions(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.PieSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetPieSerExtensions(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.PieSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieSerExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieSerExtensionList();
      value.PieSerExtensions = GetPieSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PieSerExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
