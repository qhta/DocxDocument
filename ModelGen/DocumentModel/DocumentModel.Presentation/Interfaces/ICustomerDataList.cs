namespace DocumentModel.Presentation;

/// <summary>
/// Customer Data List.
/// </summary>
public interface ICustomerDataList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICustomerData>? CustomerDatas { get ; set; }
  
  public ICustomerDataTags? CustomerDataTags { get ; set; }
  
}
