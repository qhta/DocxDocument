namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  /// Rule ID
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  private static DocumentModel.Vml.RuleKind? GetType(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DocumentModel.Vml.RuleKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement, DocumentModel.Vml.RuleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DocumentModel.Vml.RuleKind>(value);
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  private static DocumentModel.Vml.AlignmentKind? GetHow(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DocumentModel.Vml.AlignmentKind>(openXmlElement?.How?.Value);
  }
  
  private static void SetHow(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement, DocumentModel.Vml.AlignmentKind? value)
  {
    openXmlElement.How = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DocumentModel.Vml.AlignmentKind>(value);
  }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  private static String? GetShapeReference(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement)
  {
    return openXmlElement?.ShapeReference?.Value;
  }
  
  private static void SetShapeReference(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeReference = new StringValue { Value = value };
    else
      openXmlElement.ShapeReference = null;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Vml.Proxy> GetProxies(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Vml.Proxy>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Proxy>())
    {
      var newItem = DocumentModel.OpenXml.Vml.ProxyConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetProxies(DocumentFormat.OpenXml.Vml.Office.Rule openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Vml.Proxy>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Proxy>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Vml.ProxyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Proxy>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.Rule? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Rule();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.How = GetHow(openXmlElement);
      value.ShapeReference = GetShapeReference(openXmlElement);
      value.Proxies = GetProxies(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Rule? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Rule, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetType(openXmlElement, value?.Type);
      SetHow(openXmlElement, value?.How);
      SetShapeReference(openXmlElement, value?.ShapeReference);
      SetProxies(openXmlElement, value?.Proxies);
      return openXmlElement;
    }
    return default;
  }
}
