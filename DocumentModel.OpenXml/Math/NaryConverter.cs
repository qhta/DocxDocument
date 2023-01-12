namespace DocumentModel.OpenXml.Math;

/// <summary>
/// n-ary Operator Function.
/// </summary>
public static class NaryConverter
{
  /// <summary>
  /// n-ary Properties.
  /// </summary>
  public static DocumentModel.Math.NaryProperties? GetNaryProperties(DocumentFormat.OpenXml.Math.Nary? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.NaryProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.NaryPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNaryProperties(DocumentFormat.OpenXml.Math.Nary? openXmlElement, DocumentModel.Math.NaryProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NaryProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.NaryPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.NaryProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Lower limit (n-ary) .
  /// </summary>
  public static DocumentModel.Math.SubArgument? GetSubArgument(DocumentFormat.OpenXml.Math.Nary? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSubArgument(DocumentFormat.OpenXml.Math.Nary? openXmlElement, DocumentModel.Math.SubArgument? value)
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
  /// Upper limit (n-ary).
  /// </summary>
  public static DocumentModel.Math.SuperArgument? GetSuperArgument(DocumentFormat.OpenXml.Math.Nary? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSuperArgument(DocumentFormat.OpenXml.Math.Nary? openXmlElement, DocumentModel.Math.SuperArgument? value)
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
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.Nary? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.Nary? openXmlElement, DocumentModel.Math.Base? value)
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
  
  public static DocumentModel.Math.Nary? CreateModelElement(DocumentFormat.OpenXml.Math.Nary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Nary();
      value.NaryProperties = GetNaryProperties(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Nary? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Nary, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNaryProperties(openXmlElement, value?.NaryProperties);
      SetSubArgument(openXmlElement, value?.SubArgument);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
