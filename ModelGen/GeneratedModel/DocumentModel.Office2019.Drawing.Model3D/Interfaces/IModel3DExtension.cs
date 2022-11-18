namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the Model3DExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Animation.Model3D.IEmbeddedAnimation))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Animation.Model3D.IPosterFrame))]
public interface IModel3DExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Uri { get ; set; }
  
}
