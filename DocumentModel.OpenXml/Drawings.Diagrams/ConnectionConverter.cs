namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Connection.
/// </summary>
public static class ConnectionConverter
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  private static String? GetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return openXmlElement?.ModelId?.Value;
  }
  
  private static void SetModelId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ModelId = new StringValue { Value = value };
    else
      openXmlElement.ModelId = null;
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ConnectionKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues, DocumentModel.Drawings.Diagrams.ConnectionKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, DocumentModel.Drawings.Diagrams.ConnectionKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues, DocumentModel.Drawings.Diagrams.ConnectionKind>(value);
  }
  
  /// <summary>
  /// Source Identifier
  /// </summary>
  private static String? GetSourceId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return openXmlElement?.SourceId?.Value;
  }
  
  private static void SetSourceId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SourceId = new StringValue { Value = value };
    else
      openXmlElement.SourceId = null;
  }
  
  /// <summary>
  /// Destination Identifier
  /// </summary>
  private static String? GetDestinationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return openXmlElement?.DestinationId?.Value;
  }
  
  private static void SetDestinationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DestinationId = new StringValue { Value = value };
    else
      openXmlElement.DestinationId = null;
  }
  
  /// <summary>
  /// Source Position
  /// </summary>
  private static UInt32? GetSourcePosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return openXmlElement.SourcePosition?.Value;
  }
  
  private static void SetSourcePosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, UInt32? value)
  {
    openXmlElement.SourcePosition = value;
  }
  
  /// <summary>
  /// Destination Position
  /// </summary>
  private static UInt32? GetDestinationPosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return openXmlElement.DestinationPosition?.Value;
  }
  
  private static void SetDestinationPosition(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, UInt32? value)
  {
    openXmlElement.DestinationPosition = value;
  }
  
  /// <summary>
  /// Parent Transition Identifier
  /// </summary>
  private static String? GetParentTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return openXmlElement?.ParentTransitionId?.Value;
  }
  
  private static void SetParentTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ParentTransitionId = new StringValue { Value = value };
    else
      openXmlElement.ParentTransitionId = null;
  }
  
  /// <summary>
  /// Sibling Transition Identifier
  /// </summary>
  private static String? GetSiblingTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return openXmlElement?.SiblingTransitionId?.Value;
  }
  
  private static void SetSiblingTransitionId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SiblingTransitionId = new StringValue { Value = value };
    else
      openXmlElement.SiblingTransitionId = null;
  }
  
  /// <summary>
  /// Presentation Identifier
  /// </summary>
  private static String? GetPresentationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    return openXmlElement?.PresentationId?.Value;
  }
  
  private static void SetPresentationId(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.PresentationId = new StringValue { Value = value };
    else
      openXmlElement.PresentationId = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetModelId(openXmlElement, value?.ModelId);
      SetType(openXmlElement, value?.Type);
      SetSourceId(openXmlElement, value?.SourceId);
      SetDestinationId(openXmlElement, value?.DestinationId);
      SetSourcePosition(openXmlElement, value?.SourcePosition);
      SetDestinationPosition(openXmlElement, value?.DestinationPosition);
      SetParentTransitionId(openXmlElement, value?.ParentTransitionId);
      SetSiblingTransitionId(openXmlElement, value?.SiblingTransitionId);
      SetPresentationId(openXmlElement, value?.PresentationId);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
