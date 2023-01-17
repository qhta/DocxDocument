namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D view settings.
/// </summary>
public static class View3DConverter
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  private static SByte? GetRotateX(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RotateX>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRotateX(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement, SByte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RotateX>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.RotateX{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  private static UInt16? GetHeightPercent(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeightPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHeightPercent(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeightPercent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.HeightPercent{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  private static UInt16? GetRotateY(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RotateY>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRotateY(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RotateY>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.RotateY{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  private static UInt16? GetDepthPercent(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DepthPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDepthPercent(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DepthPercent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.DepthPercent{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  private static Boolean? GetRightAngleAxes(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RightAngleAxes>();
    return itemElement != null;
  }
  
  private static void SetRightAngleAxes(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RightAngleAxes>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.RightAngleAxes();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  private static Byte? GetPerspective(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Perspective>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPerspective(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Perspective>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Perspective{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.View3D openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.View3D? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.View3D();
      value.RotateX = GetRotateX(openXmlElement);
      value.HeightPercent = GetHeightPercent(openXmlElement);
      value.RotateY = GetRotateY(openXmlElement);
      value.DepthPercent = GetDepthPercent(openXmlElement);
      value.RightAngleAxes = GetRightAngleAxes(openXmlElement);
      value.Perspective = GetPerspective(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.View3D? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.View3D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotateX(openXmlElement, value?.RotateX);
      SetHeightPercent(openXmlElement, value?.HeightPercent);
      SetRotateY(openXmlElement, value?.RotateY);
      SetDepthPercent(openXmlElement, value?.DepthPercent);
      SetRightAngleAxes(openXmlElement, value?.RightAngleAxes);
      SetPerspective(openXmlElement, value?.Perspective);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
