namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public static class Scene3DConverter
{
  /// <summary>
  /// Camera.
  /// </summary>
  public static DocumentModel.Wordprocessing.Camera? GetCamera(DocumentFormat.OpenXml.Office2010.Word.Scene3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Camera>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CameraConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCamera(DocumentFormat.OpenXml.Office2010.Word.Scene3D? openXmlElement, DocumentModel.Wordprocessing.Camera? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Camera>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CameraConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Camera>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  public static DocumentModel.Wordprocessing.LightRig? GetLightRig(DocumentFormat.OpenXml.Office2010.Word.Scene3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LightRig>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LightRigConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLightRig(DocumentFormat.OpenXml.Office2010.Word.Scene3D? openXmlElement, DocumentModel.Wordprocessing.LightRig? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LightRig>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.LightRigConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LightRig>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Scene3D? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Scene3D? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Scene3D, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
