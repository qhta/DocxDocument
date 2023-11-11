namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the DialogBoxLauncher Class.
/// </summary>
public partial class DialogBoxLauncher: ModelElement<DXO10CUI.DialogBoxLauncher>
{
  public DialogBoxLauncher(): base(){ }
  
  public DialogBoxLauncher(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DialogBoxLauncher(DXO10CUI.DialogBoxLauncher openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ButtonRegular.
  /// </summary>
  [DataMember]
  public DMCUI10.ButtonRegular? ButtonRegular
  {
    get
    {
      return _Element?.GetObject<DMCUI10.ButtonRegular,DXO10CUI.ButtonRegular>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.ButtonRegular,DXO10CUI.ButtonRegular>(value);
    }
  }
  
}
