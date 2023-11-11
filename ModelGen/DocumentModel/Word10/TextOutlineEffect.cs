namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the outline style to be applied to text. By default, text does not have outline.
/// </summary>
public partial class TextOutlineEffect: ModelElement<DXO10W.TextOutlineEffect>
{
  public TextOutlineEffect(): base(){ }
  
  public TextOutlineEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextOutlineEffect(DXO10W.TextOutlineEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? LineWidth
  {
    get
    {
      return _Element?.LineWidth?.Value;
    }
    set
    {
      _ExistingElement.LineWidth = value;
    }
  }
  
  [DataMember]
  public DMW10.NoFillEmpty? NoFillEmpty
  {
    get
    {
      return _Element?.GetObject<DMW10.NoFillEmpty,DXO10W.NoFillEmpty>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.NoFillEmpty,DXO10W.NoFillEmpty>(value);
    }
  }
  
  [DataMember]
  public DMW10.SolidColorFillProperties? SolidColorFillProperties
  {
    get
    {
      return _Element?.GetObject<DMW10.SolidColorFillProperties,DXO10W.SolidColorFillProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.SolidColorFillProperties,DXO10W.SolidColorFillProperties>(value);
    }
  }
  
  [DataMember]
  public DMW10.GradientFillProperties? GradientFillProperties
  {
    get
    {
      return _Element?.GetObject<DMW10.GradientFillProperties,DXO10W.GradientFillProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.GradientFillProperties,DXO10W.GradientFillProperties>(value);
    }
  }
  
  [DataMember]
  public DMW10.PresetLineDashKind? PresetLineDashProperties
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW10.PresetLineDashKind>(_ExistingElement.GetFirstChild<DXO10W.PresetLineDashProperties>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.PresetLineDashProperties>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW10.PresetLineDashKind>(itemElement, (DMW10.PresetLineDashKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.PresetLineDashProperties, DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW10.PresetLineDashKind>((DMW10.PresetLineDashKind)value));
    }
  }
  
  [DataMember]
  public DMW10.RoundEmpty? RoundEmpty
  {
    get
    {
      return _Element?.GetObject<DMW10.RoundEmpty,DXO10W.RoundEmpty>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.RoundEmpty,DXO10W.RoundEmpty>(value);
    }
  }
  
  [DataMember]
  public DMW10.BevelEmpty? BevelEmpty
  {
    get
    {
      return _Element?.GetObject<DMW10.BevelEmpty,DXO10W.BevelEmpty>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.BevelEmpty,DXO10W.BevelEmpty>(value);
    }
  }
  
  [DataMember]
  public DMW10.LineJoinMiterProperties? LineJoinMiterProperties
  {
    get
    {
      return _Element?.GetObject<DMW10.LineJoinMiterProperties,DXO10W.LineJoinMiterProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.LineJoinMiterProperties,DXO10W.LineJoinMiterProperties>(value);
    }
  }
  
}
