namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Presentation Of.
/// </summary>
public static class PresentationOfConverter
{
  /// <summary>
  /// Axis
  /// </summary>
  public static DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? GetAxis(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.EnumValue`1[DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues]]");
  }
  
  public static void SetAxis(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement, DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.EnumValue`1[DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues]]");
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public static DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? GetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.EnumValue`1[DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues]]");
  }
  
  public static void SetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement, DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.EnumValue`1[DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues]]");
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public static DocumentModel.ListOf<Boolean>? GetHideLastTrans(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.BooleanValue]");
  }
  
  public static void SetHideLastTrans(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement, DocumentModel.ListOf<Boolean>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.BooleanValue]");
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public static DocumentModel.ListOf<Int32>? GetStart(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.Int32Value]");
  }
  
  public static void SetStart(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement, DocumentModel.ListOf<Int32>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.Int32Value]");
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public static DocumentModel.ListOf<UInt32>? GetCount(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.UInt32Value]");
  }
  
  public static void SetCount(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement, DocumentModel.ListOf<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.UInt32Value]");
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public static DocumentModel.ListOf<Int32>? GetStep(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.Int32Value]");
  }
  
  public static void SetStep(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement, DocumentModel.ListOf<Int32>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.Int32Value]");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.PresentationOf? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PresentationOf();
      value.Axis = GetAxis(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.HideLastTrans = GetHideLastTrans(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.Step = GetStep(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.PresentationOf? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
