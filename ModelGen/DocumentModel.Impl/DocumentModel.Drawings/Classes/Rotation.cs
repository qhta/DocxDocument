namespace DocumentModel.Drawings;

/// <summary>
/// Rotation.
/// </summary>
public partial class RotationImpl: ModelElementImpl, Rotation
{
  public DocumentFormat.OpenXml.Drawing.Rotation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Rotation?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RotationImpl(): base() {}
  
  public RotationImpl(DocumentFormat.OpenXml.Drawing.Rotation openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Latitude
  /// </summary>
  public Int32? Latitude
  {
    get => (System.Int32?)OpenXmlElement?.Latitude?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Latitude = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Longitude
  /// </summary>
  public Int32? Longitude
  {
    get => (System.Int32?)OpenXmlElement?.Longitude?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Longitude = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Revolution
  /// </summary>
  public Int32? Revolution
  {
    get => (System.Int32?)OpenXmlElement?.Revolution?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Revolution = (System.Int32?)value;
    }
  }
  
}
