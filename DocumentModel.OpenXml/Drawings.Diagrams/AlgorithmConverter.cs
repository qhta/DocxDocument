using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Algorithm = DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm;
using Parameter = DocumentModel.Drawings.Diagrams.Parameter;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Algorithm.
/// </summary>
public static class AlgorithmConverter
{
  /// <summary>
  ///   Algorithm Type
  /// </summary>
  public static AlgorithmKind? GetType(Algorithm? openXmlElement)
  {
    return EnumValueConverter.GetValue<AlgorithmValues, AlgorithmKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Algorithm? openXmlElement, AlgorithmKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<AlgorithmValues, AlgorithmKind>(value);
  }

  /// <summary>
  ///   Revision Number
  /// </summary>
  public static UInt32? GetRevision(Algorithm? openXmlElement)
  {
    return openXmlElement?.Revision?.Value;
  }

  public static void SetRevision(Algorithm? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Revision = value;
  }

  public static Collection<Parameter>? GetParameters(Algorithm? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Parameter>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>())
      {
        var newItem = ParameterConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetParameters(Algorithm? openXmlElement, Collection<Parameter>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ParameterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(Algorithm? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Algorithm? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.Algorithm? CreateModelElement(Algorithm? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Algorithm();
      value.Type = GetType(openXmlElement);
      value.Revision = GetRevision(openXmlElement);
      value.Parameters = GetParameters(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Algorithm? value)
    where OpenXmlElementType : Algorithm, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetRevision(openXmlElement, value?.Revision);
      SetParameters(openXmlElement, value?.Parameters);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}