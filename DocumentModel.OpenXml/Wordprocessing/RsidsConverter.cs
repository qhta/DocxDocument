namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public static class RsidsConverter
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  private static UInt32? GetRsidRoot(DXW.Rsids openXmlElement)
  {
    if (openXmlElement.RsidRoot?.Val?.Value != null)
      return UInt32.Parse(openXmlElement.RsidRoot.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetRsidRoot(DXW.Rsids openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidRoot = new DXW.RsidRoot { Val = ((UInt32)value).ToString("X8") };
      else
        openXmlElement.RsidRoot = null;
  }
  
  private static Collection<UInt32> GetItems(DXW.Rsids openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXW.Rsid>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXW.Rsids openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Rsid>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXW.Rsid>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.Rsids? CreateModelElement(DXW.Rsids? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Rsids();
      value.RsidRoot = GetRsidRoot(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Rsids? value)
    where OpenXmlElementType: DXW.Rsids, new()
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
