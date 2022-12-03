namespace DocumentModel.Presentation;

/// <summary>
/// Customer Data List.
/// </summary>
public interface CustomerDataList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<CustomerData>? CustomerDatas { get ; set; }
  
  public CustomerDataTags? CustomerDataTags { get ; set; }
  
}
