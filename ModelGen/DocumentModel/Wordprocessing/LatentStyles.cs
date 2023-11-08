namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the properties which shall be applied to a set of latent styles for this document. Latent styles refer to any set of style definitions known to an application which have not been included in the current document.
/// </summary>
public partial class LatentStyles: ModelElement<DXW.LatentStyles>
{
  public LatentStyles(): base(){ }
  
  public LatentStyles(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LatentStyles(DXW.LatentStyles openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Default Style Locking Setting
  /// </summary>
  [DataMember]
  public Boolean? DefaultLockedState
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DefaultLockedState);
    }
    set
    {
      _ExistingElement.DefaultLockedState = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Default User Interface Priority Setting
  /// </summary>
  [DataMember]
  public Int32? DefaultUiPriority
  {
    get
    {
      return _Element?.DefaultUiPriority?.Value;
    }
    set
    {
      _ExistingElement.DefaultUiPriority = value;
    }
  }
  
  
  /// <summary>
  ///   Default Semi-Hidden Setting
  /// </summary>
  [DataMember]
  public Boolean? DefaultSemiHidden
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DefaultSemiHidden);
    }
    set
    {
      _ExistingElement.DefaultSemiHidden = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Default Hidden Until Used Setting
  /// </summary>
  [DataMember]
  public Boolean? DefaultUnhideWhenUsed
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DefaultUnhideWhenUsed);
    }
    set
    {
      _ExistingElement.DefaultUnhideWhenUsed = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Default Primary Style Setting
  /// </summary>
  [DataMember]
  public Boolean? DefaultPrimaryStyle
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DefaultPrimaryStyle);
    }
    set
    {
      _ExistingElement.DefaultPrimaryStyle = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Latent Style Count
  /// </summary>
  [DataMember]
  public Int32? Count
  {
    get
    {
      return _Element?.Count?.Value;
    }
    set
    {
      _ExistingElement.Count = value;
    }
  }
  
}
