namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the DialogBoxLauncher Class.
/// </summary>
public partial class DialogBoxLauncher: ModelElement<DXOCUI.DialogBoxLauncher>
{
  public DialogBoxLauncher(): base(){ }
  
  public DialogBoxLauncher(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DialogBoxLauncher(DXOCUI.DialogBoxLauncher openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   UnsizedButton.
  /// </summary>
  [DataMember]
  public DMCUI.UnsizedButton? UnsizedButton
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOCUI.UnsizedButton>();
      if (element != null)
        return UnsizedButtonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.UnsizedButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnsizedButtonConverter.CreateOpenXmlElement<DXOCUI.UnsizedButton>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
