namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LevelOverride Class.
/// </summary>
public partial class LevelOverride: ModelElement<DXW.LevelOverride>
{
  public LevelOverride(): base(){ }
  
  public LevelOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelOverride(DXW.LevelOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Numbering Level ID
  /// </summary>
  [DataMember]
  public Int32? LevelIndex
  {
    get
    {
      return _Element?.LevelIndex?.Value;
    }
    set
    {
      _ExistingElement.LevelIndex = value;
    }
  }
  
  
  /// <summary>
  ///   Numbering Level Starting Value Override.
  /// </summary>
  [DataMember]
  public DMW.StartOverrideNumberingValue? StartOverrideNumberingValue
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.StartOverrideNumberingValue>();
      if (element != null)
        return StartOverrideNumberingValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StartOverrideNumberingValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StartOverrideNumberingValueConverter.CreateOpenXmlElement<DXW.StartOverrideNumberingValue>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Numbering Level Override Definition.
  /// </summary>
  [DataMember]
  public DMW.Level? Level
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Level>();
      if (element != null)
        return LevelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Level>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LevelConverter.CreateOpenXmlElement<DXW.Level>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
