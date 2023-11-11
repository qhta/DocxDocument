namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the current paragraph uses numbering information that is defined by a particular numbering definition instance.
/// </summary>
public partial class NumberingProperties: ModelElement<DXW.NumberingProperties>
{
  public NumberingProperties(): base(){ }
  
  public NumberingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingProperties(DXW.NumberingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Numbering Level Reference.
  /// </summary>
  [DataMember]
  public Int32? NumberingLevelReference
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.NumberingLevelReference>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.NumberingLevelReference,System.Int32>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Numbering Definition Instance Reference.
  /// </summary>
  [DataMember]
  public DMW.NumberingId? NumberingId
  {
    get
    {
      return _Element?.GetObject<DMW.NumberingId,DXW.NumberingId>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NumberingId,DXW.NumberingId>(value);
    }
  }
  
  
  /// <summary>
  ///   Previous Paragraph Numbering Properties.
  /// </summary>
  [DataMember]
  public DMW.NumberingChange? NumberingChange
  {
    get
    {
      return _Element?.GetObject<DMW.NumberingChange,DXW.NumberingChange>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NumberingChange,DXW.NumberingChange>(value);
    }
  }
  
  
  /// <summary>
  ///   Inserted Numbering Properties.
  /// </summary>
  [DataMember]
  public DMW.Inserted? Inserted
  {
    get
    {
      return _Element?.GetObject<DMW.Inserted,DXW.Inserted>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Inserted,DXW.Inserted>(value);
    }
  }
  
}
