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
        _ExistingElement.PreferRelativeResize = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXD.PictureLocks>();
      if (element != null)
        return PictureLocksConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PictureLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureLocksConverter.CreateOpenXmlElement<DXD.PictureLocks>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.NonVisualPicturePropertiesExtensionList>();
      if (element != null)
        return NonVisualPicturePropertiesExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NonVisualPicturePropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualPicturePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.NonVisualPicturePropertiesExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
