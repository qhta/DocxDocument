using DocumentModel.Wordprocessing;
using Scene3D = DocumentFormat.OpenXml.Office2010.Word.Scene3D;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Scene3D Class.
/// </summary>
public static class Scene3DConverter
{
  /// <summary>
  ///   Camera.
  /// </summary>
  public static Camera? GetCamera(Scene3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Camera>();
    if (itemElement != null)
      return CameraConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCamera(Scene3D? openXmlElement, Camera? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Camera>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CameraConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Camera>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   LightRig.
  /// </summary>
  public static LightRig? GetLightRig(Scene3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LightRig>();
    if (itemElement != null)
      return LightRigConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLightRig(Scene3D? openXmlElement, LightRig? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LightRig>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LightRigConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LightRig>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Scene3D? CreateModelElement(Scene3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Scene3D();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Scene3D? value)
    where OpenXmlElementType : Scene3D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCamera(openXmlElement, value?.Camera);
      SetLightRig(openXmlElement, value?.LightRig);
      return openXmlElement;
    }
    return default;
  }
}