namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Sub-Superscript Function.
/// </summary>
public static class SubSuperscriptConverter
{
  /// <summary>
  /// Sub-Superscript Properties.
  /// </summary>
  public static DocumentModel.Math.SubSuperscriptProperties? GetSubSuperscriptProperties(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubSuperscriptPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSubSuperscriptProperties(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement, DocumentModel.Math.SubSuperscriptProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.SubSuperscriptPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement, DocumentModel.Math.Base? value)
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
  /// Subscript (Sub-Superscript).
  /// </summary>
  public static DocumentModel.Math.SubArgument? GetSubArgument(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSubArgument(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement, DocumentModel.Math.SubArgument? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.SubArgumentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubArgument>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
  /// </summary>
  public static DocumentModel.Math.SuperArgument? GetSuperArgument(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSuperArgument(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement, DocumentModel.Math.SuperArgument? value)
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
  
  public static DocumentModel.Math.SubSuperscript? CreateModelElement(DocumentFormat.OpenXml.Math.SubSuperscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.SubSuperscript();
      value.SubSuperscriptProperties = GetSubSuperscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.SubSuperscript? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.SubSuperscript, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
