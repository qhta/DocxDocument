using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public static class RsidsConverter
{
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  public static NumId? GetRsidRoot(Rsids? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RsidRoot>();
    if (itemElement != null)
      return NumIdConverter.GetValue(itemElement);
    return null;
  }

  public static void SetRsidRoot(Rsids? openXmlElement, NumId? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RsidRoot>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumIdConverter.CreateOpenXmlElement<RsidRoot>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<NumId>? GetItems(Rsids? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NumId>();
      foreach (var item in openXmlElement.Elements<Rsid>())
      {
        var newItem = NumIdConverter.GetValue(item);
        if (newItem != null)
          collection.Add((NumId)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Rsids? openXmlElement, Collection<NumId>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<Rsid>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NumIdConverter.CreateOpenXmlElement<Rsid>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Rsids? CreateModelElement(Rsids? openXmlElement)
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
    where OpenXmlElementType : Rsids, new()
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