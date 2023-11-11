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
      return _Element?.GetObject<DMDC.ApplyToFront,DXDC.ApplyToFront>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ApplyToFront,DXDC.ApplyToFront>(value);
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
      return _Element?.GetObject<DMDC.ApplyToSides,DXDC.ApplyToSides>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ApplyToSides,DXDC.ApplyToSides>(value);
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
      return _Element?.GetObject<DMDC.ApplyToEnd,DXDC.ApplyToEnd>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ApplyToEnd,DXDC.ApplyToEnd>(value);
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
      SimpleValueConverter.SetValue<DXDC.PictureStackUnit,System.Double>(_ExistingElement, value);
    }
  }
  
}
