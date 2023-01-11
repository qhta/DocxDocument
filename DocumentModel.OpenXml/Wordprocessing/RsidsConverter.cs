namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public static class RsidsConverter
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public static DocumentModel.HexWord? GetRsidRoot(DocumentFormat.OpenXml.Wordprocessing.Rsids? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RsidRoot>();
    if (itemElement != null)
      return HexWordConverter.GetValue(itemElement);
    return null;
  }
  
  public static void SetRsidRoot(DocumentFormat.OpenXml.Wordprocessing.Rsids? openXmlElement, DocumentModel.HexWord? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RsidRoot>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HexWordConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RsidRoot>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.HexWord>? GetItems(DocumentFormat.OpenXml.Wordprocessing.Rsids? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.HexWord>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Rsid>())
      {
        var newItem = HexWordConverter.GetValue(item);
        if (newItem != null)
          collection.Add((HexWord)newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Wordprocessing.Rsids? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.HexWord>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Rsid>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = HexWordConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Rsid>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Rsids? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Rsids? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Rsids();
      value.RsidRoot = GetRsidRoot(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Rsids? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Rsids, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
