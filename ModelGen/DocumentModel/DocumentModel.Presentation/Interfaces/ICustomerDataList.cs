namespace DocumentModel.Presentation;

/// <summary>
/// Customer Data List.
/// </summary>
public interface ICustomerDataList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ICustomerData>? CustomerDatas { get ; set; }
  
  public DocumentModel.Presentation.ICustomerDataTags? CustomerDataTags { get ; set; }
  
}
