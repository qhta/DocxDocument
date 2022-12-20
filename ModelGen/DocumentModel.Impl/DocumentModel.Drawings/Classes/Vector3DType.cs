namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Vector3DType Class.
/// </summary>
public partial class Vector3DTypeImpl: ModelElementImpl, Vector3DType
{
  public DocumentFormat.OpenXml.Drawing.Vector3DType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Vector3DType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Vector3DTypeImpl(): base() {}
  
  public Vector3DTypeImpl(DocumentFormat.OpenXml.Drawing.Vector3DType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Distance along X-axis in 3D
  /// </summary>
  public Int64? Dx
  {
    get => (System.Int64?)OpenXmlElement?.Dx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dx = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Distance along Y-axis in 3D
  /// </summary>
  public Int64? Dy
  {
    get => (System.Int64?)OpenXmlElement?.Dy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dy = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Distance along Z-axis in 3D
  /// </summary>
  public Int64? Dz
  {
    get => (System.Int64?)OpenXmlElement?.Dz?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dz = (System.Int64?)value;
    }
  }
  
}
