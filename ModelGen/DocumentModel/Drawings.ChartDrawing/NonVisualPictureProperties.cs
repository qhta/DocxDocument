namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Picture Properties.
/// </summary>
public partial class NonVisualPictureProperties: ModelElement<DXDCD.NonVisualPictureProperties>
{
  public NonVisualPictureProperties(): base(){ }
  
  public NonVisualPictureProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualPictureProperties(DXDCD.NonVisualPictureProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualDrawingProperties,DXDCD.NonVisualDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualDrawingProperties,DXDCD.NonVisualDrawingProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Non-Visual Picture Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualPictureDrawingProperties,DXDCD.NonVisualPictureDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualPictureDrawingProperties,DXDCD.NonVisualPictureDrawingProperties>(value);
    }
  }
  
}
