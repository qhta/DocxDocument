namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// 3D Scene Properties.
/// </summary>
public static class Scene3DTypeConverter
{
  /// <summary>
  /// Camera.
  /// </summary>
  public static DocumentModel.Drawings.Camera? GetCamera(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Camera>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CameraConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCamera(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement, DocumentModel.Drawings.Camera? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Camera>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.CameraConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Camera>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public static DocumentModel.Drawings.LightRig? GetLightRig(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LightRig>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LightRigConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLightRig(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement, DocumentModel.Drawings.LightRig? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LightRig>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LightRigConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LightRig>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public static DocumentModel.Drawings.Backdrop? GetBackdrop(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Backdrop>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackdropConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackdrop(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement, DocumentModel.Drawings.Backdrop? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Backdrop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BackdropConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Backdrop>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Scene3DType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Scene3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Scene3DType();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      value.Backdrop = GetBackdrop(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Scene3DType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Scene3DType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
