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
      return _Element?.GetObject<DMCUI.UnsizedButton,DXOCUI.UnsizedButton>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI.UnsizedButton,DXOCUI.UnsizedButton>(value);
    }
  }
  
}
