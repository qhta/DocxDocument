namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the DataModelExtensionBlock Class.
/// </summary>
public partial class DataModelExtensionBlock: ModelElement<DXOD.DataModelExtensionBlock>
{
  public DataModelExtensionBlock(): base(){ }
  
  public DataModelExtensionBlock(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataModelExtensionBlock(DXOD.DataModelExtensionBlock openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   relId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? RelId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RelId);
    }
    set
    {
      _ExistingElement.RelId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   minVer, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? MinVer
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MinVer);
    }
    set
    {
      _ExistingElement.MinVer = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
