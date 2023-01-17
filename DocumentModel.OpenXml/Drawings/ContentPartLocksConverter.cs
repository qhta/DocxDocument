namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ContentPartLocks Class.
/// </summary>
public static class ContentPartLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static void SetNoGrouping(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static void SetNoSelection(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  private static Boolean? GetNoRotation(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }
  
  private static void SetNoRotation(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoRotation = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static void SetNoChangeAspect(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  private static Boolean? GetNoMove(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static void SetNoMove(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  private static Boolean? GetNoResize(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static void SetNoResize(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// Disallow Shape Point Editing
  /// </summary>
  private static Boolean? GetNoEditPoints(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }
  
  private static void SetNoEditPoints(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoEditPoints = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoEditPoints = null;
  }
  
  /// <summary>
  /// Disallow Showing Adjust Handles
  /// </summary>
  private static Boolean? GetNoAdjustHandles(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }
  
  private static void SetNoAdjustHandles(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoAdjustHandles = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoAdjustHandles = null;
  }
  
  /// <summary>
  /// Disallow Arrowhead Changes
  /// </summary>
  private static Boolean? GetNoChangeArrowheads(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }
  
  private static void SetNoChangeArrowheads(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeArrowheads = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeArrowheads = null;
  }
  
  /// <summary>
  /// Disallow Shape Type Change
  /// </summary>
  private static Boolean? GetNoChangeShapeType(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }
  
  private static void SetNoChangeShapeType(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeShapeType = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.OfficeArtExtensionList2? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OfficeArtExtensionList2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.OfficeArtExtensionList2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ContentPartLocks? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ContentPartLocks();
      value.NoGrouping = GetNoGrouping(openXmlElement);
      value.NoSelection = GetNoSelection(openXmlElement);
      value.NoRotation = GetNoRotation(openXmlElement);
      value.NoChangeAspect = GetNoChangeAspect(openXmlElement);
      value.NoMove = GetNoMove(openXmlElement);
      value.NoResize = GetNoResize(openXmlElement);
      value.NoEditPoints = GetNoEditPoints(openXmlElement);
      value.NoAdjustHandles = GetNoAdjustHandles(openXmlElement);
      value.NoChangeArrowheads = GetNoChangeArrowheads(openXmlElement);
      value.NoChangeShapeType = GetNoChangeShapeType(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ContentPartLocks? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoGrouping(openXmlElement, value?.NoGrouping);
      SetNoSelection(openXmlElement, value?.NoSelection);
      SetNoRotation(openXmlElement, value?.NoRotation);
      SetNoChangeAspect(openXmlElement, value?.NoChangeAspect);
      SetNoMove(openXmlElement, value?.NoMove);
      SetNoResize(openXmlElement, value?.NoResize);
      SetNoEditPoints(openXmlElement, value?.NoEditPoints);
      SetNoAdjustHandles(openXmlElement, value?.NoAdjustHandles);
      SetNoChangeArrowheads(openXmlElement, value?.NoChangeArrowheads);
      SetNoChangeShapeType(openXmlElement, value?.NoChangeShapeType);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
