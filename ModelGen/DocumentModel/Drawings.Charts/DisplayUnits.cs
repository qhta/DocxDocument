namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DisplayUnits Class.
/// </summary>
public partial class DisplayUnits: ModelElement<DXDC.DisplayUnits>
{
  public DisplayUnits(): base(){ }
  
  public DisplayUnits(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DisplayUnits(DXDC.DisplayUnits openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.CustomDisplayUnit? CustomDisplayUnit
  {
    get
    {
      return _Element?.GetObject<DMDC.CustomDisplayUnit,DXDC.CustomDisplayUnit>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.CustomDisplayUnit,DXDC.CustomDisplayUnit>(value);
    }
  }
  
  [DataMember]
  public DMDC.BuiltInUnitKind? BuiltInUnit
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDC.BuiltInUnitKind>(_ExistingElement.GetFirstChild<DXDC.BuiltInUnit>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.BuiltInUnit>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDC.BuiltInUnitKind>(itemElement, (DMDC.BuiltInUnitKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.BuiltInUnit, DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDC.BuiltInUnitKind>((DMDC.BuiltInUnitKind)value));
    }
  }
  
  [DataMember]
  public DMDC.DisplayUnitsLabel? DisplayUnitsLabel
  {
    get
    {
      return _Element?.GetObject<DMDC.DisplayUnitsLabel,DXDC.DisplayUnitsLabel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DisplayUnitsLabel,DXDC.DisplayUnitsLabel>(value);
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
