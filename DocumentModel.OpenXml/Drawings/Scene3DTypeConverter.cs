using DocumentModel.Drawings;
using Scene3DType = DocumentFormat.OpenXml.Drawing.Scene3DType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   3D Scene Properties.
/// </summary>
public static class Scene3DTypeConverter
{
  /// <summary>
  ///   Camera.
  /// </summary>
  public static Camera? GetCamera(Scene3DType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Camera>();
    if (itemElement != null)
      return CameraConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCamera(Scene3DType? openXmlElement, Camera? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Camera>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CameraConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Camera>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Light Rig.
  /// </summary>
  public static LightRig? GetLightRig(Scene3DType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LightRig>();
    if (itemElement != null)
      return LightRigConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLightRig(Scene3DType? openXmlElement, LightRig? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LightRig>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LightRigConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LightRig>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Backdrop Plane.
  /// </summary>
  public static Backdrop? GetBackdrop(Scene3DType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Backdrop>();
    if (itemElement != null)
      return BackdropConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackdrop(Scene3DType? openXmlElement, Backdrop? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Backdrop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackdropConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Backdrop>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(Scene3DType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Scene3DType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Scene3DType? CreateModelElement(Scene3DType? openXmlElement)
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
    where OpenXmlElementType : Scene3DType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCamera(openXmlElement, value?.Camera);
      SetLightRig(openXmlElement, value?.LightRig);
      SetBackdrop(openXmlElement, value?.Backdrop);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}