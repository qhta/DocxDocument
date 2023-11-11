namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Shape Definition.
/// </summary>
public partial class Shape: ModelElement<DXDCD.Shape>
{
  public Shape(): base(){ }
  
  public Shape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shape(DXDCD.Shape openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Text Link
  /// </summary>
  [DataMember]
  public String? TextLink
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.TextLink);
    }
    set
    {
      _ExistingElement.TextLink = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Lock Text
  /// </summary>
  [DataMember]
  public Boolean? LockText
  {
    get
    {
      return _Element?.LockText?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LockText = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.LockText = null;
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
  ///   Non-Visual Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualShapeProperties? NonVisualShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualShapeProperties,DXDCD.NonVisualShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualShapeProperties,DXDCD.NonVisualShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Properties.
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
  ///   Shape Style.
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
  
  
  /// <summary>
  ///   Shape Text Body.
  /// </summary>
  [DataMember]
  public DMDCD.TextBody? TextBody
  {
    get
    {
      return _Element?.GetObject<DMDCD.TextBody,DXDCD.TextBody>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.TextBody,DXDCD.TextBody>(value);
    }
  }
  
}
