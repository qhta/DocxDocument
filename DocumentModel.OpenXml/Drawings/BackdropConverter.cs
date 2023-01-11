namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Backdrop Plane.
/// </summary>
public static class BackdropConverter
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public static DocumentModel.Drawings.Anchor? GetAnchor(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Anchor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAnchor(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement, DocumentModel.Drawings.Anchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Anchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Anchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public static DocumentModel.Drawings.Vector3DType? GetNormal(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Normal>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Vector3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNormal(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement, DocumentModel.Drawings.Vector3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Normal>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Vector3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Normal>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  public static DocumentModel.Drawings.Vector3DType? GetUpVector(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.UpVector>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Vector3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUpVector(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement, DocumentModel.Drawings.Vector3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UpVector>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Vector3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.UpVector>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Backdrop? CreateModelElement(DocumentFormat.OpenXml.Drawing.Backdrop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Backdrop();
      value.Anchor = GetAnchor(openXmlElement);
      value.Normal = GetNormal(openXmlElement);
      value.UpVector = GetUpVector(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Backdrop? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Backdrop, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
