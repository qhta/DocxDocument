using DocumentFormat.OpenXml.Office2013.WebExtension;
using Snapshot = DocumentModel.WebExtensions.Snapshot;
using WebExtensionBindingList = DocumentModel.WebExtensions.WebExtensionBindingList;
using WebExtensionPropertyBag = DocumentModel.WebExtensions.WebExtensionPropertyBag;
using WebExtensionReferenceList = DocumentModel.WebExtensions.WebExtensionReferenceList;
using WebExtensionStoreReference = DocumentModel.WebExtensions.WebExtensionStoreReference;

namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
///   Defines the WebExtension Class.
/// </summary>
public static class WebExtensionConverter
{
  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static Boolean? GetFronzen(WebExtension? openXmlElement)
  {
    return openXmlElement?.Fronzen?.Value;
  }

  public static void SetFronzen(WebExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Fronzen = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Fronzen = null;
  }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetId(WebExtension? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(WebExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetFrozen(WebExtension? openXmlElement)
  {
    return openXmlElement?.Frozen?.Value;
  }

  public static void SetFrozen(WebExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Frozen = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Frozen = null;
  }

  /// <summary>
  ///   WebExtensionStoreReference.
  /// </summary>
  public static WebExtensionStoreReference? GetWebExtensionStoreReference(WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
    if (itemElement != null)
      return WebExtensionStoreReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWebExtensionStoreReference(WebExtension? openXmlElement, WebExtensionStoreReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WebExtensionReferenceList.
  /// </summary>
  public static WebExtensionReferenceList? GetWebExtensionReferenceList(WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>();
    if (itemElement != null)
      return WebExtensionReferenceListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWebExtensionReferenceList(WebExtension? openXmlElement, WebExtensionReferenceList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionReferenceListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WebExtensionPropertyBag.
  /// </summary>
  public static WebExtensionPropertyBag? GetWebExtensionPropertyBag(WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>();
    if (itemElement != null)
      return WebExtensionPropertyBagConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWebExtensionPropertyBag(WebExtension? openXmlElement, WebExtensionPropertyBag? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionPropertyBagConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WebExtensionBindingList.
  /// </summary>
  public static WebExtensionBindingList? GetWebExtensionBindingList(WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>();
    if (itemElement != null)
      return WebExtensionBindingListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWebExtensionBindingList(WebExtension? openXmlElement, WebExtensionBindingList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionBindingListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Snapshot.
  /// </summary>
  public static Snapshot? GetSnapshot(WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>();
    if (itemElement != null)
      return SnapshotConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSnapshot(WebExtension? openXmlElement, Snapshot? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SnapshotConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.WebExtensions.OfficeArtExtensionList? GetOfficeArtExtensionList(WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(WebExtension? openXmlElement, DocumentModel.WebExtensions.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.WebExtensions.WebExtension? CreateModelElement(WebExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtension();
      value.Fronzen = GetFronzen(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Frozen = GetFrozen(openXmlElement);
      value.WebExtensionStoreReference = GetWebExtensionStoreReference(openXmlElement);
      value.WebExtensionReferenceList = GetWebExtensionReferenceList(openXmlElement);
      value.WebExtensionPropertyBag = GetWebExtensionPropertyBag(openXmlElement);
      value.WebExtensionBindingList = GetWebExtensionBindingList(openXmlElement);
      value.Snapshot = GetSnapshot(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.WebExtension? value)
    where OpenXmlElementType : WebExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFronzen(openXmlElement, value?.Fronzen);
      SetId(openXmlElement, value?.Id);
      SetFrozen(openXmlElement, value?.Frozen);
      SetWebExtensionStoreReference(openXmlElement, value?.WebExtensionStoreReference);
      SetWebExtensionReferenceList(openXmlElement, value?.WebExtensionReferenceList);
      SetWebExtensionPropertyBag(openXmlElement, value?.WebExtensionPropertyBag);
      SetWebExtensionBindingList(openXmlElement, value?.WebExtensionBindingList);
      SetSnapshot(openXmlElement, value?.Snapshot);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}