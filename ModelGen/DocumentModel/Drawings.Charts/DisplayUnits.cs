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
      var element = _Element?.GetFirstChild<DXDC.CustomDisplayUnit>();
      if (element != null)
        return CustomDisplayUnitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.CustomDisplayUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomDisplayUnitConverter.CreateOpenXmlElement<DXDC.CustomDisplayUnit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.DisplayUnitsLabel>();
      if (element != null)
        return DisplayUnitsLabelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DisplayUnitsLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayUnitsLabelConverter.CreateOpenXmlElement<DXDC.DisplayUnitsLabel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
