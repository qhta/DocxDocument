namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the properties which shall be applied a single latent style for this document. Latent styles refer to any set of known style definitions which have not been included in the current document.
/// </summary>
public partial class LatentStyleExceptionInfo: ModelElement<DXW.LatentStyleExceptionInfo>
{
  public LatentStyleExceptionInfo(): base(){ }
  
  public LatentStyleExceptionInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LatentStyleExceptionInfo(DXW.LatentStyleExceptionInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Primary Style Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Latent Style Locking Setting
  /// </summary>
  [DataMember]
  public Boolean? Locked
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Locked);
    }
    set
    {
      _ExistingElement.Locked = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Override default sorting order
  /// </summary>
  [DataMember]
  public Int32? UiPriority
  {
    get
    {
      return _Element?.UiPriority?.Value;
    }
    set
    {
      _ExistingElement.UiPriority = value;
    }
  }
  
  
  /// <summary>
  ///   Semi hidden text override
  /// </summary>
  [DataMember]
  public Boolean? SemiHidden
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.SemiHidden);
    }
    set
    {
      _ExistingElement.SemiHidden = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Unhide when used
  /// </summary>
  [DataMember]
  public Boolean? UnhideWhenUsed
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.UnhideWhenUsed);
    }
    set
    {
      _ExistingElement.UnhideWhenUsed = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Latent Style Primary Style Setting
  /// </summary>
  [DataMember]
  public Boolean? PrimaryStyle
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.PrimaryStyle);
    }
    set
    {
      _ExistingElement.PrimaryStyle = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
