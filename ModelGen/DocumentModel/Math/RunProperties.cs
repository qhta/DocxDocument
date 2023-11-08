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
      var element = _Element?.GetFirstChild<DXM.Literal>();
      if (element != null)
        return LiteralConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Literal>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LiteralConverter.CreateOpenXmlElement<DXM.Literal>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMM.NormalText? NormalText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.NormalText>();
      if (element != null)
        return NormalTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.NormalText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NormalTextConverter.CreateOpenXmlElement<DXM.NormalText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.Break>();
      if (element != null)
        return BreakConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Break>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BreakConverter.CreateOpenXmlElement<DXM.Break>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMM.Alignment? Alignment
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Alignment>();
      if (element != null)
        return AlignmentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Alignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlignmentConverter.CreateOpenXmlElement<DXM.Alignment>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
