namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an outline style that can be applied to a number of different objects such as shapes and text. The line allows for the specifying of many different types of outlines including even line dashes and bevels.
/// </summary>
public partial class Outline: ModelElement<DXD.Outline>
{
  public Outline(): base(){ }
  
  public Outline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Outline(DXD.Outline openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get
    {
      return _Element?.GetObject<DMD.NoFill,DXD.NoFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NoFill,DXD.NoFill>(value);
    }
  }
  
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get
    {
      return _Element?.GetObject<DMD.SolidFill,DXD.SolidFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SolidFill,DXD.SolidFill>(value);
    }
  }
  
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get
    {
      return _Element?.GetObject<DMD.GradientFill,DXD.GradientFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GradientFill,DXD.GradientFill>(value);
    }
  }
  
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get
    {
      return _Element?.GetObject<DMD.PatternFill,DXD.PatternFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PatternFill,DXD.PatternFill>(value);
    }
  }
  
  [DataMember]
  public DMD.PresetLineDashKind? PresetDash
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(_ExistingElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PresetDash>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(itemElement, (DMD.PresetLineDashKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXD.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>((DMD.PresetLineDashKind)value));
    }
  }
  
  [DataMember]
  public DMD.CustomDash? CustomDash
  {
    get
    {
      return _Element?.GetObject<DMD.CustomDash,DXD.CustomDash>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.CustomDash,DXD.CustomDash>(value);
    }
  }
  
  [DataMember]
  public DMD.Round? Round
  {
    get
    {
      return _Element?.GetObject<DMD.Round,DXD.Round>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Round,DXD.Round>(value);
    }
  }
  
  [DataMember]
  public DMD.LineJoinBevel? LineJoinBevel
  {
    get
    {
      return _Element?.GetObject<DMD.LineJoinBevel,DXD.LineJoinBevel>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LineJoinBevel,DXD.LineJoinBevel>(value);
    }
  }
  
  [DataMember]
  public DMD.Miter? Miter
  {
    get
    {
      return _Element?.GetObject<DMD.Miter,DXD.Miter>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Miter,DXD.Miter>(value);
    }
  }
  
  [DataMember]
  public DMD.HeadEnd? HeadEnd
  {
    get
    {
      return _Element?.GetObject<DMD.HeadEnd,DXD.HeadEnd>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HeadEnd,DXD.HeadEnd>(value);
    }
  }
  
  [DataMember]
  public DMD.TailEnd? TailEnd
  {
    get
    {
      return _Element?.GetObject<DMD.TailEnd,DXD.TailEnd>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.TailEnd,DXD.TailEnd>(value);
    }
  }
  
  [DataMember]
  public DMD.LinePropertiesExtensionList? LinePropertiesExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.LinePropertiesExtensionList,DXD.LinePropertiesExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LinePropertiesExtensionList,DXD.LinePropertiesExtensionList>(value);
    }
  }
  
}
