namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Subscript Function.
/// </summary>
public static class SubscriptConverter
{
  /// <summary>
  /// Subscript Properties.
  /// </summary>
  public static DocumentModel.Math.SubscriptProperties? GetSubscriptProperties(DocumentFormat.OpenXml.Math.Subscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubscriptProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubscriptPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSubscriptProperties(DocumentFormat.OpenXml.Math.Subscript? openXmlElement, DocumentModel.Math.SubscriptProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubscriptProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.SubscriptPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubscriptProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.Subscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.Subscript? openXmlElement, DocumentModel.Math.Base? value)
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
  /// Subscript (Subscript function).
  /// </summary>
  public static DocumentModel.Math.SubArgument? GetSubArgument(DocumentFormat.OpenXml.Math.Subscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSubArgument(DocumentFormat.OpenXml.Math.Subscript? openXmlElement, DocumentModel.Math.SubArgument? value)
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
  
  public static DocumentModel.Math.Subscript? CreateModelElement(DocumentFormat.OpenXml.Math.Subscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Subscript();
      value.SubscriptProperties = GetSubscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Subscript? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Subscript, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSubscriptProperties(openXmlElement, value?.SubscriptProperties);
      SetBase(openXmlElement, value?.Base);
      SetSubArgument(openXmlElement, value?.SubArgument);
      return openXmlElement;
    }
    return default;
  }
}
