namespace DocumentModel.Math;


/// <summary>
///   Delimiter Properties.
/// </summary>
public partial class DelimiterProperties: ModelElement<DXM.DelimiterProperties>
{
  public DelimiterProperties(): base(){ }
  
  public DelimiterProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DelimiterProperties(DXM.DelimiterProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Delimiter Beginning Character.
  /// </summary>
  [DataMember]
  public DMM.BeginChar? BeginChar
  {
    get
    {
      return _Element?.GetObject<DMM.BeginChar,DXM.BeginChar>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.BeginChar,DXM.BeginChar>(value);
    }
  }
  
  
  /// <summary>
  ///   Delimiter Separator Character.
  /// </summary>
  [DataMember]
  public DMM.SeparatorChar? SeparatorChar
  {
    get
    {
      return _Element?.GetObject<DMM.SeparatorChar,DXM.SeparatorChar>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SeparatorChar,DXM.SeparatorChar>(value);
    }
  }
  
  
  /// <summary>
  ///   Delimiter Ending Character.
  /// </summary>
  [DataMember]
  public DMM.EndChar? EndChar
  {
    get
    {
      return _Element?.GetObject<DMM.EndChar,DXM.EndChar>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.EndChar,DXM.EndChar>(value);
    }
  }
  
  
  /// <summary>
  ///   Delimiter Grow.
  /// </summary>
  [DataMember]
  public DMM.GrowOperators? GrowOperators
  {
    get
    {
      return _Element?.GetObject<DMM.GrowOperators,DXM.GrowOperators>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.GrowOperators,DXM.GrowOperators>(value);
    }
  }
  
  
  /// <summary>
  ///   Shape (Delimiters).
  /// </summary>
  [DataMember]
  public DMM.ShapeDelimiterKind? Shape
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>(_ExistingElement.GetFirstChild<DXM.Shape>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Shape>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>(itemElement, (DMM.ShapeDelimiterKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.Shape, DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>((DMM.ShapeDelimiterKind)value));
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ControlProperties,DXM.ControlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ControlProperties,DXM.ControlProperties>(value);
    }
  }
  
}
