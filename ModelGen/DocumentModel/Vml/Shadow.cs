namespace DocumentModel.Vml;


/// <summary>
///   Defines the Shadow Class.
/// </summary>
public partial class Shadow: ModelElement<DXV.Shadow>
{
  public Shadow(): base(){ }
  
  public Shadow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shadow(DXV.Shadow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get
    {
      return _Element?.On?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.On = value;
      else
        _ExistingElement.On = null;
    }
  }
  
  
  /// <summary>
  ///   Shadow Transparency
  /// </summary>
  [DataMember]
  public Boolean? Obscured
  {
    get
    {
      return _Element?.Obscured?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Obscured = value;
      else
        _ExistingElement.Obscured = null;
    }
  }
  
  
  /// <summary>
  ///   Shadow Primary Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color);
    }
    set
    {
      _ExistingElement.Color = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shadow Opacity
  /// </summary>
  [DataMember]
  public String? Opacity
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Opacity);
    }
    set
    {
      _ExistingElement.Opacity = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shadow Primary Offset
  /// </summary>
  [DataMember]
  public String? Offset
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Offset);
    }
    set
    {
      _ExistingElement.Offset = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shadow Secondary Color
  /// </summary>
  [DataMember]
  public String? Color2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color2);
    }
    set
    {
      _ExistingElement.Color2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shadow Secondary Offset
  /// </summary>
  [DataMember]
  public String? Offset2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Offset2);
    }
    set
    {
      _ExistingElement.Offset2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shadow Origin
  /// </summary>
  [DataMember]
  public String? Origin
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Origin);
    }
    set
    {
      _ExistingElement.Origin = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shadow Perspective Matrix
  /// </summary>
  [DataMember]
  public String? Matrix
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Matrix);
    }
    set
    {
      _ExistingElement.Matrix = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
