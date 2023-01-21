namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  /// Rule ID
  /// </summary>
  private static String? GetId(DXVmlO.Rule openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXVmlO.Rule openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  private static DMVml.RuleKind? GetType(DXVmlO.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DMVml.RuleKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXVmlO.Rule openXmlElement, DMVml.RuleKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DMVml.RuleKind>(value);
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  private static DMVml.AlignmentKind? GetHow(DXVmlO.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DMVml.AlignmentKind>(openXmlElement?.How?.Value);
  }
  
  private static void SetHow(DXVmlO.Rule openXmlElement, DMVml.AlignmentKind? value)
  {
    openXmlElement.How = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DMVml.AlignmentKind>(value);
  }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  private static String? GetShapeReference(DXVmlO.Rule openXmlElement)
  {
    return openXmlElement?.ShapeReference?.Value;
  }
  
  private static void SetShapeReference(DXVmlO.Rule openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeReference = new StringValue { Value = value };
    else
      openXmlElement.ShapeReference = null;
  }
  
  private static Collection<DMVml.Proxy> GetProxies(DXVmlO.Rule openXmlElement)
  {
    var collection = new Collection<DMVml.Proxy>();
    foreach (var item in openXmlElement.Elements<DXVmlO.Proxy>())
    {
      var newItem = DMXVml.ProxyConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetProxies(DXVmlO.Rule openXmlElement, Collection<DMVml.Proxy>? value)
  {
    openXmlElement.RemoveAllChildren<DXVmlO.Proxy>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXVml.ProxyConverter.CreateOpenXmlElement<DXVmlO.Proxy>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMVml.Rule? CreateModelElement(DXVmlO.Rule? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Rule();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.How = GetHow(openXmlElement);
      value.ShapeReference = GetShapeReference(openXmlElement);
      value.Proxies = GetProxies(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Rule? value)
    where OpenXmlElementType: DXVmlO.Rule, new()
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
