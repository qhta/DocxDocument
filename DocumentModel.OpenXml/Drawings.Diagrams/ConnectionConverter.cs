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
    return openXmlElement?.ModelId?.Value;
  }
  
  public static void SetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ModelId = new StringValue { Value = value };
      else
        openXmlElement.ModelId = null;
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
    return openXmlElement?.SourceId?.Value;
  }
  
  public static void SetSourceId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SourceId = new StringValue { Value = value };
      else
        openXmlElement.SourceId = null;
  }
  
  /// <summary>
  /// Destination Identifier
  /// </summary>
  public static String? GetDestinationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    return openXmlElement?.DestinationId?.Value;
  }
  
  public static void SetDestinationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DestinationId = new StringValue { Value = value };
      else
        openXmlElement.DestinationId = null;
  }
  
  /// <summary>
  /// Source Position
  /// </summary>
  public static UInt32? GetSourcePosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    return openXmlElement?.SourcePosition?.Value;
  }
  
  public static void SetSourcePosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SourcePosition = value;
  }
  
  /// <summary>
  /// Destination Position
  /// </summary>
  public static UInt32? GetDestinationPosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    return openXmlElement?.DestinationPosition?.Value;
  }
  
  public static void SetDestinationPosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DestinationPosition = value;
  }
  
  /// <summary>
  /// Parent Transition Identifier
  /// </summary>
  public static String? GetParentTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    return openXmlElement?.ParentTransitionId?.Value;
  }
  
  public static void SetParentTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ParentTransitionId = new StringValue { Value = value };
      else
        openXmlElement.ParentTransitionId = null;
  }
  
  /// <summary>
  /// Sibling Transition Identifier
  /// </summary>
  public static String? GetSiblingTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    return openXmlElement?.SiblingTransitionId?.Value;
  }
  
  public static void SetSiblingTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SiblingTransitionId = new StringValue { Value = value };
      else
        openXmlElement.SiblingTransitionId = null;
  }
  
  /// <summary>
  /// Presentation Identifier
  /// </summary>
  public static String? GetPresentationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    return openXmlElement?.PresentationId?.Value;
  }
  
  public static void SetPresentationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PresentationId = new StringValue { Value = value };
      else
        openXmlElement.PresentationId = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.Connection? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Connection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Connection();
      value.ModelId = GetModelId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.SourceId = GetSourceId(openXmlElement);
      value.DestinationId = GetDestinationId(openXmlElement);
      value.SourcePosition = GetSourcePosition(openXmlElement);
      value.DestinationPosition = GetDestinationPosition(openXmlElement);
      value.ParentTransitionId = GetParentTransitionId(openXmlElement);
      value.SiblingTransitionId = GetSiblingTransitionId(openXmlElement);
      value.PresentationId = GetPresentationId(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Connection? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Connection, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
