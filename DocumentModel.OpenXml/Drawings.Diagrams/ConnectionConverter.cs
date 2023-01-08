namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Connection.
/// </summary>
public static class ConnectionConverter
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public static String? GetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ConnectionKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues, DocumentModel.Drawings.Diagrams.ConnectionKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, DocumentModel.Drawings.Diagrams.ConnectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues, DocumentModel.Drawings.Diagrams.ConnectionKind>(value);
  }
  
  /// <summary>
  /// Source Identifier
  /// </summary>
  public static String? GetSourceId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSourceId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Destination Identifier
  /// </summary>
  public static String? GetDestinationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetDestinationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Source Position
  /// </summary>
  public static UInt32? GetSourcePosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSourcePosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Destination Position
  /// </summary>
  public static UInt32? GetDestinationPosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDestinationPosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Parent Transition Identifier
  /// </summary>
  public static String? GetParentTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetParentTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Sibling Transition Identifier
  /// </summary>
  public static String? GetSiblingTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSiblingTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Presentation Identifier
  /// </summary>
  public static String? GetPresentationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetPresentationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
