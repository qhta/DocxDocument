namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public static class SuperscriptConverter
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public static DocumentModel.Math.SuperscriptProperties? GetSuperscriptProperties(DocumentFormat.OpenXml.Math.Superscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperscriptProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SuperscriptPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSuperscriptProperties(DocumentFormat.OpenXml.Math.Superscript? openXmlElement, DocumentModel.Math.SuperscriptProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperscriptProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.SuperscriptPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SuperscriptProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.Superscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.Superscript? openXmlElement, DocumentModel.Math.Base? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public static DocumentModel.Math.SuperArgument? GetSuperArgument(DocumentFormat.OpenXml.Math.Superscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSuperArgument(DocumentFormat.OpenXml.Math.Superscript? openXmlElement, DocumentModel.Math.SuperArgument? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.SuperArgumentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SuperArgument>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Superscript? CreateModelElement(DocumentFormat.OpenXml.Math.Superscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Superscript();
      value.SuperscriptProperties = GetSuperscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Superscript? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Superscript, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSuperscriptProperties(openXmlElement, value?.SuperscriptProperties);
      SetBase(openXmlElement, value?.Base);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      return openXmlElement;
    }
    return default;
  }
}
