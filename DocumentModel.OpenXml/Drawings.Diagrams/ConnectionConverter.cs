using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Connection = DocumentFormat.OpenXml.Drawing.Diagrams.Connection;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Connection.
/// </summary>
public static class ConnectionConverter
{
  /// <summary>
  ///   Model Identifier
  /// </summary>
  public static String? GetModelId(Connection? openXmlElement)
  {
    return openXmlElement?.ModelId?.Value;
  }

  public static void SetModelId(Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ModelId = new StringValue { Value = value };
      else
        openXmlElement.ModelId = null;
  }

  /// <summary>
  ///   Point Type
  /// </summary>
  public static ConnectionKind? GetType(Connection? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConnectionValues, ConnectionKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Connection? openXmlElement, ConnectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<ConnectionValues, ConnectionKind>(value);
  }

  /// <summary>
  ///   Source Identifier
  /// </summary>
  public static String? GetSourceId(Connection? openXmlElement)
  {
    return openXmlElement?.SourceId?.Value;
  }

  public static void SetSourceId(Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SourceId = new StringValue { Value = value };
      else
        openXmlElement.SourceId = null;
  }

  /// <summary>
  ///   Destination Identifier
  /// </summary>
  public static String? GetDestinationId(Connection? openXmlElement)
  {
    return openXmlElement?.DestinationId?.Value;
  }

  public static void SetDestinationId(Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DestinationId = new StringValue { Value = value };
      else
        openXmlElement.DestinationId = null;
  }

  /// <summary>
  ///   Source Position
  /// </summary>
  public static UInt32? GetSourcePosition(Connection? openXmlElement)
  {
    return openXmlElement?.SourcePosition?.Value;
  }

  public static void SetSourcePosition(Connection? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SourcePosition = value;
  }

  /// <summary>
  ///   Destination Position
  /// </summary>
  public static UInt32? GetDestinationPosition(Connection? openXmlElement)
  {
    return openXmlElement?.DestinationPosition?.Value;
  }

  public static void SetDestinationPosition(Connection? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DestinationPosition = value;
  }

  /// <summary>
  ///   Parent Transition Identifier
  /// </summary>
  public static String? GetParentTransitionId(Connection? openXmlElement)
  {
    return openXmlElement?.ParentTransitionId?.Value;
  }

  public static void SetParentTransitionId(Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ParentTransitionId = new StringValue { Value = value };
      else
        openXmlElement.ParentTransitionId = null;
  }

  /// <summary>
  ///   Sibling Transition Identifier
  /// </summary>
  public static String? GetSiblingTransitionId(Connection? openXmlElement)
  {
    return openXmlElement?.SiblingTransitionId?.Value;
  }

  public static void SetSiblingTransitionId(Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SiblingTransitionId = new StringValue { Value = value };
      else
        openXmlElement.SiblingTransitionId = null;
  }

  /// <summary>
  ///   Presentation Identifier
  /// </summary>
  public static String? GetPresentationId(Connection? openXmlElement)
  {
    return openXmlElement?.PresentationId?.Value;
  }

  public static void SetPresentationId(Connection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PresentationId = new StringValue { Value = value };
      else
        openXmlElement.PresentationId = null;
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(Connection? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Connection? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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

  public static DocumentModel.Drawings.Diagrams.Connection? CreateModelElement(Connection? openXmlElement)
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
    where OpenXmlElementType : Connection, new()
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