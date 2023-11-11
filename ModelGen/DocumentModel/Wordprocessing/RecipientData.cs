namespace DocumentModel.Wordprocessing;


/// <summary>
///   Data About Single Data Source Record.
/// </summary>
public partial class RecipientData: ModelElement<DXW.RecipientData>
{
  public RecipientData(): base(){ }
  
  public RecipientData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RecipientData(DXW.RecipientData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Record Is Included in Mail Merge.
  /// </summary>
  [DataMember]
  public DMW.Active? Active
  {
    get
    {
      return _Element?.GetObject<DMW.Active,DXW.Active>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Active,DXW.Active>(value);
    }
  }
  
  
  /// <summary>
  ///   Index of Column Containing Unique Values for Record.
  /// </summary>
  [DataMember]
  public DMW.ColumnIndex? ColumnIndex
  {
    get
    {
      return _Element?.GetObject<DMW.ColumnIndex,DXW.ColumnIndex>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ColumnIndex,DXW.ColumnIndex>(value);
    }
  }
  
  
  /// <summary>
  ///   Unique Value for Record.
  /// </summary>
  [DataMember]
  public DM.Base64Binary? UniqueTag
  {
    get
    {
      return Base64BinaryConverter.GetValue(_Element?.UniqueTag);
    }
    set
    {
      _ExistingElement.UniqueTag = Base64BinaryConverter.CreateOpenXmlElement<DXW.UniqueTag>(value);
    }
  }
  
}
