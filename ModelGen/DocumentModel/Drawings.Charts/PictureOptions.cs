namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PictureOptions Class.
/// </summary>
public partial class PictureOptions: ModelElement<DXDC.PictureOptions>
{
  public PictureOptions(): base(){ }
  
  public PictureOptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PictureOptions(DXDC.PictureOptions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Apply To Front.
  /// </summary>
  [DataMember]
  public DMDC.ApplyToFront? ApplyToFront
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ApplyToFront>();
      if (element != null)
        return ApplyToFrontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ApplyToFront>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ApplyToFrontConverter.CreateOpenXmlElement<DXDC.ApplyToFront>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Apply To Sides.
  /// </summary>
  [DataMember]
  public DMDC.ApplyToSides? ApplyToSides
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ApplyToSides>();
      if (element != null)
        return ApplyToSidesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ApplyToSides>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ApplyToSidesConverter.CreateOpenXmlElement<DXDC.ApplyToSides>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Apply to End.
  /// </summary>
  [DataMember]
  public DMDC.ApplyToEnd? ApplyToEnd
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ApplyToEnd>();
      if (element != null)
        return ApplyToEndConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ApplyToEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ApplyToEndConverter.CreateOpenXmlElement<DXDC.ApplyToEnd>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Picture Format.
  /// </summary>
  [DataMember]
  public DMDC.PictureFormatKind? PictureFormat
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDC.PictureFormatKind>(_ExistingElement.GetFirstChild<DXDC.PictureFormat>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PictureFormat>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDC.PictureFormatKind>(itemElement, (DMDC.PictureFormatKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.PictureFormat, DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDC.PictureFormatKind>((DMDC.PictureFormatKind)value));
    }
  }
  
  
  /// <summary>
  ///   Picture Stack Unit.
  /// </summary>
  [DataMember]
  public Double? PictureStackUnit
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.PictureStackUnit>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.PictureStackUnit,System.Double>(openXmlElement, value);
    }
  }
  
}
