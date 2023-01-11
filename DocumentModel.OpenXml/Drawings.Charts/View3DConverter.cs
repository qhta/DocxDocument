namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D view settings.
/// </summary>
public static class View3DConverter
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  public static SByte? GetRotateX(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.RotateX");
  }
  
  public static void SetRotateX(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement, SByte? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.RotateX");
  }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  public static UInt16? GetHeightPercent(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.HeightPercent");
  }
  
  public static void SetHeightPercent(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.HeightPercent");
  }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  public static UInt16? GetRotateY(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.RotateY");
  }
  
  public static void SetRotateY(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.RotateY");
  }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  public static UInt16? GetDepthPercent(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.DepthPercent");
  }
  
  public static void SetDepthPercent(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.DepthPercent");
  }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  public static Boolean? GetRightAngleAxes(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RightAngleAxes>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRightAngleAxes(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  public static Byte? GetPerspective(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Perspective");
  }
  
  public static void SetPerspective(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement, Byte? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Perspective");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.View3D? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
