namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public class SurfaceTypeImpl: ModelElementImpl, SurfaceType
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SurfaceTypeImpl(): base() {}
  
  public SurfaceTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Thickness.
  /// </summary>
  public virtual Byte? Thickness
  {
    get => (System.Byte?)OpenXmlElement?.Thickness?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Thickness != null)
        {
          if (value is not null)
            OpenXmlElement.Thickness.Val = (System.Byte?)value;
          else
            OpenXmlElement.Thickness = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Thickness = new DocumentFormat.OpenXml.Drawing.Charts.Thickness{ Val = (System.Byte?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.PictureOptions? PictureOptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
