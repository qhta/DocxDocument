namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the GroupShapeLocks Class.
/// </summary>
public static class GroupShapeLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public static Boolean? GetNoGrouping(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  public static void SetNoGrouping(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Ungrouping
  /// </summary>
  public static Boolean? GetNoUngrouping(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoUngrouping?.Value;
  }
  
  public static void SetNoUngrouping(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoUngrouping = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoUngrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public static Boolean? GetNoSelection(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  public static void SetNoSelection(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  public static Boolean? GetNoRotation(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }
  
  public static void SetNoRotation(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoRotation = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public static Boolean? GetNoChangeAspect(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  public static void SetNoChangeAspect(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Moving Shape
  /// </summary>
  public static Boolean? GetNoMove(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  public static void SetNoMove(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resizing
  /// </summary>
  public static Boolean? GetNoResize(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  public static void SetNoResize(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.GroupShapeLocks? CreateModelElement(DocumentFormat.OpenXml.Drawing.GroupShapeLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GroupShapeLocks();
      value.NoGrouping = GetNoGrouping(openXmlElement);
      value.NoUngrouping = GetNoUngrouping(openXmlElement);
      value.NoSelection = GetNoSelection(openXmlElement);
      value.NoRotation = GetNoRotation(openXmlElement);
      value.NoChangeAspect = GetNoChangeAspect(openXmlElement);
      value.NoMove = GetNoMove(openXmlElement);
      value.NoResize = GetNoResize(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.GroupShapeLocks? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.GroupShapeLocks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoGrouping(openXmlElement, value?.NoGrouping);
      SetNoUngrouping(openXmlElement, value?.NoUngrouping);
      SetNoSelection(openXmlElement, value?.NoSelection);
      SetNoRotation(openXmlElement, value?.NoRotation);
      SetNoChangeAspect(openXmlElement, value?.NoChangeAspect);
      SetNoMove(openXmlElement, value?.NoMove);
      SetNoResize(openXmlElement, value?.NoResize);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
