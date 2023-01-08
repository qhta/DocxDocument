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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRevision(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Parameter>? GetParameters(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetParameters(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Parameter>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
