namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Algorithm.
/// </summary>
public static class AlgorithmConverter
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.AlgorithmKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DocumentModel.Drawings.Diagrams.AlgorithmKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement, DocumentModel.Drawings.Diagrams.AlgorithmKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DocumentModel.Drawings.Diagrams.AlgorithmKind>(value);
  }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public static UInt32? GetRevision(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement)
  {
    return openXmlElement?.Revision?.Value;
  }
  
  public static void SetRevision(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Revision = value;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Parameter>? GetParameters(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Parameter>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ParameterConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetParameters(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Parameter>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ParameterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Algorithm? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetRevision(openXmlElement, value?.Revision);
      return openXmlElement;
    }
    return default;
  }
}
