namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Pre-Sub-Superscript Function.
/// </summary>
public static class PreSubSuperConverter
{
  /// <summary>
  /// Pre-Sub-Superscript Properties.
  /// </summary>
  private static DocumentModel.Math.PreSubSuperProperties? GetPreSubSuperProperties(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuperProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.PreSubSuperPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreSubSuperProperties(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement, DocumentModel.Math.PreSubSuperProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuperProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.PreSubSuperPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.PreSubSuperProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Subscript (Pre-Sub-Superscript).
  /// </summary>
  private static DocumentModel.Math.SubArgument? GetSubArgument(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSubArgument(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement, DocumentModel.Math.SubArgument? value)
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
  
  /// <summary>
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  private static DocumentModel.Math.SuperArgument? GetSuperArgument(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSuperArgument(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement, DocumentModel.Math.SuperArgument? value)
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
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement, DocumentModel.Math.Base? value)
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
  
  public static DocumentModel.Math.PreSubSuper? CreateModelElement(DocumentFormat.OpenXml.Math.PreSubSuper? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.PreSubSuper();
      value.PreSubSuperProperties = GetPreSubSuperProperties(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.PreSubSuper? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.PreSubSuper, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreSubSuperProperties(openXmlElement, value?.PreSubSuperProperties);
      SetSubArgument(openXmlElement, value?.SubArgument);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
