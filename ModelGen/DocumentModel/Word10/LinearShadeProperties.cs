namespace DocumentModel.Word10;


/// <summary>
///   This element specifies linear gradient.
/// </summary>
public partial class LinearShadeProperties: ModelElement<DXO10W.LinearShadeProperties>
{
  public LinearShadeProperties(): base(){ }
  
  public LinearShadeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LinearShadeProperties(DXO10W.LinearShadeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ang, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Angle
  {
    get
    {
      return _Element?.Angle?.Value;
    }
    set
    {
      _ExistingElement.Angle = value;
    }
  }
  
}
