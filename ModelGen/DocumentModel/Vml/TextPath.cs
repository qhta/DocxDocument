namespace DocumentModel.Vml;


/// <summary>
///   Defines the TextPath Class.
/// </summary>
public partial class TextPath: ModelElement<DXV.TextPath>
{
  public TextPath(): base(){ }
  
  public TextPath(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextPath(DXV.TextPath openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Shape Styling Properties
  /// </summary>
  [DataMember]
  public String? Style
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Style);
    }
    set
    {
      _ExistingElement.Style = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Text Path Toggle
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
  ///   Shape Fit Toggle
  /// </summary>
  [DataMember]
  public Boolean? FitShape
  {
    get
    {
      return _Element?.FitShape?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.FitShape = value;
      else
        _ExistingElement.FitShape = null;
    }
  }
  
  
  /// <summary>
  ///   Path Fit Toggle
  /// </summary>
  [DataMember]
  public Boolean? FitPath
  {
    get
    {
      return _Element?.FitPath?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.FitPath = value;
      else
        _ExistingElement.FitPath = null;
    }
  }
  
  
  /// <summary>
  ///   Text Path Trim Toggle
  /// </summary>
  [DataMember]
  public Boolean? Trim
  {
    get
    {
      return _Element?.Trim?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Trim = value;
      else
        _ExistingElement.Trim = null;
    }
  }
  
  
  /// <summary>
  ///   Text X-Scaling
  /// </summary>
  [DataMember]
  public Boolean? XScale
  {
    get
    {
      return _Element?.XScale?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.XScale = value;
      else
        _ExistingElement.XScale = null;
    }
  }
  
  
  /// <summary>
  ///   Text Path Text
  /// </summary>
  [DataMember]
  public String? String
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.String);
    }
    set
    {
      _ExistingElement.String = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
