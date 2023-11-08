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
      var element = _Element?.GetFirstChild<DXW.Active>();
      if (element != null)
        return ActiveConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Active>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ActiveConverter.CreateOpenXmlElement<DXW.Active>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.ColumnIndex>();
      if (element != null)
        return ColumnIndexConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ColumnIndex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnIndexConverter.CreateOpenXmlElement<DXW.ColumnIndex>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.UniqueTag>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.UniqueTag,DocumentModel.Base64Binary>(openXmlElement, value);
    }
  }
  
}
