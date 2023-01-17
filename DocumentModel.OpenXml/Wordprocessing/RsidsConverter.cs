namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public static class RsidsConverter
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  private static UInt32? GetRsidRoot(DocumentFormat.OpenXml.Wordprocessing.Rsids openXmlElement)
  {
    if (openXmlElement.RsidRoot?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.RsidRoot.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidRoot(DocumentFormat.OpenXml.Wordprocessing.Rsids openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidRoot = new DocumentFormat.OpenXml.Wordprocessing.RsidRoot { Val = ((UInt32)value).ToString("X8") };
      else
        openXmlElement.RsidRoot = null;
  }
  
  private static System.Collections.ObjectModel.Collection<UInt32> GetItems(DocumentFormat.OpenXml.Wordprocessing.Rsids openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Rsid>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Wordprocessing.Rsids openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Rsid>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Rsid>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRsidRoot(openXmlElement, value?.RsidRoot);
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
