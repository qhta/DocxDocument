namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Vector3DType Class.
/// </summary>
public static class Vector3DTypeConverter
{
  /// <summary>
  /// Distance along X-axis in 3D
  /// </summary>
  public static Int64? GetDx(DocumentFormat.OpenXml.Drawing.Vector3DType? openXmlElement)
  {
    return openXmlElement?.Dx?.Value;
  }
  
  public static void SetDx(DocumentFormat.OpenXml.Drawing.Vector3DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dx = value;
  }
  
  /// <summary>
  /// Distance along Y-axis in 3D
  /// </summary>
  public static Int64? GetDy(DocumentFormat.OpenXml.Drawing.Vector3DType? openXmlElement)
  {
    return openXmlElement?.Dy?.Value;
  }
  
  public static void SetDy(DocumentFormat.OpenXml.Drawing.Vector3DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dy = value;
  }
  
  /// <summary>
  /// Distance along Z-axis in 3D
  /// </summary>
  public static Int64? GetDz(DocumentFormat.OpenXml.Drawing.Vector3DType? openXmlElement)
  {
    return openXmlElement?.Dz?.Value;
  }
  
  public static void SetDz(DocumentFormat.OpenXml.Drawing.Vector3DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dz = value;
  }
  
  public static DocumentModel.Drawings.Vector3DType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Vector3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Vector3DType();
      value.Dx = GetDx(openXmlElement);
      value.Dy = GetDy(openXmlElement);
      value.Dz = GetDz(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Vector3DType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Vector3DType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
