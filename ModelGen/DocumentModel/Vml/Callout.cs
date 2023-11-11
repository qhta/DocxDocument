namespace DocumentModel.Vml;


/// <summary>
///   Defines the Callout Class.
/// </summary>
public partial class Callout: ModelElement<DXVO.Callout>
{
  public Callout(): base(){ }
  
  public Callout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Callout(DXVO.Callout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Callout toggle
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
  ///   Callout type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Type);
    }
    set
    {
      _ExistingElement.Type = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout gap
  /// </summary>
  [DataMember]
  public String? Gap
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Gap);
    }
    set
    {
      _ExistingElement.Gap = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout automatic drop toggle
  /// </summary>
  [DataMember]
  public Boolean? DropAuto
  {
    get
    {
      return _Element?.DropAuto?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.DropAuto = value;
      else
        _ExistingElement.DropAuto = null;
    }
  }
  
  
  /// <summary>
  ///   Callout drop position
  /// </summary>
  [DataMember]
  public String? Drop
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Drop);
    }
    set
    {
      _ExistingElement.Drop = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout drop distance
  /// </summary>
  [DataMember]
  public String? Distance
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Distance);
    }
    set
    {
      _ExistingElement.Distance = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout length toggle
  /// </summary>
  [DataMember]
  public Boolean? LengthSpecified
  {
    get
    {
      return _Element?.LengthSpecified?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LengthSpecified = value;
      else
        _ExistingElement.LengthSpecified = null;
    }
  }
  
  
  /// <summary>
  ///   Callout length
  /// </summary>
  [DataMember]
  public String? Length
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Length);
    }
    set
    {
      _ExistingElement.Length = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Callout accent bar toggle
  /// </summary>
  [DataMember]
  public Boolean? AccentBar
  {
    get
    {
      return _Element?.AccentBar?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AccentBar = value;
      else
        _ExistingElement.AccentBar = null;
    }
  }
  
  
  /// <summary>
  ///   Callout text border toggle
  /// </summary>
  [DataMember]
  public Boolean? TextBorder
  {
    get
    {
      return _Element?.TextBorder?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.TextBorder = value;
      else
        _ExistingElement.TextBorder = null;
    }
  }
  
  
  /// <summary>
  ///   Callout flip x
  /// </summary>
  [DataMember]
  public Boolean? MinusX
  {
    get
    {
      return _Element?.MinusX?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.MinusX = value;
      else
        _ExistingElement.MinusX = null;
    }
  }
  
  
  /// <summary>
  ///   Callout flip y
  /// </summary>
  [DataMember]
  public Boolean? MinusY
  {
    get
    {
      return _Element?.MinusY?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.MinusY = value;
      else
        _ExistingElement.MinusY = null;
    }
  }
  
}
