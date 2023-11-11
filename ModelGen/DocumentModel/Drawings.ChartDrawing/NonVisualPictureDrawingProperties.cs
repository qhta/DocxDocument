namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public partial class NonVisualPictureDrawingProperties: ModelElement<DXDCD.NonVisualPictureDrawingProperties>
{
  public NonVisualPictureDrawingProperties(): base(){ }
  
  public NonVisualPictureDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualPictureDrawingProperties(DXDCD.NonVisualPictureDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   preferRelativeResize
  /// </summary>
  [DataMember]
  public Boolean? PreferRelativeResize
  {
    get
    {
      return _Element?.PreferRelativeResize?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.PreferRelativeResize = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.PreferRelativeResize = null;
    }
  }
  
  
  /// <summary>
  ///   PictureLocks.
  /// </summary>
  [DataMember]
  public DMD.PictureLocks? PictureLocks
  {
    get
    {
      return _Element?.GetObject<DMD.PictureLocks,DXD.PictureLocks>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PictureLocks,DXD.PictureLocks>(value);
    }
  }
  
  
  /// <summary>
  ///   NonVisualPicturePropertiesExtensionList.
  /// </summary>
  [DataMember]
  public DMD.NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.NonVisualPicturePropertiesExtensionList,DXD.NonVisualPicturePropertiesExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NonVisualPicturePropertiesExtensionList,DXD.NonVisualPicturePropertiesExtensionList>(value);
    }
  }
  
}
