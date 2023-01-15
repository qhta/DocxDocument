using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using Proxy = DocumentModel.Vml.Proxy;
using Rule = DocumentFormat.OpenXml.Vml.Office.Rule;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  ///   Rule ID
  /// </summary>
  public static String? GetId(Rule? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Rule? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Rule Type
  /// </summary>
  public static RuleKind? GetType(Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<RuleValues, RuleKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Rule? openXmlElement, RuleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<RuleValues, RuleKind>(value);
  }

  /// <summary>
  ///   Alignment Rule Type
  /// </summary>
  public static AlignmentKind? GetHow(Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<AlignmentValues, AlignmentKind>(openXmlElement?.How?.Value);
  }

  public static void SetHow(Rule? openXmlElement, AlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.How = EnumValueConverter.CreateEnumValue<AlignmentValues, AlignmentKind>(value);
  }

  /// <summary>
  ///   Rule Shape Reference
  /// </summary>
  public static String? GetShapeReference(Rule? openXmlElement)
  {
    return openXmlElement?.ShapeReference?.Value;
  }

  public static void SetShapeReference(Rule? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeReference = new StringValue { Value = value };
      else
        openXmlElement.ShapeReference = null;
  }

  public static Collection<Proxy>? GetProxies(Rule? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Proxy>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Proxy>())
      {
        var newItem = ProxyConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetProxies(Rule? openXmlElement, Collection<Proxy>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Proxy>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ProxyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Proxy>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Vml.Rule? CreateModelElement(Rule? openXmlElement)
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
    where OpenXmlElementType : Rule, new()
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