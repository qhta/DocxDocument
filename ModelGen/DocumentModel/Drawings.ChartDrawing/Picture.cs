namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Defines the Picture Class.
/// </summary>
public partial class Picture: ModelElement<DXDCD.Picture>
{
  public Picture(): base(){ }
  
  public Picture(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Picture(DXDCD.Picture openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Macro);
    }
    set
    {
      _ExistingElement.Macro = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Publish to Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get
    {
      return _Element?.Published?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Published = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Published = null;
    }
  }
  
  
  /// <summary>
  ///   Non-Visual Picture Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualPictureProperties? NonVisualPictureProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualPictureProperties,DXDCD.NonVisualPictureProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualPictureProperties,DXDCD.NonVisualPictureProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Picture Fill.
  /// </summary>
  [DataMember]
  public DMDCD.BlipFill? BlipFill
  {
    get
    {
      return _Element?.GetObject<DMDCD.BlipFill,DXDCD.BlipFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.BlipFill,DXDCD.BlipFill>(value);
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.ShapeProperties,DXDCD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.ShapeProperties,DXDCD.ShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Style.
  /// </summary>
  [DataMember]
  public DMDCD.Style? Style
  {
    get
    {
      return _Element?.GetObject<DMDCD.Style,DXDCD.Style>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.Style,DXDCD.Style>(value);
    }
  }
  
}
