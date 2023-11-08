namespace DocumentModel.Drawings;


/// <summary>
///   Underline Stroke.
/// </summary>
public partial class Underline: ModelElement<DXD.Underline>
{
  public Underline(): base(){ }
  
  public Underline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Underline(DXD.Underline openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.NoFill>();
      if (element != null)
        return NoFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoFillConverter.CreateOpenXmlElement<DXD.NoFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SolidFill>();
      if (element != null)
        return SolidFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GradientFill>();
      if (element != null)
        return GradientFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PatternFill>();
      if (element != null)
        return PatternFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.CustomDash>();
      if (element != null)
        return CustomDashConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.CustomDash>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomDashConverter.CreateOpenXmlElement<DXD.CustomDash>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Round? Round
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Round>();
      if (element != null)
        return RoundConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Round>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RoundConverter.CreateOpenXmlElement<DXD.Round>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.LineJoinBevel? LineJoinBevel
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LineJoinBevel>();
      if (element != null)
        return LineJoinBevelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LineJoinBevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineJoinBevelConverter.CreateOpenXmlElement<DXD.LineJoinBevel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Miter? Miter
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Miter>();
      if (element != null)
        return MiterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Miter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MiterConverter.CreateOpenXmlElement<DXD.Miter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.HeadEnd? HeadEnd
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.HeadEnd>();
      if (element != null)
        return HeadEndConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HeadEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeadEndConverter.CreateOpenXmlElement<DXD.HeadEnd>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.TailEnd? TailEnd
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.TailEnd>();
      if (element != null)
        return TailEndConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.TailEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TailEndConverter.CreateOpenXmlElement<DXD.TailEnd>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.LinePropertiesExtensionList? LinePropertiesExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LinePropertiesExtensionList>();
      if (element != null)
        return LinePropertiesExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LinePropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.LinePropertiesExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
