namespace DocumentModel.Drawings;


/// <summary>
///   This element defines that a gradient fill follows a path vs. a linear line.
/// </summary>
public partial class Path: ModelElement<DXD.Path>
{
  public Path(): base(){ }
  
  public Path(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Path(DXD.Path openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Path Width
  /// </summary>
  [DataMember]
  public Int64? Width
  {
    get
    {
      return _Element?.Width?.Value;
    }
    set
    {
      _ExistingElement.Width = value;
    }
  }
  
  
  /// <summary>
  ///   Path Height
  /// </summary>
  [DataMember]
  public Int64? Height
  {
    get
    {
      return _Element?.Height?.Value;
    }
    set
    {
      _ExistingElement.Height = value;
    }
  }
  
  
  /// <summary>
  ///   Path Stroke
  /// </summary>
  [DataMember]
  public Boolean? Stroke
  {
    get
    {
      return _Element?.Stroke?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Stroke = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Stroke = null;
    }
  }
  
  
  /// <summary>
  ///   3D Extrusion Allowed
  /// </summary>
  [DataMember]
  public Boolean? ExtrusionOk
  {
    get
    {
      return _Element?.ExtrusionOk?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ExtrusionOk = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ExtrusionOk = null;
    }
  }
  
}
