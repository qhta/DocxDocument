namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Presentation Of.
/// </summary>
public static class PresentationOfConverter
{
  /// <summary>
  /// Axis
  /// </summary>
  private static DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? GetAxis(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues, DocumentModel.Drawings.Diagrams.AxisKind>(openXmlElement?.Axis);
  }
  
  private static void SetAxis(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement, DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? value)
  {
    if (value != null)
      openXmlElement.Axis = ListValueConverter.CreateListValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues, DocumentModel.Drawings.Diagrams.AxisKind>(value);
    else
      openXmlElement.Axis = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? GetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(openXmlElement?.PointType);
  }
  
  private static void SetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement, DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? value)
  {
    if (value != null)
      openXmlElement.PointType = ListValueConverter.CreateListValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DocumentModel.Drawings.Diagrams.ElementKind>(value);
    else
      openXmlElement.PointType = null;
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  private static DocumentModel.ListOf<Boolean>? GetHideLastTrans(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }
  
  private static void SetHideLastTrans(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement, DocumentModel.ListOf<Boolean>? value)
  {
    if (value != null)
      openXmlElement.HideLastTrans = ListValueConverter.CreateListValue<DocumentFormat.OpenXml.BooleanValue>(value);
    else
      openXmlElement.HideLastTrans = null;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  private static DocumentModel.ListOf<Int32>? GetStart(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }
  
  private static void SetStart(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement, DocumentModel.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Start = ListValueConverter.CreateListValue<DocumentFormat.OpenXml.Int32Value>(value);
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  private static DocumentModel.ListOf<UInt32>? GetCount(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }
  
  private static void SetCount(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement, DocumentModel.ListOf<UInt32>? value)
  {
    if (value != null)
      openXmlElement.Count = ListValueConverter.CreateListValue<DocumentFormat.OpenXml.UInt32Value>(value);
    else
      openXmlElement.Count = null;
  }
  
  /// <summary>
  /// Step
  /// </summary>
  private static DocumentModel.ListOf<Int32>? GetStep(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }
  
  private static void SetStep(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement, DocumentModel.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Step = ListValueConverter.CreateListValue<DocumentFormat.OpenXml.Int32Value>(value);
    else
      openXmlElement.Step = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAxis(openXmlElement, value?.Axis);
      SetPointType(openXmlElement, value?.PointType);
      SetHideLastTrans(openXmlElement, value?.HideLastTrans);
      SetStart(openXmlElement, value?.Start);
      SetCount(openXmlElement, value?.Count);
      SetStep(openXmlElement, value?.Step);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
