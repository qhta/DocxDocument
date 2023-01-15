using DocumentFormat.OpenXml.Drawing;
using Anchor = DocumentModel.Drawings.Anchor;
using Backdrop = DocumentFormat.OpenXml.Drawing.Backdrop;
using Vector3DType = DocumentModel.Drawings.Vector3DType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Backdrop Plane.
/// </summary>
public static class BackdropConverter
{
  /// <summary>
  ///   Anchor Point.
  /// </summary>
  public static Anchor? GetAnchor(Backdrop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Anchor>();
    if (itemElement != null)
      return AnchorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAnchor(Backdrop? openXmlElement, Anchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Anchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Anchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Normal.
  /// </summary>
  public static Vector3DType? GetNormal(Backdrop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Normal>();
    if (itemElement != null)
      return Vector3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNormal(Backdrop? openXmlElement, Vector3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Normal>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Vector3DTypeConverter.CreateOpenXmlElement<Normal>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Up Vector.
  /// </summary>
  public static Vector3DType? GetUpVector(Backdrop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<UpVector>();
    if (itemElement != null)
      return Vector3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUpVector(Backdrop? openXmlElement, Vector3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UpVector>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Vector3DTypeConverter.CreateOpenXmlElement<UpVector>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(Backdrop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Backdrop? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.Backdrop? CreateModelElement(Backdrop? openXmlElement)
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
    where OpenXmlElementType : Backdrop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAnchor(openXmlElement, value?.Anchor);
      SetNormal(openXmlElement, value?.Normal);
      SetUpVector(openXmlElement, value?.UpVector);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}