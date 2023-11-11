namespace DocumentModel.Drawings.Charts10;


/// <summary>
///   Defines the SketchOptions Class.
/// </summary>
public partial class SketchOptions: ModelElement<DXO10DC.SketchOptions>
{
  public SketchOptions(): base(){ }
  
  public SketchOptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SketchOptions(DXO10DC.SketchOptions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   InSketchMode.
  /// </summary>
  [DataMember]
  public DMDC10.InSketchMode? InSketchMode
  {
    get
    {
      return _Element?.GetObject<DMDC10.InSketchMode,DXO10DC.InSketchMode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.InSketchMode,DXO10DC.InSketchMode>(value);
    }
  }
  
  
  /// <summary>
  ///   ShowSketchButton.
  /// </summary>
  [DataMember]
  public Boolean? ShowSketchButton
  {
    get
    {
      return _ExistingElement.GetFirstChild<DXO10DC.ShowSketchButton>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXO10DC.ShowSketchButton>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXO10DC.ShowSketchButton();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
