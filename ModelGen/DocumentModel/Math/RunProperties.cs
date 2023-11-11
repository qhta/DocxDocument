namespace DocumentModel.Math;


/// <summary>
///   Run Properties.
/// </summary>
public partial class RunProperties: ModelElement<DXM.RunProperties>
{
  public RunProperties(): base(){ }
  
  public RunProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunProperties(DXM.RunProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Literal.
  /// </summary>
  [DataMember]
  public DMM.Literal? Literal
  {
    get
    {
      return _Element?.GetObject<DMM.Literal,DXM.Literal>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Literal,DXM.Literal>(value);
    }
  }
  
  [DataMember]
  public DMM.NormalText? NormalText
  {
    get
    {
      return _Element?.GetObject<DMM.NormalText,DXM.NormalText>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.NormalText,DXM.NormalText>(value);
    }
  }
  
  [DataMember]
  public DMM.ScriptKind? Script
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ScriptValues, DMM.ScriptKind>(_ExistingElement.GetFirstChild<DXM.Script>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Script>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.ScriptValues, DMM.ScriptKind>(itemElement, (DMM.ScriptKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.Script, DocumentFormat.OpenXml.Math.ScriptValues, DMM.ScriptKind>((DMM.ScriptKind)value));
    }
  }
  
  [DataMember]
  public DMM.StyleKind? Style
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.StyleValues, DMM.StyleKind>(_ExistingElement.GetFirstChild<DXM.Style>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Style>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.StyleValues, DMM.StyleKind>(itemElement, (DMM.StyleKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.Style, DocumentFormat.OpenXml.Math.StyleValues, DMM.StyleKind>((DMM.StyleKind)value));
    }
  }
  
  [DataMember]
  public DMM.Break? Break
  {
    get
    {
      return _Element?.GetObject<DMM.Break,DXM.Break>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Break,DXM.Break>(value);
    }
  }
  
  [DataMember]
  public DMM.Alignment? Alignment
  {
    get
    {
      return _Element?.GetObject<DMM.Alignment,DXM.Alignment>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Alignment,DXM.Alignment>(value);
    }
  }
  
}
