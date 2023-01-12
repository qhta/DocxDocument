namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Graphic Frame Locks.
/// </summary>
public static class GraphicFrameLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public static Boolean? GetNoGrouping(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  public static void SetNoGrouping(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Selection of Child Shapes
  /// </summary>
  public static Boolean? GetNoDrilldown(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoDrilldown?.Value;
  }
  
  public static void SetNoDrilldown(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoDrilldown = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoDrilldown = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public static Boolean? GetNoSelection(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  public static void SetNoSelection(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public static Boolean? GetNoChangeAspect(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  public static void SetNoChangeAspect(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  public static Boolean? GetNoMove(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  public static void SetNoMove(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  public static Boolean? GetNoResize(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  public static void SetNoResize(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement, Boolean? value)
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
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.GraphicFrameLocks? CreateModelElement(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GraphicFrameLocks();
      value.NoGrouping = GetNoGrouping(openXmlElement);
      value.NoDrilldown = GetNoDrilldown(openXmlElement);
      value.NoSelection = GetNoSelection(openXmlElement);
      value.NoChangeAspect = GetNoChangeAspect(openXmlElement);
      value.NoMove = GetNoMove(openXmlElement);
      value.NoResize = GetNoResize(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.GraphicFrameLocks? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.GraphicFrameLocks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoGrouping(openXmlElement, value?.NoGrouping);
      SetNoDrilldown(openXmlElement, value?.NoDrilldown);
      SetNoSelection(openXmlElement, value?.NoSelection);
      SetNoChangeAspect(openXmlElement, value?.NoChangeAspect);
      SetNoMove(openXmlElement, value?.NoMove);
      SetNoResize(openXmlElement, value?.NoResize);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
