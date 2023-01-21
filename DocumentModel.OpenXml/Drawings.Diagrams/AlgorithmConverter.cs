namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Algorithm.
/// </summary>
public static class AlgorithmConverter
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  private static DMDrawsDgms.AlgorithmKind? GetType(DXDrawDgms.Algorithm openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DMDrawsDgms.AlgorithmKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXDrawDgms.Algorithm openXmlElement, DMDrawsDgms.AlgorithmKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues, DMDrawsDgms.AlgorithmKind>(value);
  }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  private static UInt32? GetRevision(DXDrawDgms.Algorithm openXmlElement)
  {
    return openXmlElement.Revision?.Value;
  }
  
  private static void SetRevision(DXDrawDgms.Algorithm openXmlElement, UInt32? value)
  {
    openXmlElement.Revision = value;
  }
  
  private static Collection<DMDrawsDgms.Parameter> GetParameters(DXDrawDgms.Algorithm openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Parameter>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Parameter>())
    {
      var newItem = DMXDrawsDgms.ParameterConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetParameters(DXDrawDgms.Algorithm openXmlElement, Collection<DMDrawsDgms.Parameter>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Parameter>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ParameterConverter.CreateOpenXmlElement<DXDrawDgms.Parameter>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.Algorithm openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawDgms.Algorithm openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.Algorithm? CreateModelElement(DXDrawDgms.Algorithm? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Algorithm();
      value.Type = GetType(openXmlElement);
      value.Revision = GetRevision(openXmlElement);
      value.Parameters = GetParameters(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Algorithm? value)
    where OpenXmlElementType: DXDrawDgms.Algorithm, new()
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
