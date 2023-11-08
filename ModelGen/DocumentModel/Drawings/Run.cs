namespace DocumentModel.Drawings;


/// <summary>
///   Text Run.
/// </summary>
public partial class Run: ModelElement<DXD.Run>
{
  public Run(): base(){ }
  
  public Run(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Run(DXD.Run openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  [DataMember]
  public DMD.RunProperties? RunProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.RunProperties>();
      if (element != null)
        return RunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DXD.RunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Text String.
  /// </summary>
  [DataMember]
  public DMD.Text? Text
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Text>();
      if (element != null)
        return TextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Text>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextConverter.CreateOpenXmlElement<DXD.Text>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
