namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the SharpenSoften Class.
/// </summary>
public partial class SharpenSoften: ModelElement<DXO10D.SharpenSoften>
{
  public SharpenSoften(): base(){ }
  
  public SharpenSoften(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SharpenSoften(DXO10D.SharpenSoften openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   amount, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Amount
  {
    get
    {
      return _Element?.Amount?.Value;
    }
    set
    {
      _ExistingElement.Amount = value;
    }
  }
  
}
