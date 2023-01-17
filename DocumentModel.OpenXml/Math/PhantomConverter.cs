namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Phantom Function.
/// </summary>
public static class PhantomConverter
{
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  private static DocumentModel.Math.PhantomProperties? GetPhantomProperties(DocumentFormat.OpenXml.Math.Phantom openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PhantomProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.PhantomPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPhantomProperties(DocumentFormat.OpenXml.Math.Phantom openXmlElement, DocumentModel.Math.PhantomProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PhantomProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.PhantomPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.PhantomProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.Phantom openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DocumentFormat.OpenXml.Math.Phantom openXmlElement, DocumentModel.Math.Base? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.Phantom? CreateModelElement(DocumentFormat.OpenXml.Math.Phantom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Phantom();
      value.PhantomProperties = GetPhantomProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Phantom? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Phantom, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPhantomProperties(openXmlElement, value?.PhantomProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
